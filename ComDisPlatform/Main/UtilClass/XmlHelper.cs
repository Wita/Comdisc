using System;
using System.Xml;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Configuration;
using MainProcess.FuncAreaWindow;

namespace CommunityDiscovery.UtilClass
{
    class XmlHelper
    {
        private static CDMessageBox mbox = new CDMessageBox();
        public static readonly string[] ItemClass = {
                                                   "数据获取",
                                                   "数据建模",
                                                   "数据约简",
                                                   "知识发现",
                                                   "网络话题发现",
                                                   "系统",
                                                   "界面风格",
                                                   "帮助"
                                                    };

        private static string xmlConfigFilePath = ConfigurationManager.AppSettings["funcAreaConfigFilePath"].ToString();

        /// <summary>
        /// 暂停使用
        /// </summary>
        public static void ReadXml()
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(xmlConfigFilePath);
            XmlNode root = xml.SelectSingleNode("Root");

            foreach(XmlNode barName in root.ChildNodes)
            {
                foreach (XmlNode tabName in barName.ChildNodes)
                {
                    MessageBox.Show(tabName.Attributes["Text"].Value);
                    MessageBox.Show(tabName.InnerText);
                }
            }
        }

        /// <summary>
        /// 按Value值来获取对应BarName下的所有数据
        /// </summary>
        /// <param name="barNameValue">对应于xml文件中BarName的Value值</param>
        /// <returns>第一个string为按钮的名字，第二个string为程序的路径</returns>
        public static Dictionary<string,string> GetAttrByBarNameValue(string barNameValue)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(xmlConfigFilePath);
            XmlNode root = xml.SelectSingleNode("Root");

            Dictionary<string, string> dic = new Dictionary<string, string>();

            foreach (XmlNode barName in root.ChildNodes)
            {
                if (barName.Attributes["Value"].Value == barNameValue)
                {
                    foreach (XmlNode tabName in barName.ChildNodes)
                    {
                        dic.Add(tabName.Attributes["Text"].Value, tabName.InnerText);
                        
                    }
                }
            }

            return dic;
        }

        /// <summary>
        /// 暂不编写
        /// </summary>
        /// <param name="xmlFilePath"></param>
        public static void ModifyXml(string xmlFilePath)
        { }

        public static void AddPlugin(string barName, string tabName, string execPath,string byname="")
        {
            if (barName == "" || tabName == "")
            {
                return;
            }
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlConfigFilePath);
            XmlNode pNode = doc.SelectSingleNode("//BarName[@Value='" + barName + "']");
            XmlElement elem = doc.CreateElement("TabName");
            elem.SetAttribute("Text", tabName);
            if (byname != "")
            {
                elem.SetAttribute("Byname", byname);
            }
            elem.InnerText = execPath;
            pNode.AppendChild(elem);
            doc.Save(xmlConfigFilePath);
            mbox.Show("添加成功！");
        }

        public static void ModifyName(string barName, string tabName, string newName)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(ConfigurationManager.AppSettings["funcAreaConfigFilePath"].ToString());
            XmlNode pNode = doc.SelectSingleNode("//BarName[@Value='" + barName + "']/TabName[@Text='"+tabName+"']");
            pNode.Attributes["Text"].Value = newName;
            doc.Save(ConfigurationManager.AppSettings["funcAreaConfigFilePath"].ToString());
            mbox.Show("修改成功！");

        }

        public static void DelNode(string barName, string tabName)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlConfigFilePath);
            XmlNode pNode = doc.SelectSingleNode("//BarName[@Value='" + barName + "']");
            pNode.RemoveChild(pNode.SelectSingleNode("//BarName[@Value='"+barName+"']/TabName[@Text='"+tabName+"']"));
            doc.Save(xmlConfigFilePath);
            mbox.Show("删除成功！");
        }

        public static void ResetTarget(string barName, string tabName, string targetpath)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlConfigFilePath);
            XmlNode pNode = doc.SelectSingleNode("//BarName[@Value='" + barName + "']/TabName[@Text='" + tabName + "']");
            pNode.InnerText = targetpath;
            doc.Save(xmlConfigFilePath);
        }
    }
}
