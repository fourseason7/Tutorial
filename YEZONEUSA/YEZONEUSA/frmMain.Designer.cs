namespace YEZONEUSA
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.btnAbout = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barSubMenuFile = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.navBarMainMenu = new DevExpress.XtraNavBar.NavBarControl();
            this.grpLabel = new DevExpress.XtraNavBar.NavBarGroup();
            this.mnuLabelQR = new DevExpress.XtraNavBar.NavBarItem();
            this.mnuLabelPacking = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarMainMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubMenuFile,
            this.barButtonItem2,
            this.barSubItem1,
            this.btnExit,
            this.barSubItem2,
            this.btnAbout});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "&File";
            this.barSubItem1.Id = 2;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExit)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Exit";
            this.btnExit.Id = 3;
            this.btnExit.Name = "btnExit";
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick);
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "&Help";
            this.barSubItem2.Id = 4;
            this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAbout)});
            this.barSubItem2.Name = "barSubItem2";
            // 
            // btnAbout
            // 
            this.btnAbout.Caption = "About";
            this.btnAbout.Id = 5;
            this.btnAbout.Name = "btnAbout";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1008, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 706);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1008, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 655);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1008, 51);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 655);
            // 
            // barSubMenuFile
            // 
            this.barSubMenuFile.Caption = "File";
            this.barSubMenuFile.Id = 0;
            this.barSubMenuFile.Name = "barSubMenuFile";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Help";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // navBarMainMenu
            // 
            this.navBarMainMenu.ActiveGroup = this.grpLabel;
            this.navBarMainMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarMainMenu.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.grpLabel});
            this.navBarMainMenu.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.mnuLabelPacking,
            this.mnuLabelQR});
            this.navBarMainMenu.Location = new System.Drawing.Point(0, 51);
            this.navBarMainMenu.Name = "navBarMainMenu";
            this.navBarMainMenu.OptionsNavPane.ExpandedWidth = 175;
            this.navBarMainMenu.Size = new System.Drawing.Size(175, 655);
            this.navBarMainMenu.TabIndex = 5;
            this.navBarMainMenu.Text = "navBarControl1";
            this.navBarMainMenu.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarMainMenu_LinkClicked);
            // 
            // grpLabel
            // 
            this.grpLabel.Caption = "Label Print";
            this.grpLabel.Expanded = true;
            this.grpLabel.ImageOptions.LargeImage = global::YEZONEUSA.Properties.Resources.label_16x16;
            this.grpLabel.ImageOptions.SmallImage = global::YEZONEUSA.Properties.Resources.label_16x16;
            this.grpLabel.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.mnuLabelQR),
            new DevExpress.XtraNavBar.NavBarItemLink(this.mnuLabelPacking)});
            this.grpLabel.Name = "grpLabel";
            // 
            // mnuLabelQR
            // 
            this.mnuLabelQR.Caption = "QR Label";
            this.mnuLabelQR.ImageOptions.LargeImage = global::YEZONEUSA.Properties.Resources.QR_code_32x32;
            this.mnuLabelQR.ImageOptions.SmallImage = global::YEZONEUSA.Properties.Resources.QR_code_32x32;
            this.mnuLabelQR.Name = "mnuLabelQR";
            this.mnuLabelQR.Tag = "YEZONEUSA.frmQRLable";
            // 
            // mnuLabelPacking
            // 
            this.mnuLabelPacking.Caption = "Packing Label";
            this.mnuLabelPacking.ImageOptions.LargeImage = global::YEZONEUSA.Properties.Resources.Packing;
            this.mnuLabelPacking.ImageOptions.SmallImage = global::YEZONEUSA.Properties.Resources.Packing;
            this.mnuLabelPacking.Name = "mnuLabelPacking";
            this.mnuLabelPacking.Tag = "YEZONEUSA.frmPacking";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.navBarMainMenu);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarMainMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarButtonItem btnAbout;
        private DevExpress.XtraNavBar.NavBarControl navBarMainMenu;
        private DevExpress.XtraNavBar.NavBarGroup grpLabel;
        private DevExpress.XtraNavBar.NavBarItem mnuLabelQR;
        private DevExpress.XtraNavBar.NavBarItem mnuLabelPacking;
        private DevExpress.XtraBars.BarButtonItem barSubMenuFile;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}