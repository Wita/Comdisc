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
    public partial class SpiderCfg : Form
    {
        Dictionary<string, string> attrDic = SpiderCfgManager.ReadSpiderCfg();
        SpiderSettings spiderSettings = new SpiderSettings();


        public SpiderCfg()
        {
            InitializeComponent();
            rbSepecialized.Checked = true;
            setting();
            MainWindow.Msg("爬虫配置信息加载...");
        }
        public void setting()
        {
            spiderSettings.Sets(attrDic);
            tbDomains.Text = spiderSettings.Allowed_domains;
            tbSavePath.Text = getSavePath();
            tbStartUrls.Text = spiderSettings.Start_urls;
            cbDepthPriority.SelectedIndex = spiderSettings.Depth_priority;
            tbTimeOut.Text = spiderSettings.Download_timeout.ToString();
            cbDepth.SelectedIndex = spiderSettings.Depth_limit;
            tbConcurrent.Text = spiderSettings.Concurrent_items.ToString();
            tbDownloadDelay.Text = spiderSettings.Download_delay.ToString();
            swbCookies.Value = spiderSettings.Cookies_enabled;
            swbRedirect.Value = spiderSettings.Redirect_enabled;
            swbRetry.Value = spiderSettings.Retry_enabled;
            swbAjax.Value = spiderSettings.Ajaxcrawl_enabled;
            setXpathList();
            setLxmlList();
        }


        private void btnSavePath_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog file = new FolderBrowserDialog();
            file.ShowDialog();
            if (String.IsNullOrEmpty(file.SelectedPath))
            {
                return;
            }
            tbSavePath.Text = file.SelectedPath;
        }


        private string getSavePath()
        {
            return "";
        }

        private void setXpathList()
        {
            dgRules.Rows.Clear();
            Dictionary<string, string> xpathDic = SpiderCfgManager.ReadXpathCfg();
            foreach (KeyValuePair<string, string> item in xpathDic)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = dgRules.Rows.Add(row);
                dgRules.Rows[index].Cells[0].Value = item.Key.ToString();
                dgRules.Rows[index].Cells[1].Value = item.Value.ToString();
            }
        }
        private void setLxmlList()
        {
            dgLxmlRules.Rows.Clear();
            Dictionary<string, string> lxmlDic = SpiderCfgManager.ReadLxmlCfg();
            foreach (KeyValuePair<string, string> item in lxmlDic)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = dgLxmlRules.Rows.Add(row);
                dgLxmlRules.Rows[index].Cells[0].Value = item.Key.ToString();
                dgLxmlRules.Rows[index].Cells[1].Value = item.Value.ToString();
            }
        }

        private List<XPathSettings> ReadXpathCfgList()
        {
            List<XPathSettings> xpathSettingsList = new List<XPathSettings>();
            foreach (DataGridViewRow row in this.dgRules.Rows)
            {
                XPathSettings xpathSettings = new XPathSettings();
                xpathSettings.Path = row.Cells[0].Value == null ? "":row.Cells[0].Value.ToString();
                xpathSettings.Rules = row.Cells[1].Value == null ? "":row.Cells[1].Value.ToString();
                xpathSettingsList.Add(xpathSettings);
            }
            return xpathSettingsList;
        }

        private void CurrentConfig()
        {
            SpiderSettings currentSetting = new SpiderSettings();
            currentSetting.Allowed_domains = tbDomains.Text;
            currentSetting.Start_urls = tbStartUrls.Text;
            currentSetting.Download_timeout = int.Parse(tbTimeOut.Text);
            currentSetting.Concurrent_items = int.Parse(tbConcurrent.Text);
            //currentSetting.Concurrent_requests=16
            //currentSetting.Concurrent_requests_per_domain=8
            //currentSetting.Concurrent_requests_per_ip=0
            currentSetting.Depth_limit = cbDepth.SelectedIndex;
            currentSetting.Depth_priority = cbDepthPriority.SelectedIndex;
            //currentSetting.Depth_stats=true
            //currentSetting.Dnscache_enabled=true
            currentSetting.Download_delay = int.Parse(tbDownloadDelay.Text);
            currentSetting.Cookies_enabled = swbCookies.Value;
            currentSetting.Retry_enabled = swbRetry.Value;
            currentSetting.Redirect_enabled = swbRedirect.Value;
            currentSetting.Ajaxcrawl_enabled = swbAjax.Value;
            //将当前配置写入文件
            SpiderCfgManager.ResetSpiderCfg(currentSetting);
            SpiderCfgManager.ResetXpathCfg(ReadXpathCfgList());
            
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            MainWindow.Msg("爬虫配置完成");
            CurrentConfig();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
