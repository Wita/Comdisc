namespace CommunityDiscovery.FuncAreaWindow
{
    partial class PluginsCfg
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
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.qatCustomizeItem1 = new DevComponents.DotNetBar.QatCustomizeItem();
            this.tvXml = new DevComponents.AdvTree.AdvTree();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.btnAddExec = new DevComponents.DotNetBar.ButtonX();
            this.btnModifyExec = new DevComponents.DotNetBar.ButtonX();
            this.btnDelExec = new DevComponents.DotNetBar.ButtonX();
            this.btnChecked = new DevComponents.DotNetBar.ButtonX();
            this.btnChangeName = new DevComponents.DotNetBar.ButtonX();
            this.btnSetTarget = new DevComponents.DotNetBar.ButtonX();
            this.tbProcName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbTargetName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbModifyName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbNewPath = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            ((System.ComponentModel.ISupportInitialize)(this.tvXml)).BeginInit();
            this.panelEx1.SuspendLayout();
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
            this.ribbonControl1.Size = new System.Drawing.Size(707, 445);
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
            // tvXml
            // 
            this.tvXml.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.tvXml.AllowDrop = true;
            this.tvXml.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.tvXml.BackgroundStyle.Class = "TreeBorderKey";
            this.tvXml.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tvXml.Location = new System.Drawing.Point(10, 14);
            this.tvXml.Name = "tvXml";
            this.tvXml.NodesConnector = this.nodeConnector1;
            this.tvXml.NodeStyle = this.elementStyle1;
            this.tvXml.PathSeparator = ";";
            this.tvXml.Size = new System.Drawing.Size(318, 368);
            this.tvXml.Styles.Add(this.elementStyle1);
            this.tvXml.TabIndex = 1;
            this.tvXml.Text = "advTree1";
            // 
            // nodeConnector1
            // 
            this.nodeConnector1.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle1
            // 
            this.elementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // btnAddExec
            // 
            this.btnAddExec.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddExec.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddExec.Location = new System.Drawing.Point(603, 43);
            this.btnAddExec.Name = "btnAddExec";
            this.btnAddExec.Size = new System.Drawing.Size(75, 23);
            this.btnAddExec.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddExec.TabIndex = 2;
            this.btnAddExec.Text = "添加程序";
            this.btnAddExec.Click += new System.EventHandler(this.btnAddExec_Click);
            // 
            // btnModifyExec
            // 
            this.btnModifyExec.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnModifyExec.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnModifyExec.Location = new System.Drawing.Point(603, 222);
            this.btnModifyExec.Name = "btnModifyExec";
            this.btnModifyExec.Size = new System.Drawing.Size(75, 23);
            this.btnModifyExec.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnModifyExec.TabIndex = 2;
            this.btnModifyExec.Text = "修改程序";
            this.btnModifyExec.Click += new System.EventHandler(this.btnModifyExec_Click);
            // 
            // btnDelExec
            // 
            this.btnDelExec.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelExec.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelExec.Location = new System.Drawing.Point(603, 270);
            this.btnDelExec.Name = "btnDelExec";
            this.btnDelExec.Size = new System.Drawing.Size(75, 23);
            this.btnDelExec.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDelExec.TabIndex = 4;
            this.btnDelExec.Text = "删除程序";
            this.btnDelExec.Click += new System.EventHandler(this.btnDelExec_Click);
            // 
            // btnChecked
            // 
            this.btnChecked.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnChecked.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnChecked.Location = new System.Drawing.Point(603, 371);
            this.btnChecked.Name = "btnChecked";
            this.btnChecked.Size = new System.Drawing.Size(75, 23);
            this.btnChecked.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnChecked.TabIndex = 5;
            this.btnChecked.Text = "确定";
            this.btnChecked.Click += new System.EventHandler(this.btnChecked_Click);
            // 
            // btnChangeName
            // 
            this.btnChangeName.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnChangeName.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnChangeName.Location = new System.Drawing.Point(603, 163);
            this.btnChangeName.Name = "btnChangeName";
            this.btnChangeName.Size = new System.Drawing.Size(75, 23);
            this.btnChangeName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnChangeName.TabIndex = 6;
            this.btnChangeName.Text = "变更名称";
            this.btnChangeName.Click += new System.EventHandler(this.btnChangeName_Click);
            // 
            // btnSetTarget
            // 
            this.btnSetTarget.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSetTarget.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSetTarget.Location = new System.Drawing.Point(603, 102);
            this.btnSetTarget.Name = "btnSetTarget";
            this.btnSetTarget.Size = new System.Drawing.Size(75, 23);
            this.btnSetTarget.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSetTarget.TabIndex = 8;
            this.btnSetTarget.Text = "设定目标";
            this.btnSetTarget.Click += new System.EventHandler(this.btnSetTarget_Click);
            // 
            // tbProcName
            // 
            // 
            // 
            // 
            this.tbProcName.Border.Class = "TextBoxBorder";
            this.tbProcName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbProcName.Location = new System.Drawing.Point(360, 45);
            this.tbProcName.Name = "tbProcName";
            this.tbProcName.Size = new System.Drawing.Size(237, 21);
            this.tbProcName.TabIndex = 9;
            this.tbProcName.Text = "输入程序名称";
            // 
            // tbTargetName
            // 
            // 
            // 
            // 
            this.tbTargetName.Border.Class = "TextBoxBorder";
            this.tbTargetName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbTargetName.Location = new System.Drawing.Point(360, 104);
            this.tbTargetName.Name = "tbTargetName";
            this.tbTargetName.ReadOnly = true;
            this.tbTargetName.Size = new System.Drawing.Size(237, 21);
            this.tbTargetName.TabIndex = 10;
            // 
            // tbModifyName
            // 
            // 
            // 
            // 
            this.tbModifyName.Border.Class = "TextBoxBorder";
            this.tbModifyName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbModifyName.Location = new System.Drawing.Point(360, 165);
            this.tbModifyName.Name = "tbModifyName";
            this.tbModifyName.Size = new System.Drawing.Size(237, 21);
            this.tbModifyName.TabIndex = 11;
            this.tbModifyName.Text = "输入要替换成的名称";
            // 
            // tbNewPath
            // 
            // 
            // 
            // 
            this.tbNewPath.Border.Class = "TextBoxBorder";
            this.tbNewPath.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbNewPath.Location = new System.Drawing.Point(360, 224);
            this.tbNewPath.Name = "tbNewPath";
            this.tbNewPath.ReadOnly = true;
            this.tbNewPath.Size = new System.Drawing.Size(237, 21);
            this.tbNewPath.TabIndex = 12;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.btnChangeName);
            this.panelEx1.Controls.Add(this.tvXml);
            this.panelEx1.Controls.Add(this.btnAddExec);
            this.panelEx1.Controls.Add(this.btnModifyExec);
            this.panelEx1.Controls.Add(this.tbNewPath);
            this.panelEx1.Controls.Add(this.btnDelExec);
            this.panelEx1.Controls.Add(this.tbModifyName);
            this.panelEx1.Controls.Add(this.btnChecked);
            this.panelEx1.Controls.Add(this.tbTargetName);
            this.panelEx1.Controls.Add(this.btnSetTarget);
            this.panelEx1.Controls.Add(this.tbProcName);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx1.Location = new System.Drawing.Point(0, 28);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(707, 417);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 16;
            // 
            // PluginsCfg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 445);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PluginsCfg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "插件配置窗口";
            ((System.ComponentModel.ISupportInitialize)(this.tvXml)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.QatCustomizeItem qatCustomizeItem1;
        private DevComponents.AdvTree.AdvTree tvXml;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private DevComponents.DotNetBar.ButtonX btnAddExec;
        private DevComponents.DotNetBar.ButtonX btnModifyExec;
        private DevComponents.DotNetBar.ButtonX btnDelExec;
        private DevComponents.DotNetBar.ButtonX btnChecked;
        private DevComponents.DotNetBar.ButtonX btnChangeName;
        private DevComponents.DotNetBar.ButtonX btnSetTarget;
        private DevComponents.DotNetBar.Controls.TextBoxX tbProcName;
        private DevComponents.DotNetBar.Controls.TextBoxX tbTargetName;
        private DevComponents.DotNetBar.Controls.TextBoxX tbModifyName;
        private DevComponents.DotNetBar.Controls.TextBoxX tbNewPath;
        private DevComponents.DotNetBar.PanelEx panelEx1;
    }
}