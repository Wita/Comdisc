using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CommunityDiscovery.UtilClass;
using DevComponents.DotNetBar;
using System.Diagnostics;
using System.Configuration;
using CommunityDiscovery.FuncAreaWindow;
using MainProcess.FuncAreaWindow;
using MainProcess.UtilClass;
using System.Net.NetworkInformation;
using Microsoft.Win32;
using System.IO;

namespace CommunityDiscovery
{
    public partial class MainWindow : Form
    {
        public static MainWindow window = null;
        public Process process = null;
        CDMessageBox mbox = new CDMessageBox();

        private static string pathValue = RegistryManager.ReadPath();

        public MainWindow()
        {
            InitializeComponent();
            window = this;

            tbCmdLine.Text += "Loading...\n";
            Btn_DataPatch(this, new EventArgs());
            Btn_DataModel(this, new EventArgs());
            Btn_DataSimplify(this, new EventArgs());
            Btn_KnowlegeFound(this, new EventArgs());
            Btn_NetworkTopicFound(this, new EventArgs());
            Btn_SystemControl(this, new EventArgs());
            Btn_UIStyle(this, new EventArgs());
            Btn_Help(this, new EventArgs());
            RegistryManager.SetProcPath();
            tbCmdLine.Text += "程序已加载\n";
        }

        #region 功能区加载
        //数据获取
        private void Btn_DataPatch(object sender, EventArgs e)
        {
            if (ribbonPanel1.Controls.Count > 0)
            {
                return;
            }
            this.GetXmlDataByTabName("数据获取", ribbonPanel1);
        }

        //数据建模
        private void Btn_DataModel(object sender, EventArgs e)
        {
            if (ribbonPanel2.Controls.Count > 0)
            {
                return;
            }
            this.GetXmlDataByTabName("数据建模", ribbonPanel2);

        }

        //数据约简
        private void Btn_DataSimplify(object sender, EventArgs e)
        {
            if (ribbonPanel3.Controls.Count > 0)
            {
                return;
            }
            this.GetXmlDataByTabName("数据约简", ribbonPanel3);
        }

        //知识发现
        private void Btn_KnowlegeFound(object sender, EventArgs e)
        {
            if (ribbonPanel4.Controls.Count > 0)
            {
                return;
            }
            this.GetXmlDataByTabName("知识发现", ribbonPanel4);
        }

        //网络话题发现
        private void Btn_NetworkTopicFound(object sender, EventArgs e)
        {
            if (ribbonPanel5.Controls.Count > 0)
            {
                return;
            }
            this.GetXmlDataByTabName("网络话题发现", ribbonPanel5);
        }

        //系统
        private void Btn_SystemControl(object sender, EventArgs e)
        {
            if (ribbonPanel6.Controls.Count > 0)
            {
                return;
            }
            this.GetXmlDataByTabName("系统", ribbonPanel6);
        }

        //界面风格
        private void Btn_UIStyle(object sender, EventArgs e)
        {
            if (ribbonPanel7.Controls.Count > 0)
            {
                return;
            }
            this.GetXmlDataByTabName("界面风格", ribbonPanel7);
        }

        //帮助
        private void Btn_Help(object sender, EventArgs e)
        {
            if (ribbonPanel8.Controls.Count > 0)
            {
                return;
            }
            this.GetXmlDataByTabName("帮助", ribbonPanel8);
        }
        #endregion

