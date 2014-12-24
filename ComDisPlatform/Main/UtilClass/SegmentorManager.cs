using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using CommunityDiscovery;

namespace MainProcess.UtilClass
{
    class SegmentorManager
    {
        private static readonly string spiderCfgFile = Path.Combine(System.Environment.CurrentDirectory, "SegCfg.ini").ToString();



        public static Dictionary<string, string> ReadSegCfg()
        {
            List<string> lineList = ReadFileByLine(spiderCfgFile);
            Dictionary<string, string> attrDic = new Dictionary<string, string>();
            foreach (string line in lineList)
            {
                List<string> sep = line.Split(new char[] { '=', '>' }).ToList();
                attrDic.Add(sep[0].ToString().Trim(), sep[2].ToString().Trim());
            }
            return attrDic;
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



        public static void ResetSpiderCfg(SegmentSettings settings)
        {
            StringBuilder content = new StringBuilder();
            content.AppendLine("url_get_base => " + settings.Url_get_base);
            content.AppendLine("api_key => " + settings.Api_key);
            content.AppendLine("format => " + settings.Format);
            content.AppendLine("pattern => " + settings.Pattern);
            content.AppendLine("xml_input =>" + settings.Xml_input);
            content.AppendLine("has_key =>" + settings.Has_key);
            content.AppendLine("only_ner =>" + settings.Only_ner);
            content.AppendLine("callback =>" + settings.Callback);
            content.AppendLine("filterFileName => " + settings.FilterFileName);
            content.AppendLine("savePath => " + settings.SavePath);
            content.AppendLine("sourcePath => " + settings.SourcePath);
            WriteToFile(content.ToString(), spiderCfgFile);
        }

        public static SegmentSettings DicToSettings(Dictionary<string, string> dic)
        {
            SegmentSettings settings = new SegmentSettings();
            try
            {
                settings.Url_get_base = dic["url_get_base"].ToString();
                settings.Api_key = dic["api_key"].ToString();
                settings.Format = dic["format"].ToString();
                settings.Pattern = dic["pattern"].ToString();
                settings.Xml_input = dic["xml_input"].ToString();
                settings.Has_key = dic["has_key"].ToString();
                settings.Only_ner = dic["only_ner"].ToString();
                settings.Callback = dic["callback"].ToString();
                settings.FilterFileName = dic["filterFileName"].ToString();
                settings.SavePath = dic["savePath"].ToString();
                settings.SourcePath = dic["sourcePath"].ToString();
            }
            catch (Exception)
            {
                MainWindow.Msg("分词器配置错误！请检查！");
                return null;
            }

            return settings;

        }

    }
}
