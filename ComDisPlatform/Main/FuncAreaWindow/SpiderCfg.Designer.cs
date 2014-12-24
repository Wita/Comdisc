namespace MainProcess.FuncAreaWindow
{
    partial class SpiderCfg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.qatCustomizeItem1 = new DevComponents.DotNetBar.QatCustomizeItem();
            this.tbStartUrls = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbSavePath = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.rbSepecialized = new System.Windows.Forms.RadioButton();
            this.rbDepth = new System.Windows.Forms.RadioButton();
            this.rbWhole = new System.Windows.Forms.RadioButton();
            this.cbDepthPriority = new System.Windows.Forms.ComboBox();
            this.tbTimeOut = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.dgRules = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.webPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xpath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSet = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnSavePath = new DevComponents.DotNetBar.ButtonX();
            this.superTabControl1 = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.superTabItem1 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.superTabItem2 = new DevComponents.DotNetBar.SuperTabItem();
            this.tbDomains = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDepth = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbConcurrent = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label4 = new System.Windows.Forms.Label();
            this.swbCookies = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.label5 = new System.Windows.Forms.Label();
            this.swbRetry = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.label6 = new System.Windows.Forms.Label();
            this.swbRedirect = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.label7 = new System.Windows.Forms.Label();
            this.swbAjax = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbDownloadDelay = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dgLxmlRules = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.urlPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lxmlRules = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgRules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).BeginInit();
            this.superTabControl1.SuspendLayout();
            this.superTabControlPanel1.SuspendLayout();
            this.superTabControlPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLxmlRules)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            // 
            // 
            // 
            this.ribbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonControl1.CaptionVisible = true;
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ribbonControl1.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.qatCustomizeItem1});
            this.ribbonControl1.Size = new System.Drawing.Size(748, 521);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonControl1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.ribbonControl1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.ribbonControl1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.ribbonControl1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.ribbonControl1.SystemText.QatDialogAddButton = "&Add >>";
            this.ribbonControl1.SystemText.QatDialogCancelButton = "Cancel";
            this.ribbonControl1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.ribbonControl1.SystemText.QatDialogOkButton = "OK";
            this.ribbonControl1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatDialogRemoveButton = "&Remove";
            this.ribbonControl1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.ribbonControl1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 0;
            this.ribbonControl1.Text = "ribbonControl1";
            // 
            // qatCustomizeItem1
            // 
            this.qatCustomizeItem1.Name = "qatCustomizeItem1";
            // 
            // tbStartUrls
            // 
            // 
            // 
            // 
            this.tbStartUrls.Border.Class = "TextBoxBorder";
            this.tbStartUrls.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbStartUrls.Location = new System.Drawing.Point(105, 107);
            this.tbStartUrls.Name = "tbStartUrls";
            this.tbStartUrls.Size = new System.Drawing.Size(567, 21);
            this.tbStartUrls.TabIndex = 3;
            this.tbStartUrls.Text = "起始链接";
            // 
            // tbSavePath
            // 
            // 
            // 
            // 
            this.tbSavePath.Border.Class = "TextBoxBorder";
            this.tbSavePath.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbSavePath.Location = new System.Drawing.Point(105, 143);
            this.tbSavePath.Name = "tbSavePath";
            this.tbSavePath.Size = new System.Drawing.Size(567, 21);
            this.tbSavePath.TabIndex = 4;
            this.tbSavePath.Text = "保存路径";
            // 
            // rbSepecialized
            // 
            this.rbSepecialized.AutoSize = true;
            this.rbSepecialized.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.rbSepecialized.Location = new System.Drawing.Point(55, 45);
            this.rbSepecialized.Name = "rbSepecialized";
            this.rbSepecialized.Size = new System.Drawing.Size(95, 16);
            this.rbSepecialized.TabIndex = 5;
            this.rbSepecialized.TabStop = true;
            this.rbSepecialized.Text = "指定站点搜索";
            this.rbSepecialized.UseVisualStyleBackColor = false;
            // 
            // rbDepth
            // 
            this.rbDepth.AutoSize = true;
            this.rbDepth.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.rbDepth.Location = new System.Drawing.Point(167, 45);
            this.rbDepth.Name = "rbDepth";
            this.rbDepth.Size = new System.Drawing.Size(95, 16);
            this.rbDepth.TabIndex = 6;
            this.rbDepth.TabStop = true;
            this.rbDepth.Text = "深度优先搜索";
            this.rbDepth.UseVisualStyleBackColor = false;
            // 
            // rbWhole
            // 
            this.rbWhole.AutoSize = true;
            this.rbWhole.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.rbWhole.Location = new System.Drawing.Point(322, 45);
            this.rbWhole.Name = "rbWhole";
            this.rbWhole.Size = new System.Drawing.Size(71, 16);
            this.rbWhole.TabIndex = 7;
            this.rbWhole.TabStop = true;
            this.rbWhole.Text = "全网搜索";
            this.rbWhole.UseVisualStyleBackColor = false;
            // 
            // cbDepthPriority
            // 
            this.cbDepthPriority.FormattingEnabled = true;
            this.cbDepthPriority.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbDepthPriority.Location = new System.Drawing.Point(261, 42);
            this.cbDepthPriority.Name = "cbDepthPriority";
            this.cbDepthPriority.Size = new System.Drawing.Size(45, 20);
            this.cbDepthPriority.TabIndex = 10;
            this.cbDepthPriority.Text = "深度设定";
            // 
            // tbTimeOut
            // 
            // 
            // 
            // 
            this.tbTimeOut.Border.Class = "TextBoxBorder";
            this.tbTimeOut.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbTimeOut.Location = new System.Drawing.Point(105, 190);
            this.tbTimeOut.Name = "tbTimeOut";
            this.tbTimeOut.Size = new System.Drawing.Size(48, 21);
            this.tbTimeOut.TabIndex = 12;
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(55, 269);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(95, 23);
            this.labelX5.TabIndex = 13;
            this.labelX5.Text = "自定义过滤规则";
            // 
            // dgRules
            // 
            this.dgRules.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgRules.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRules.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.webPath,
            this.xpath});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgRules.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgRules.EnableHeadersVisualStyles = false;
            this.dgRules.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgRules.Location = new System.Drawing.Point(0, 0);
            this.dgRules.Name = "dgRules";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRules.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgRules.RowHeadersWidth = 30;
            this.dgRules.RowTemplate.Height = 23;
            this.dgRules.Size = new System.Drawing.Size(652, 159);
            this.dgRules.TabIndex = 14;
            // 
            // webPath
            // 
            this.webPath.HeaderText = "网址路径";
            this.webPath.Name = "webPath";
            // 
            // xpath
            // 
            this.xpath.HeaderText = "Xpath语法规则";
            this.xpath.Name = "xpath";
            // 
            // btnSet
            // 
            this.btnSet.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSet.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSet.Location = new System.Drawing.Point(634, 486);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSet.TabIndex = 15;
            this.btnSet.Text = "确定";
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Location = new System.Drawing.Point(548, 486);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSavePath
            // 
            this.btnSavePath.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSavePath.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSavePath.Location = new System.Drawing.Point(678, 141);
            this.btnSavePath.Name = "btnSavePath";
            this.btnSavePath.Size = new System.Drawing.Size(26, 23);
            this.btnSavePath.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSavePath.TabIndex = 17;
            this.btnSavePath.Text = "...";
            this.btnSavePath.Click += new System.EventHandler(this.btnSavePath_Click);
            // 
            // superTabControl1
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.superTabControl1.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.superTabControl1.ControlBox.MenuBox.Name = "";
            this.superTabControl1.ControlBox.Name = "";
            this.superTabControl1.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabControl1.ControlBox.MenuBox,
            this.superTabControl1.ControlBox.CloseBox});
            this.superTabControl1.Controls.Add(this.superTabControlPanel2);
            this.superTabControl1.Controls.Add(this.superTabControlPanel1);
            this.superTabControl1.Location = new System.Drawing.Point(55, 293);
            this.superTabControl1.Name = "superTabControl1";
            this.superTabControl1.ReorderTabsEnabled = true;
            this.superTabControl1.SelectedTabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.superTabControl1.SelectedTabIndex = 0;
            this.superTabControl1.Size = new System.Drawing.Size(652, 187);
            this.superTabControl1.TabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.superTabControl1.TabIndex = 18;
            this.superTabControl1.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabItem1,
            this.superTabItem2});
            this.superTabControl1.Text = "superTabControl1";
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Controls.Add(this.dgRules);
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 28);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(652, 159);
            this.superTabControlPanel1.TabIndex = 1;
            this.superTabControlPanel1.TabItem = this.superTabItem1;
            // 
            // superTabItem1
            // 
            this.superTabItem1.AttachedControl = this.superTabControlPanel1;
            this.superTabItem1.GlobalItem = false;
            this.superTabItem1.Name = "superTabItem1";
            this.superTabItem1.Text = "文本解析";
            // 
            // superTabControlPanel2
            // 
            this.superTabControlPanel2.Controls.Add(this.dgLxmlRules);
            this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel2.Location = new System.Drawing.Point(0, 28);
            this.superTabControlPanel2.Name = "superTabControlPanel2";
            this.superTabControlPanel2.Size = new System.Drawing.Size(652, 159);
            this.superTabControlPanel2.TabIndex = 0;
            this.superTabControlPanel2.TabItem = this.superTabItem2;
            // 
            // superTabItem2
            // 
            this.superTabItem2.AttachedControl = this.superTabControlPanel2;
            this.superTabItem2.GlobalItem = false;
            this.superTabItem2.Name = "superTabItem2";
            this.superTabItem2.Text = "lxml规则解析";
            // 
            // tbDomains
            // 
            // 
            // 
            // 
            this.tbDomains.Border.Class = "TextBoxBorder";
            this.tbDomains.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbDomains.Location = new System.Drawing.Point(105, 73);
            this.tbDomains.Name = "tbDomains";
            this.tbDomains.Size = new System.Drawing.Size(567, 21);
            this.tbDomains.TabIndex = 19;
            this.tbDomains.Text = "域名限定";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(165, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "爬取深度";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Location = new System.Drawing.Point(53, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 20;
            this.label2.Text = "响应超时";
            // 
            // cbDepth
            // 
            this.cbDepth.FormattingEnabled = true;
            this.cbDepth.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbDepth.Location = new System.Drawing.Point(215, 190);
            this.cbDepth.Name = "cbDepth";
            this.cbDepth.Size = new System.Drawing.Size(45, 20);
            this.cbDepth.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Location = new System.Drawing.Point(267, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 20;
            this.label3.Text = "并发数";
            // 
            // tbConcurrent
            // 
            // 
            // 
            // 
            this.tbConcurrent.Border.Class = "TextBoxBorder";
            this.tbConcurrent.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbConcurrent.Location = new System.Drawing.Point(310, 190);
            this.tbConcurrent.Name = "tbConcurrent";
            this.tbConcurrent.Size = new System.Drawing.Size(42, 21);
            this.tbConcurrent.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Location = new System.Drawing.Point(53, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 20;
            this.label4.Text = "禁止Cookies";
            // 
            // swbCookies
            // 
            // 
            // 
            // 
            this.swbCookies.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.swbCookies.Location = new System.Drawing.Point(125, 225);
            this.swbCookies.Name = "swbCookies";
            this.swbCookies.Size = new System.Drawing.Size(56, 19);
            this.swbCookies.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.swbCookies.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Location = new System.Drawing.Point(380, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "禁止重试";
            // 
            // swbRetry
            // 
            // 
            // 
            // 
            this.swbRetry.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.swbRetry.Location = new System.Drawing.Point(437, 226);
            this.swbRetry.Name = "swbRetry";
            this.swbRetry.Size = new System.Drawing.Size(56, 19);
            this.swbRetry.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.swbRetry.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label6.Location = new System.Drawing.Point(216, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "禁止重定向";
            // 
            // swbRedirect
            // 
            // 
            // 
            // 
            this.swbRedirect.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.swbRedirect.Location = new System.Drawing.Point(285, 225);
            this.swbRedirect.Name = "swbRedirect";
            this.swbRedirect.Size = new System.Drawing.Size(56, 19);
            this.swbRedirect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.swbRedirect.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label7.Location = new System.Drawing.Point(530, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 20;
            this.label7.Text = "AJAX爬取";
            // 
            // swbAjax
            // 
            // 
            // 
            // 
            this.swbAjax.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.swbAjax.Location = new System.Drawing.Point(586, 225);
            this.swbAjax.Name = "swbAjax";
            this.swbAjax.Size = new System.Drawing.Size(56, 19);
            this.swbAjax.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.swbAjax.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label8.Location = new System.Drawing.Point(53, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "域名限定";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label9.Location = new System.Drawing.Point(51, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 20;
            this.label9.Text = "起始链接";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label10.Location = new System.Drawing.Point(50, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 20;
            this.label10.Text = "保存路径";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label11.Location = new System.Drawing.Point(367, 194);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 20;
            this.label11.Text = "延时下载";
            // 
            // tbDownloadDelay
            // 
            // 
            // 
            // 
            this.tbDownloadDelay.Border.Class = "TextBoxBorder";
            this.tbDownloadDelay.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbDownloadDelay.Location = new System.Drawing.Point(421, 189);
            this.tbDownloadDelay.Name = "tbDownloadDelay";
            this.tbDownloadDelay.Size = new System.Drawing.Size(42, 21);
            this.tbDownloadDelay.TabIndex = 22;
            // 
            // dgLxmlRules
            // 
            this.dgLxmlRules.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgLxmlRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLxmlRules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urlPath,
            this.lxmlRules});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgLxmlRules.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgLxmlRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgLxmlRules.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgLxmlRules.Location = new System.Drawing.Point(0, 0);
            this.dgLxmlRules.Name = "dgLxmlRules";
            this.dgLxmlRules.RowTemplate.Height = 23;
            this.dgLxmlRules.Size = new System.Drawing.Size(652, 159);
            this.dgLxmlRules.TabIndex = 0;
            // 
            // urlPath
            // 
            this.urlPath.HeaderText = "网址路径";
            this.urlPath.Name = "urlPath";
            // 
            // lxmlRules
            // 
            this.lxmlRules.HeaderText = "Lxml规则";
            this.lxmlRules.Name = "lxmlRules";
            // 
            // SpiderCfg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 521);
            this.Controls.Add(this.swbRetry);
            this.Controls.Add(this.swbAjax);
            this.Controls.Add(this.swbRedirect);
            this.Controls.Add(this.swbCookies);
            this.Controls.Add(this.tbDownloadDelay);
            this.Controls.Add(this.tbConcurrent);
            this.Controls.Add(this.cbDepth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDomains);
            this.Controls.Add(this.superTabControl1);
            this.Controls.Add(this.btnSavePath);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.tbTimeOut);
            this.Controls.Add(this.cbDepthPriority);
            this.Controls.Add(this.rbWhole);
            this.Controls.Add(this.rbDepth);
            this.Controls.Add(this.rbSepecialized);
            this.Controls.Add(this.tbSavePath);
            this.Controls.Add(this.tbStartUrls);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SpiderCfg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpiderCfg";
            ((System.ComponentModel.ISupportInitialize)(this.dgRules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).EndInit();
            this.superTabControl1.ResumeLayout(false);
            this.superTabControlPanel1.ResumeLayout(false);
            this.superTabControlPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgLxmlRules)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.QatCustomizeItem qatCustomizeItem1;
        private DevComponents.DotNetBar.Controls.TextBoxX tbStartUrls;
        private DevComponents.DotNetBar.Controls.TextBoxX tbSavePath;
        private System.Windows.Forms.RadioButton rbSepecialized;
        private System.Windows.Forms.RadioButton rbDepth;
        private System.Windows.Forms.RadioButton rbWhole;
        private System.Windows.Forms.ComboBox cbDepthPriority;
        private DevComponents.DotNetBar.Controls.TextBoxX tbTimeOut;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgRules;
        private DevComponents.DotNetBar.ButtonX btnSet;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnSavePath;
        private DevComponents.DotNetBar.SuperTabControl superTabControl1;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel2;
        private DevComponents.DotNetBar.SuperTabItem superTabItem2;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.SuperTabItem superTabItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn webPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn xpath;
        private DevComponents.DotNetBar.Controls.TextBoxX tbDomains;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDepth;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.Controls.TextBoxX tbConcurrent;
        private System.Windows.Forms.Label label4;
        private DevComponents.DotNetBar.Controls.SwitchButton swbCookies;
        private System.Windows.Forms.Label label5;
        private DevComponents.DotNetBar.Controls.SwitchButton swbRetry;
        private System.Windows.Forms.Label label6;
        private DevComponents.DotNetBar.Controls.SwitchButton swbRedirect;
        private System.Windows.Forms.Label label7;
        private DevComponents.DotNetBar.Controls.SwitchButton swbAjax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private DevComponents.DotNetBar.Controls.TextBoxX tbDownloadDelay;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgLxmlRules;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn lxmlRules;
    }
}