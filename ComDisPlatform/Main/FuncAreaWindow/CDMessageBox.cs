using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CommunityDiscovery;

namespace MainProcess.FuncAreaWindow
{
    public partial class CDMessageBox : Form
    {
        public CDMessageBox()
        {
            InitializeComponent();
            
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Show(string info)
        {
            this.lbInfo.Text = info.ToString();
            this.ShowDialog();
            MainWindow.Msg(info);
        }
    }
}
