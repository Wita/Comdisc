using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Configuration;
using DevComponents.AdvTree;
using CommunityDiscovery.UtilClass;
using MainProcess.FuncAreaWindow;

namespace CommunityDiscovery.FuncAreaWindow
{
    public partial class PluginsCfg : Form
    {
        public CDMessageBox mbox = new CDMessageBox();
        public PluginsCfg()
        {
            InitializeComponent();
            ShowXmlData();
        }

        private void ShowXmlData()
        {
            this.tvXml.Nodes.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load(ConfigurationManager.AppSettings["funcAreaConfigFilePath"].ToString());
            XmlNode pNode = doc.DocumentElement;
            NodeCollection nodes = (NodeCollection)this.tvXml.Nodes;
            foreach (XmlNode node in doc.ChildNodes)
            {
                string text = (node.Value != null ? node.Value : (node.Attributes != null && node.Attributes.Count > 0) ? node.Attributes[0].Value : node.Name);
                Node new_child = new Node(text);
                nodes.Add(new_child);

                BindXmlData(node, new_child.Nodes);

            }
            this.tvXml.ExpandAll();
        }

        private void BindXmlData(XmlNode doc, NodeCollection nodes)
        {


            foreach (XmlNode node in doc.ChildNodes)
            {
                string text = (node.Value != null ? node.Value : (node.Attributes != null && node.Attributes.Count > 0) ? node.Attributes[0].Value : node.Name);
                Node new_child = new Node(text);
                nodes.Add(new_child);

                BindXmlData(node, new_child.Nodes);

            }
        }


        private void btnAddExec_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            foreach (string item in XmlHelper.ItemClass)
            {
                list.Add(item);
            }
            try
            {
                if (!list.Contains(tvXml.SelectedNode.ToString()))
                {
                    return;
                }
                
            }
            catch (Exception)
            {
                mbox.Show("选择的项目不允许添加程序或未选择项目！");
            }
            if (tvXml.SelectedNodes.Count > 0)
            {
                tbProcName.Enabled = true;
                btnSetTarget.Enabled = true;
            }
            if (String.IsNullOrEmpty(tbProcName.Text) || tbProcName.Text == "输入程序名称")
            {
                return;
            }
            
            XmlHelper.AddPlugin(tvXml.SelectedNode.ToString(), tbProcName.Text, tbTargetName.Text);
            ShowXmlData();
        }

        private void btnChangeName_Click(object sender, EventArgs e)
        {
            //设置 XML文件中的Byanme属性
            try
            {
                XmlHelper.ModifyName(tvXml.SelectedNode.Parent.ToString(), tvXml.SelectedNode.ToString(), tbModifyName.Text);

            }
            catch (Exception)
            {
            }
            ShowXmlData();
        }

        private void btnModifyExec_Click(object sender, EventArgs e)
        {
           //修改 XML文件中的最终节点
            XmlHelper.ResetTarget(tvXml.SelectedNode.Parent.ToString(), tvXml.SelectedNode.ToString(), tbNewPath.Text);
            ShowXmlData();
        }

        private void btnDelExec_Click(object sender, EventArgs e)
        {
            //从XML文件中删除该节点,有些节点是不能删的
            XmlHelper.DelNode(tvXml.SelectedNode.Parent.ToString(), tvXml.SelectedNode.ToString());
            ShowXmlData();
        }


        private void btnSetTarget_Click(object sender, EventArgs e)
        {
            tbTargetName.Enabled = true;
            OpenFileDialog wnd = new OpenFileDialog();
            wnd.ShowDialog();
            if (wnd.FileName != "")
            {
                tbTargetName.Text = wnd.FileName.ToString();
            }
            if (String.IsNullOrEmpty(tbProcName.Text) || tbProcName.Text == "输入程序名称" || String.IsNullOrEmpty(tbTargetName.Text))
            {
                return;                
            }
            XmlHelper.ResetTarget(tvXml.SelectedNode.Parent.ToString(), tvXml.SelectedNode.ToString(), tbTargetName.Text);
            ShowXmlData();
        }

        private void btnChecked_Click(object sender, EventArgs e)
        {
            if (tvXml.SelectedNode.ToString() == "" && tbProcName.Text == "" && tbTargetName.Text == "")
            {
                mbox.Show("数据不完整！");
                return;
            }
            XmlHelper.AddPlugin(tvXml.SelectedNode.ToString(), tbProcName.Text, tbTargetName.Text, tbModifyName.Text == "输入要替换成的名称" ? "" : tbModifyName.Text);
            ShowXmlData();
            MainWindow.Msg("完成系统配置.");
        }

        
    }
}
