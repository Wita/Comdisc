using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MainProcess.FuncAreaWindow;

namespace MainProcess.UtilClass
{
    class SpiderSettings
    {
        CDMessageBox mbox = new CDMessageBox();

        private string allowed_domains;

        public string Allowed_domains
        {
            get { return allowed_domains; }
            set { allowed_domains = value; }
        }
        private string start_urls;

        public string Start_urls
        {
            get { return start_urls; }
            set { start_urls = value; }
        }
        private int download_timeout;

        public int Download_timeout
        {
            get { return download_timeout; }
            set { download_timeout = value; }
        }
        private int concurrent_items;

        public int Concurrent_items
        {
            get { return concurrent_items; }
            set { concurrent_items = value; }
        }
        private int concurrent_requests;

        public int Concurrent_requests
        {
            get { return concurrent_requests; }
            set { concurrent_requests = value; }
        }
        private int concurrent_requests_per_domain;

        public int Concurrent_requests_per_domain
        {
            get { return concurrent_requests_per_domain; }
            set { concurrent_requests_per_domain = value; }
        }
        private int concurrent_requests_per_ip;

        public int Concurrent_requests_per_ip
        {
            get { return concurrent_requests_per_ip; }
            set { concurrent_requests_per_ip = value; }
        }
        private int depth_limit;

        public int Depth_limit
        {
            get { return depth_limit; }
            set { depth_limit = value; }
        }
        private int depth_priority;

        public int Depth_priority
        {
            get { return depth_priority; }
            set { depth_priority = value; }
        }
        private bool depth_stats;

        public bool Depth_stats
        {
            get { return depth_stats; }
            set { depth_stats = value; }
        }
        private bool dnscache_enabled;

        public bool Dnscache_enabled
        {
            get { return dnscache_enabled; }
            set { dnscache_enabled = value; }
        }
        private int download_delay;

        public int Download_delay
        {
            get { return download_delay; }
            set { download_delay = value; }
        }
        private bool cookies_enabled;

        public bool Cookies_enabled
        {
            get { return cookies_enabled; }
            set { cookies_enabled = value; }
        }
        private bool retry_enabled;

        public bool Retry_enabled
        {
            get { return retry_enabled; }
            set { retry_enabled = value; }
        }
        private bool redirect_enabled;

        public bool Redirect_enabled
        {
            get { return redirect_enabled; }
            set { redirect_enabled = value; }
        }
        private bool ajaxcrawl_enabled;

        public bool Ajaxcrawl_enabled
        {
            get { return ajaxcrawl_enabled; }
            set { ajaxcrawl_enabled = value; }
        }



        public void Sets(Dictionary<string,string> attrDic)
        {
            try
            {
                allowed_domains = attrDic["allowed_domains"].ToString();
                start_urls = attrDic["start_urls"].ToString();
                download_timeout = int.Parse(attrDic["DOWNLOAD_TIMEOUT"].ToString());
                concurrent_items = int.Parse(attrDic["CONCURRENT_ITEMS"].ToString());
                concurrent_requests = int.Parse(attrDic["CONCURRENT_REQUESTS"].ToString());
                concurrent_requests_per_domain = int.Parse(attrDic["CONCURRENT_REQUESTS_PER_DOMAIN"].ToString());
                concurrent_requests_per_ip = int.Parse(attrDic["CONCURRENT_REQUESTS_PER_IP"].ToString());
                depth_limit = int.Parse(attrDic["DEPTH_LIMIT"].ToString());
                depth_priority = int.Parse(attrDic["DEPTH_PRIORITY"].ToString());
                depth_stats = bool.Parse(attrDic["DEPTH_STATS"].ToString());
                dnscache_enabled = bool.Parse(attrDic["DNSCACHE_ENABLED"].ToString());
                download_delay = int.Parse(attrDic["DOWNLOAD_DELAY"].ToString());
                cookies_enabled = bool.Parse(attrDic["COOKIES_ENABLED"].ToString());
                retry_enabled = bool.Parse(attrDic["RETRY_ENABLED"].ToString());
                redirect_enabled = bool.Parse(attrDic["REDIRECT_ENABLED"].ToString());
                ajaxcrawl_enabled = bool.Parse(attrDic["AJAXCRAWL_ENABLED"].ToString());
            }
            catch (Exception)
            {
                mbox.Show("SpiderCfg.ini配置文件内容不完整！");
            }

        }

        

    }
}