        private void GetXmlDataByTabName(string tabName, RibbonPanel ribbonPanel)
        {
            //根据barName从xml文件中获取项目
            Dictionary<string, string> dic = XmlHelper.GetAttrByBarNameValue(tabName);

            foreach (KeyValuePair<string, string> item in dic.Reverse())
            {
                RibbonBar bar = new RibbonBar();
                ribbonPanel.Controls.Add(bar);
                bar.Size = new System.Drawing.Size(125, 165);
                ButtonItem btn = new ButtonItem();
                btn.Text = item.Key.ToString();
                btn.SubItemsExpandWidth = 15;

                bar.Items.AddRange(new BaseItem[] { btn });
                //设置Button响应事件
                //添加程序路径
                string path = item.Value.ToString().Trim();
                switch (item.Key.ToString())
                {
                    case "系统设置":
                        {
                            //这里不允许用户自定义系统设置,所以无论如何都是使用系统自带的设置
                            btn.Click += (EventHandler)delegate
                            {
                                PluginsCfg wnd = new PluginsCfg();
                                wnd.ShowDialog();
                            };
                            break;
                        }
                    case "分词设置":
                        {
                            //可能会出现用户自定义分词器的情况，所以要分两种情况考虑
                            if (path != "")
                            {
                                btn.Click += (EventHandler)delegate { RunExe(path); };
                                continue;
                            }
                            btn.Click += (EventHandler)delegate
                            {
                                SegmentorCfg wnd = new SegmentorCfg();
                                wnd.ShowDialog();
                            };
                            break;
                        }
                    case "中文分词":
                        {
                            //可能会出现用户自定义分词器的情况，所以要分两种情况考虑
                            if (path != "")
                            {
                                btn.Click += (EventHandler)delegate { RunExe(path); };
                                continue;
                            }
                            btn.Click += (EventHandler)delegate
                            {
                                if (!ConnectionManager.CheckConnection())
                                {
                                    Msg("请检查网络连接！");
                                    return;
                                }

                                ButtonItem btnStop = new ButtonItem()
                                {
                                    Text = " 停  止 ",
                                    SubItemsExpandWidth = 15

                                };
                                List<string> list = new List<string>();
                                list.Add(@"Segment\Segmentor.exe");
                                list.Add("exit");
                                btnStop.Click += (EventHandler)delegate
                                {
                                    bar.Items.Remove(btnStop);
                                    bar.Size = new System.Drawing.Size(125, 165);
                                    KillProc("Segmentor");
                                    CmdClose(new object(), new FormClosingEventArgs(new CloseReason(), false));
                                };
                                bar.Items.Add(btnStop);
                                bar.Size = new System.Drawing.Size(250, 165);
                                CmdRun(list);
                                bar.Items.Remove(btnStop);
                                bar.Size = new System.Drawing.Size(125, 165);
                                KillProc("Segmentor");

                            };
                            break;
                        }
                    case "环境设置":    //不允许其他的tab中出现同样的名字,如果出现都是按照同样的路径处理
                        {
                            if (path != "")
                            {
                                btn.Click += (EventHandler)delegate { RunExe(path); };
                                continue;
                            }
                            btn.Click += (EventHandler)delegate
                            {
                                SpiderCfg wnd = new SpiderCfg();
                                wnd.ShowDialog();
                            };
                            break;
                        }
                    case "爬取数据":
                        {

                            List<string> list = new List<string>();
                            list.Add(@"Spider\Run.exe");
                            list.Add("exit");
                            btn.Click += (EventHandler)delegate
                            {
                                if (!CheckConfiguration())
                                {
                                    Msg("请检查爬虫配置文件！");
                                    return;
                                }
                                else if (!ConnectionManager.CheckConnection())
                                {
                                    Msg("请检查网络连接！");
                                    return;
                                }
                                ButtonItem btnStop = new ButtonItem()
                                {
                                    Text = " 停  止 ",
                                    SubItemsExpandWidth = 15
                                };
                                btnStop.Click += (EventHandler)delegate
                                {
                                    bar.Items.Remove(btnStop);
                                    bar.Size = new System.Drawing.Size(125, 165);
                                    KillProc("Run");
                                    CmdClose(new object(), new FormClosingEventArgs(new CloseReason(), false));
                                    if (process != null)
                                    {
                                        process.Close();
                                    }
                                };
                                bar.Items.Add(btnStop);
                                bar.Size = new System.Drawing.Size(250, 165);
                                CmdRun(list);

                            };

                            
                            break;
                        }
                    case "结果可视化":
                        {
                            btn.Click += (EventHandler)delegate 
                            {
                                //需要绝对路径,并且路径中不能有#字符
                                string dataFile = @"D:\Files\社区识别\程序设计\ComDiscPF\ComDisPlatform\Main\bin\Release\Visualization\datSet\data.txt";
                                string targetFullPath = @"D:\Files\社区识别\程序设计\ComDiscPF\ComDisPlatform\Main\bin\Release\Visualization\index.html";
                                Visualization form = new Visualization();
                                form.Show(dataFile,targetFullPath);
                            };
                            break;
                        }
                    default:
                        {
                            btn.Click += (EventHandler)delegate { RunExe(path); };
                            break;
                        }
                }

            }
        }


