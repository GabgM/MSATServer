﻿
namespace MSATServer
{
    partial class MSATServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MSATServer));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.skinPaletteDropDownButtonItem1 = new DevExpress.XtraBars.SkinPaletteDropDownButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.skinPaletteRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.skinGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.skinGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.skinGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.skinGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xp_cmdshell = new DevExpress.XtraTab.XtraTabControl();
            this.sqlserver = new DevExpress.XtraTab.XtraTabPage();
            this.sqlServerPanel = new DevExpress.XtraEditors.PanelControl();
            this.sqlInfo = new System.Windows.Forms.TextBox();
            this.sqlSearch = new System.Windows.Forms.Button();
            this.sqlCommand = new System.Windows.Forms.TextBox();
            this.sqlTreeList = new DevExpress.XtraTreeList.TreeList();
            this.sqlResultShow = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.cmd = new DevExpress.XtraTab.XtraTabPage();
            this.getsendFile = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            this.refresh = new System.Windows.Forms.Button();
            this.sign = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xp_cmdshell)).BeginInit();
            this.xp_cmdshell.SuspendLayout();
            this.sqlserver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sqlServerPanel)).BeginInit();
            this.sqlServerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sqlTreeList)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.skinDropDownButtonItem1,
            this.skinPaletteDropDownButtonItem1,
            this.skinRibbonGalleryBarItem1,
            this.skinPaletteRibbonGalleryBarItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1487, 225);
            // 
            // skinDropDownButtonItem1
            // 
            this.skinDropDownButtonItem1.Id = 1;
            this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            // 
            // skinPaletteDropDownButtonItem1
            // 
            this.skinPaletteDropDownButtonItem1.Id = 2;
            this.skinPaletteDropDownButtonItem1.Name = "skinPaletteDropDownButtonItem1";
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 3;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // skinPaletteRibbonGalleryBarItem1
            // 
            this.skinPaletteRibbonGalleryBarItem1.Caption = "skinPaletteRibbonGalleryBarItem1";
            this.skinPaletteRibbonGalleryBarItem1.Id = 4;
            this.skinPaletteRibbonGalleryBarItem1.Name = "skinPaletteRibbonGalleryBarItem1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.skinGroup1,
            this.skinGroup2,
            this.skinGroup3,
            this.skinGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "主题";
            // 
            // skinGroup1
            // 
            this.skinGroup1.ItemLinks.Add(this.skinDropDownButtonItem1);
            this.skinGroup1.Name = "skinGroup1";
            this.skinGroup1.Text = "                                           ";
            // 
            // skinGroup2
            // 
            this.skinGroup2.ItemLinks.Add(this.skinPaletteDropDownButtonItem1);
            this.skinGroup2.Name = "skinGroup2";
            this.skinGroup2.Text = "                                           ";
            // 
            // skinGroup3
            // 
            this.skinGroup3.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.skinGroup3.Name = "skinGroup3";
            this.skinGroup3.Text = "                                           ";
            // 
            // skinGroup4
            // 
            this.skinGroup4.ItemLinks.Add(this.skinPaletteRibbonGalleryBarItem1);
            this.skinGroup4.Name = "skinGroup4";
            this.skinGroup4.Text = "                                           ";
            // 
            // xp_cmdshell
            // 
            this.xp_cmdshell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xp_cmdshell.Location = new System.Drawing.Point(0, 225);
            this.xp_cmdshell.Name = "xp_cmdshell";
            this.xp_cmdshell.SelectedTabPage = this.sqlserver;
            this.xp_cmdshell.Size = new System.Drawing.Size(1487, 730);
            this.xp_cmdshell.TabIndex = 1;
            this.xp_cmdshell.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.sqlserver,
            this.xtraTabPage2,
            this.cmd,
            this.getsendFile,
            this.xtraTabPage5});
            // 
            // sqlserver
            // 
            this.sqlserver.Controls.Add(this.sqlServerPanel);
            this.sqlserver.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("sqlserver.ImageOptions.SvgImage")));
            this.sqlserver.Name = "sqlserver";
            this.sqlserver.Size = new System.Drawing.Size(1485, 666);
            this.sqlserver.Text = "SQL";
            // 
            // sqlServerPanel
            // 
            this.sqlServerPanel.Controls.Add(this.sign);
            this.sqlServerPanel.Controls.Add(this.refresh);
            this.sqlServerPanel.Controls.Add(this.sqlInfo);
            this.sqlServerPanel.Controls.Add(this.sqlSearch);
            this.sqlServerPanel.Controls.Add(this.sqlCommand);
            this.sqlServerPanel.Controls.Add(this.sqlTreeList);
            this.sqlServerPanel.Controls.Add(this.sqlResultShow);
            this.sqlServerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sqlServerPanel.Location = new System.Drawing.Point(0, 0);
            this.sqlServerPanel.Name = "sqlServerPanel";
            this.sqlServerPanel.Size = new System.Drawing.Size(1485, 666);
            this.sqlServerPanel.TabIndex = 0;
            // 
            // sqlInfo
            // 
            this.sqlInfo.Location = new System.Drawing.Point(5, 3);
            this.sqlInfo.Multiline = true;
            this.sqlInfo.Name = "sqlInfo";
            this.sqlInfo.ReadOnly = true;
            this.sqlInfo.Size = new System.Drawing.Size(804, 124);
            this.sqlInfo.TabIndex = 5;
            // 
            // sqlSearch
            // 
            this.sqlSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sqlSearch.Location = new System.Drawing.Point(1361, 3);
            this.sqlSearch.Name = "sqlSearch";
            this.sqlSearch.Size = new System.Drawing.Size(113, 122);
            this.sqlSearch.TabIndex = 4;
            this.sqlSearch.Text = "查询";
            this.sqlSearch.UseVisualStyleBackColor = true;
            // 
            // sqlCommand
            // 
            this.sqlCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sqlCommand.Location = new System.Drawing.Point(815, 3);
            this.sqlCommand.Multiline = true;
            this.sqlCommand.Name = "sqlCommand";
            this.sqlCommand.Size = new System.Drawing.Size(540, 122);
            this.sqlCommand.TabIndex = 3;
            // 
            // sqlTreeList
            // 
            this.sqlTreeList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sqlTreeList.Location = new System.Drawing.Point(-1, 133);
            this.sqlTreeList.MenuManager = this.ribbonControl1;
            this.sqlTreeList.Name = "sqlTreeList";
            this.sqlTreeList.Size = new System.Drawing.Size(380, 534);
            this.sqlTreeList.TabIndex = 2;
            // 
            // sqlResultShow
            // 
            this.sqlResultShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sqlResultShow.Location = new System.Drawing.Point(373, 133);
            this.sqlResultShow.MenuManager = this.ribbonControl1;
            this.sqlResultShow.Name = "sqlResultShow";
            this.sqlResultShow.ReadOnly = true;
            this.sqlResultShow.Size = new System.Drawing.Size(1113, 534);
            this.sqlResultShow.TabIndex = 1;
            this.sqlResultShow.Text = "spreadsheetControl1";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("xtraTabPage2.ImageOptions.SvgImage")));
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(2016, 994);
            this.xtraTabPage2.Text = "Xp_cmdshell";
            // 
            // cmd
            // 
            this.cmd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmd.ImageOptions.SvgImage")));
            this.cmd.Name = "cmd";
            this.cmd.Size = new System.Drawing.Size(2016, 994);
            this.cmd.Text = "Cmd";
            // 
            // getsendFile
            // 
            this.getsendFile.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("getsendFile.ImageOptions.SvgImage")));
            this.getsendFile.Name = "getsendFile";
            this.getsendFile.Size = new System.Drawing.Size(2016, 994);
            this.getsendFile.Text = "文件传输";
            // 
            // xtraTabPage5
            // 
            this.xtraTabPage5.Name = "xtraTabPage5";
            this.xtraTabPage5.Size = new System.Drawing.Size(2016, 994);
            this.xtraTabPage5.Text = "xtraTabPage5";
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(712, 78);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(84, 42);
            this.refresh.TabIndex = 6;
            this.refresh.Text = "刷新";
            this.refresh.UseVisualStyleBackColor = true;
            // 
            // sign
            // 
            this.sign.Location = new System.Drawing.Point(712, 17);
            this.sign.Name = "sign";
            this.sign.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sign.Size = new System.Drawing.Size(84, 42);
            this.sign.TabIndex = 7;
            this.sign.Text = "登陆";
            this.sign.UseVisualStyleBackColor = true;
            // 
            // MSATServer
            // 
            this.ClientSize = new System.Drawing.Size(1487, 955);
            this.Controls.Add(this.xp_cmdshell);
            this.Controls.Add(this.ribbonControl1);
            this.HtmlText = "MSATServer";
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("MSATServer.IconOptions.SvgImage")));
            this.Name = "MSATServer";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xp_cmdshell)).EndInit();
            this.xp_cmdshell.ResumeLayout(false);
            this.sqlserver.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sqlServerPanel)).EndInit();
            this.sqlServerPanel.ResumeLayout(false);
            this.sqlServerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sqlTreeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
        private DevExpress.XtraBars.SkinPaletteDropDownButtonItem skinPaletteDropDownButtonItem1;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem skinPaletteRibbonGalleryBarItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup skinGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup skinGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup skinGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup skinGroup4;
        private DevExpress.XtraTab.XtraTabControl xp_cmdshell;
        private DevExpress.XtraTab.XtraTabPage sqlserver;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage cmd;
        private DevExpress.XtraTab.XtraTabPage getsendFile;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage5;
        private DevExpress.XtraEditors.PanelControl sqlServerPanel;
        private DevExpress.XtraTreeList.TreeList sqlTreeList;
        private DevExpress.XtraSpreadsheet.SpreadsheetControl sqlResultShow;
        private System.Windows.Forms.Button sqlSearch;
        private System.Windows.Forms.TextBox sqlCommand;
        private System.Windows.Forms.TextBox sqlInfo;
        private System.Windows.Forms.Button sign;
        private System.Windows.Forms.Button refresh;
    }
}

