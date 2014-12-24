using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;

namespace MainProcess.UtilClass
{
    class SpiderCfgManager
    {
        private static readonly string spiderCfgFile = Path.Combine(System.Environment.CurrentDirectory, "spiderCfg.ini").ToString();
        private static readonly string lxmlCfgFile = Path.Combine(System.Environment.CurrentDirectory, "lxmlParseCfg.ini").ToString();
        private static readonly string xpathCfgFile = Path.Combine(System.Environment.CurrentDirectory, "xpathParseCfg.ini").ToString();

        public static void SpiderDefaultCfg()
        {
            StringBuilder content = new StringBuilder();
            content.AppendLine("allowed_domains=huanqiu.com");
            content.AppendLine(@"start_urls=http://world.huanqiu.com/exclusive/2014-12/5227815.html");
            content.AppendLine("DOWNLOAD_TIMEOUT=8");
            content.AppendLine("CONCURRENT_ITEMS=100");
            content.AppendLine("CONCURRENT_REQUESTS=16");
            content.AppendLine("CONCURRENT_REQUESTS_PER_DOMAIN=8");
            content.AppendLine("CONCURRENT_REQUESTS_PER_IP=0");
            content.AppendLine("DEPTH_LIMIT=0");
            content.AppendLine("DEPTH_PRIORITY=0");
            content.AppendLine("DEPTH_STATS=True");
            content.AppendLine("DNSCACHE_ENABLED=True");
            content.AppendLine("DOWNLOAD_DELAY=0");
            content.AppendLine("COOKIES_ENABLED=False");
            content.AppendLine("RETRY_ENABLED=False");
            content.AppendLine("REDIRECT_ENABLED=False");
            content.AppendLine("AJAXCRAWL_ENABLED=True");
            WriteToFile(content.ToString(), spiderCfgFile);
        }
        public static void XpathDefaultCfg()
        {
            StringBuilder content = new StringBuilder();
            content.AppendLine(@"[@path]=>http://www.baidu.com/");
            content.AppendLine("rules=//p/text()");
            WriteToFile(content.ToString(), xpathCfgFile);
        }
        public static void LxmlDefaultCfg()
        {
            StringBuilder content = new StringBuilder();
            content.AppendLine(@"[@path]=>http://www.baidu.com/");
            content.AppendLine("remove_tags=div,p,h1,h2,h3,body,strong");
            content.AppendLine("kill_tags=a,li,ul,tr,td,th,span,img,table,tbody,h4,h5,h6");
            WriteToFile(content.ToString(), lxmlCfgFile);
        }
        public static void WriteToFile(string content, string fullName)
        {
            if (!File.Exists(fullName))
            {
                File.Create(fullName).Close();
            }
            StreamWriter file = new StreamWriter(fullName);
            file.Write(content);
            file.Flush();
            file.Close();
        }
        /// <summary>
        /// 读取spiderCfg.ini的配置为字典类型对象
        /// </summary>
        /// <returns></returns>
        public static Dictionary<string, string> ReadSpiderCfg()
        {
            List<string> lineList = ReadFileByLine(spiderCfgFile);
            Dictionary<string, string> attrDic = new Dictionary<string, string>();
            foreach (string line in lineList)
            {
                List<string> sep = line.Split('=').ToList();
                attrDic.Add(sep[0].ToString().Trim(), sep[1].ToString().Trim());
            }
            return attrDic;
        }
        /// <summary>
        /// 读取Xpath配置文件为字典对象
        /// </summary>
        /// <returns></returns>
        public static Dictionary<string, string> ReadXpathCfg()
        {
            string keyPath = "[@path]";
            string keyRules = "rules";
            bool flag = false;  //一组规则开始的标志
            List<string> lineList = ReadFileByLine(xpathCfgFile);
            Dictionary<string, string> attrDic = new Dictionary<string, string>();
            string path = "";
            string rules = "";
            foreach (string line in lineList)
            {

                if (!String.IsNullOrEmpty(line.Trim()))
                {
                    if (line.ToLower().Trim().Contains(keyPath))
                    {
                        List<string> sep = line.Split(new char[] { '=', '>' }).ToList();
                        if (String.IsNullOrEmpty(sep[2].Trim()))
                        {
                            continue;
                        }
                        path = sep[2].Trim();
                        flag = true;
                    }
                    else if (line.ToLower().Trim().Contains(keyRules))
                    {
                        List<string> sep = line.Split('=').ToList();
                        if (String.IsNullOrEmpty(sep[1].Trim()))
                        {
                            continue;
                        }
                        rules = sep[1].Trim();
                        flag = false;
                    }
                    if (!flag)
                    {
                        attrDic.Add(path, rules);
                    }
                }
            }
            return attrDic;
        }