        /// <summary>
        /// 插件程序文件路径
        /// </summary>
        /// <param name="exePath"></param>
        /// <returns></returns>
        private void RunExe(string exePath)
        {
            if (exePath == "")
            {
                mbox.Show("插件路径未设置!\n配置文件路径为：" + ConfigurationManager.AppSettings["funcAreaConfigFilePath"].ToString() + "\n或系统->系统设置 中设置");
                return;
            }
            Process exeProc = new Process();
            try
            {
                ProcessStartInfo info = new ProcessStartInfo(exePath);
                exeProc.StartInfo = info;
                exeProc.Start();
                while (!exeProc.HasExited)
                {
                    exeProc.WaitForExit();
                }
            }
            catch (Exception)
            {
                mbox.Show("找不到程序！");
            }
            
            return;
        }



        #region 爬虫控制台信息输出到文本框

        private void CmdRun(List<string> cmdList)
        {

            process = new Process();
            Control.CheckForIllegalCrossThreadCalls = false;
            process.StartInfo.FileName = ConfigurationManager.AppSettings["cmdPath"].ToString();
            process.StartInfo.WorkingDirectory = ".";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.OutputDataReceived += new DataReceivedEventHandler(CmdShow);
            process.Start();

            foreach (string cmd in cmdList)
            {
                process.StandardInput.WriteLine(cmd);
            }

            process.BeginOutputReadLine();
        }

        private void CmdShow(object sendingProcess, DataReceivedEventArgs outLine)
        {
            if (!String.IsNullOrEmpty(outLine.Data))
            {
                this.tbCmdLine.AppendText(outLine.Data+"\n");
                this.tbCmdLine.ScrollToCaret();
            }
        }

        private void CmdClose(object sender, FormClosingEventArgs e)
        {
            KillProc("Run");
            if (process != null)
            {
                process.Close();
            }
        }

        private void KillProc(string procName)
        {

            Process[] ps = Process.GetProcesses();

            try
            {
                foreach (Process item in ps)
                {
                    if (item.ProcessName == procName)
                    {
                        item.Kill();
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        #endregion

        #region 爬虫配置文件及网络检查

        public bool CheckConfiguration()
        {
            if (!CheckConnection())
            {
                mbox.Show("请检查网络连接！");
                return false;
            }
            CheckConfigFile();
            return true;
        }

        public bool CheckConnection()
        {
            return ConnectionManager.CheckConnection();
        }
        public void CheckEnviromentVariable()
        {
            RegistryManager.SetProcPath();
        }
        public void CheckConfigFile()
        {
            //判断lxmlParseCfg.ini spiderCfg.ini xpathParseCfg.ini文件是否存在
            string spiderCfg = Path.Combine(pathValue, "spiderCfg.ini");
            string lxmlParseCfg = Path.Combine(pathValue, "lxmlParseCfg.ini");
            string xpathParseCfg = Path.Combine(pathValue, "xpathParseCfg.ini");
            if (!File.Exists(spiderCfg))
            {
                //好像是如果不存在应该重新写入才对呀……
                //mbox.Show(spiderCfg + "文件不存在，请重新确认！程序即将退出！");
                SpiderCfgManager.SpiderDefaultCfg();
            }
            if (!File.Exists(lxmlParseCfg))
            {
                //mbox.Show(lxmlParseCfg + "文件不存在，请重新确认！程序即将退出！");
                SpiderCfgManager.LxmlDefaultCfg();
            }
            if (!File.Exists(xpathParseCfg))
            {
                //mbox.Show(xpathParseCfg + "文件不存在，请重新确认！程序即将退出！");
                SpiderCfgManager.XpathDefaultCfg();
            }


        }

        #endregion

        #region 分词配置检查

        #endregion


        #region 信息传递

        public static void Msg(string info)
        {
            window.ShowInfoLine("\n" + info);
        }

        private void ShowInfoLine(string info)
        {
            this.tbCmdLine.AppendText(info);
            this.tbCmdLine.ScrollToCaret();
        }
        #endregion
    }
}
