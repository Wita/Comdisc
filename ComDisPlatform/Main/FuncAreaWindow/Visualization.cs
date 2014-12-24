using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CefSharp.WinForms;
using MainProcess.UtilClass;

namespace MainProcess.FuncAreaWindow
{
    public partial class Visualization : Form
    {
        static Visualization window = null;
        public Visualization()
        {
            InitializeComponent();
            window = this;
            
            
        }
        public void Show(string dataFile, string targetFullPath)
        {
            HtmlManager.SetHtml(dataFile, targetFullPath);
            WebView view = new WebView();
            view.Address = targetFullPath;
            view.Parent = window.ribbonClientPanel1;
            view.Dock = DockStyle.Fill;
            this.Show();
        }
    }
}