        public static Dictionary<string, string> ReadLxmlCfg()
        {
            string keyPath = "[@path]";
            string keyrmtag = "remove_tags";
            string keykilltag = "kill_tags";
            bool flag = false;
            List<string> lineList = ReadFileByLine(lxmlCfgFile);
            Dictionary<string, string> attrDic = new Dictionary<string, string>();

            string path = "";
            string remove = "";
            string kill = "";
            foreach (string line in lineList)
            {
                
                if (!String.IsNullOrEmpty(line.Trim()))
                {
                    if (line.Contains(keyPath))
                    {
                        List<string> sep = line.Split(new char[] { '=', '>' }).ToList();
                        if (String.IsNullOrEmpty(sep[2].Trim()))
                        {
                            continue;
                        }
                        path = sep[2].Trim();
                        flag = true;
                    }
                    if (line.Contains(keyrmtag))
                    {
                        List<string> sep = line.Split('=').ToList();
                        if (String.IsNullOrEmpty(sep[1].Trim()))
                        {
                            continue;
                        }
                        remove = sep[1].Trim();
                        flag = true;
                    }
                    if (line.Contains(keykilltag))
                    {
                        List<string> sep = line.Split('=').ToList();
                        if (String.IsNullOrEmpty(sep[1].Trim()))
                        {
                            continue;
                        }
                        kill = sep[1].Trim();
                        flag = false;
                    }
                    if (!flag)
                    {
                        attrDic.Add(path, "remove_tags="+remove + "||" + "kill_tags="+kill);
                    }

                }
            }
            return attrDic;
        }


        private static List<string> ReadFileByLine(string filePath)
        {
            List<string> lineList = new List<string>();
            using (StreamReader file = new StreamReader(filePath))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    lineList.Add(line);
                }


            }
            return lineList;
        }

        public static void ResetSpiderCfg(SpiderSettings settings)
        {
            StringBuilder content = new StringBuilder();
            content.AppendLine("allowed_domains=" + settings.Allowed_domains);
            content.AppendLine("start_urls=" + settings.Start_urls);
            content.AppendLine("DOWNLOAD_TIMEOUT=" + settings.Download_timeout.ToString());
            content.AppendLine("CONCURRENT_ITEMS=" + settings.Concurrent_items.ToString());
            content.AppendLine("CONCURRENT_REQUESTS=" + settings.Concurrent_requests.ToString());
            content.AppendLine("CONCURRENT_REQUESTS_PER_DOMAIN=" + settings.Concurrent_requests_per_domain.ToString());
            content.AppendLine("CONCURRENT_REQUESTS_PER_IP=" + settings.Concurrent_requests_per_ip.ToString());
            content.AppendLine("DEPTH_LIMIT=" + settings.Depth_limit.ToString());
            content.AppendLine("DEPTH_PRIORITY=" + settings.Depth_priority.ToString());
            content.AppendLine("DEPTH_STATS=" + settings.Depth_stats.ToString());
            content.AppendLine("DNSCACHE_ENABLED=" + settings.Dnscache_enabled.ToString());
            content.AppendLine("DOWNLOAD_DELAY=" + settings.Download_delay.ToString());
            content.AppendLine("COOKIES_ENABLED=" + settings.Cookies_enabled.ToString());
            content.AppendLine("RETRY_ENABLED=" + settings.Retry_enabled.ToString());
            content.AppendLine("REDIRECT_ENABLED=" + settings.Redirect_enabled.ToString());
            content.AppendLine("AJAXCRAWL_ENABLED=" + settings.Ajaxcrawl_enabled.ToString());

            WriteToFile(content.ToString(), spiderCfgFile);
        }

        public static void ResetXpathCfg(List<XPathSettings> xpathSettings)
        {
            StringBuilder content = new StringBuilder();
            foreach (XPathSettings setting in xpathSettings)
            {
                content.AppendLine("[@path]=>" + setting.Path.ToString());
                content.AppendLine("rules=" + setting.Rules.ToString()); 
            }

            WriteToFile(content.ToString(), xpathCfgFile);
        }

        public static void ResetLxmlCfg(List<LxmlSettings> lxmlSettings)
        {
            StringBuilder content = new StringBuilder();
            foreach (LxmlSettings setting in lxmlSettings)
            {
                content.AppendLine("[@path]=>" + setting.Path.ToString());
                content.AppendLine("remove_tags=" + setting.Remove_tags.ToString());
                content.AppendLine("kill_tags=" + setting.Kill_tags.ToString());
            }
            WriteToFile(content.ToString(), lxmlCfgFile);
        }
    }
}
