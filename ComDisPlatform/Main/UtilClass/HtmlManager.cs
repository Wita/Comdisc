using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MainProcess.UtilClass
{
    class HtmlManager
    {

        public static void SetHtml(string dataFile, string targetFullPath)
        {
            string content = ReadDataFile(dataFile);
            if (String.IsNullOrEmpty(content))
            {
                return;
            }
            WriteToFile(SetViewContent(content), targetFullPath);
        }

        private static string SetViewContent(string dataSet)
        {
            StringBuilder content = new StringBuilder();
            content.Append("<html><head><meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\"><link rel=\"stylesheet\" href=\"style/halfviz.css\" type=\"text/css\" charset=\"utf-8\"></head><body><div id=\"halfviz\"><canvas id=\"viewport\"></canvas><div id=\"editor\"><div class=\"io\"><div class=\"ctrl\"></div><ul class=\"dialog\"></ul></div><textarea id=\"code\">");
            content.Append(dataSet);
            content.Append("</textarea><div id=\"grabber\"></div></div><div id=\"dashboard\"></div><script src=\"js/jquery-1.6.1.min.js\"></script><script src=\"js/jquery.address-1.4.min.js\"></script><script src=\"lib/arbor.js\"></script><script src=\"js/graphics.js\"></script><script src=\"js/dashboard.js\"></script><script src=\"js/help.js\"></script><script src=\"js/io.js\"></script><script src=\"js/parseur.js\"></script><script src=\"js/renderer.js\"></script><script src=\"js/halfviz.js\"></script></body></html>");
            return content.ToString();

        }

        private static string ReadDataFile(string targetFullName)
        {
            if (!File.Exists(targetFullName))
            {
                return null;
            }
            StringBuilder content = new StringBuilder();
            using (StreamReader file = new StreamReader(targetFullName))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    content.AppendLine(line);
                }
            }
            return content.ToString();
        }

        private static void WriteToFile(string content, string targetFullName)
        {
            if (!File.Exists(targetFullName))
            {
                File.Create(targetFullName).Close();
            }
            StreamWriter file = new StreamWriter(targetFullName);
            file.Write(content);
            file.Flush();
            file.Close();
        }
    }
}
