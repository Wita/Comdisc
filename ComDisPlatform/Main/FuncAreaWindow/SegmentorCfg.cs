using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MainProcess.UtilClass;
using CommunityDiscovery;

namespace MainProcess.FuncAreaWindow
{
    public partial class SegmentorCfg : Form
    {
        public SegmentorCfg()
        {
            InitializeComponent();
            ReadSettings();
        }

        private void ReadSettings()
        {
            Dictionary<string, string> attrDic = new Dictionary<string, string>();
            attrDic = SegmentorManager.ReadSegCfg();
            tbFolderPath.Text = attrDic["sourcePath"].ToString();
            tbtargetPath.Text = attrDic["savePath"].ToString();
        }


        private void btnFolderPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog file = new FolderBrowserDialog();
            file.ShowDialog();
            if (String.IsNullOrEmpty(file.SelectedPath))
            {
                return;
            }
            tbFolderPath.Text = file.SelectedPath.ToString();
        }

        private void btnSavePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog file = new FolderBrowserDialog();
            file.ShowDialog();
            if (String.IsNullOrEmpty(file.SelectedPath))
            {
                return;
            }
            tbtargetPath.Text = file.SelectedPath;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChecked_Click(object sender, EventArgs e)
        {
            
            Dictionary<string,string> attrDic = SegmentorManager.ReadSegCfg();
            attrDic["sourcePath"] = tbFolderPath.Text;
            attrDic["savePath"] = tbtargetPath.Text;
            SegmentorManager.ResetSpiderCfg(SegmentorManager.DicToSettings(attrDic));
            MainWindow.Msg("分词目录配置完成.");
            this.Close();
        }
    }
}
