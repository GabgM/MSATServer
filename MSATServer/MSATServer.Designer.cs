
using System.Drawing;
using System.Windows.Forms;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            DevExpress.DataAccess.Json.CustomJsonSource customJsonSource1 = new DevExpress.DataAccess.Json.CustomJsonSource();
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode1 = new DevExpress.DataAccess.Json.JsonSchemaNode("root", true);
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode2 = new DevExpress.DataAccess.Json.JsonSchemaNode("NewDataSet", true);
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode3 = new DevExpress.DataAccess.Json.JsonSchemaNode("SQL", true, DevExpress.DataAccess.Json.JsonNodeType.Array);
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode4 = new DevExpress.DataAccess.Json.JsonSchemaNode("da_dep", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode5 = new DevExpress.DataAccess.Json.JsonSchemaNode("da_no", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode6 = new DevExpress.DataAccess.Json.JsonSchemaNode("sel_no", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode7 = new DevExpress.DataAccess.Json.JsonSchemaNode("idno", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode8 = new DevExpress.DataAccess.Json.JsonSchemaNode("name", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode9 = new DevExpress.DataAccess.Json.JsonSchemaNode("dpt_name", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
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
            this.sqlStructure = new System.Windows.Forms.Label();
            this.sqlTreeView = new System.Windows.Forms.TreeView();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView = new DataGridViewEx();
            this.sign = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.sqlInfo = new System.Windows.Forms.TextBox();
            this.sqlSearch = new System.Windows.Forms.Button();
            this.sqlCommand = new System.Windows.Forms.TextBox();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.xp_cmdshellpanelControl = new DevExpress.XtraEditors.PanelControl();
            this.xp_cmdshellButton = new System.Windows.Forms.Button();
            this.xp_cmdshellOutPutTextBox = new System.Windows.Forms.TextBox();
            this.xp_cmdshellInPutTextBox = new System.Windows.Forms.TextBox();
            this.cmd = new DevExpress.XtraTab.XtraTabPage();
            this.cmdpanelControl = new DevExpress.XtraEditors.PanelControl();
            this.cmdButton = new System.Windows.Forms.Button();
            this.cmdInPutTextBox = new System.Windows.Forms.TextBox();
            this.cmdOutPutTextBox = new System.Windows.Forms.TextBox();
            this.getsendFile = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            this.jsonDataSource1 = new DevExpress.DataAccess.Json.JsonDataSource(this.components);
            this.spreadsheetControl2 = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.spreadsheetControl1 = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xp_cmdshell)).BeginInit();
            this.xp_cmdshell.SuspendLayout();
            this.sqlserver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sqlServerPanel)).BeginInit();
            this.sqlServerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xp_cmdshellpanelControl)).BeginInit();
            this.xp_cmdshellpanelControl.SuspendLayout();
            this.cmd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdpanelControl)).BeginInit();
            this.cmdpanelControl.SuspendLayout();
            this.xtraTabPage5.SuspendLayout();
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
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(32);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(2001, 225);
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
            this.xp_cmdshell.Margin = new System.Windows.Forms.Padding(32);
            this.xp_cmdshell.Name = "xp_cmdshell";
            this.xp_cmdshell.SelectedTabPage = this.sqlserver;
            this.xp_cmdshell.Size = new System.Drawing.Size(2001, 1116);
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
            this.sqlserver.Margin = new System.Windows.Forms.Padding(32);
            this.sqlserver.Name = "sqlserver";
            this.sqlserver.Size = new System.Drawing.Size(1999, 1052);
            this.sqlserver.Text = "SQL";
            // 
            // sqlServerPanel
            // 
            this.sqlServerPanel.Controls.Add(this.spreadsheetControl1);
            this.sqlServerPanel.Controls.Add(this.sqlStructure);
            this.sqlServerPanel.Controls.Add(this.sqlTreeView);
            this.sqlServerPanel.Controls.Add(this.textBox3);
            this.sqlServerPanel.Controls.Add(this.textBox2);
            this.sqlServerPanel.Controls.Add(this.textBox1);
            this.sqlServerPanel.Controls.Add(this.dataGridView);
            this.sqlServerPanel.Controls.Add(this.sign);
            this.sqlServerPanel.Controls.Add(this.refresh);
            this.sqlServerPanel.Controls.Add(this.sqlInfo);
            this.sqlServerPanel.Controls.Add(this.sqlSearch);
            this.sqlServerPanel.Controls.Add(this.sqlCommand);
            this.sqlServerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sqlServerPanel.Location = new System.Drawing.Point(0, 0);
            this.sqlServerPanel.Margin = new System.Windows.Forms.Padding(32);
            this.sqlServerPanel.Name = "sqlServerPanel";
            this.sqlServerPanel.Size = new System.Drawing.Size(2999, 1578);
            this.sqlServerPanel.TabIndex = 0;
            // 
            // sqlStructure
            // 
            this.sqlStructure.AutoSize = true;
            this.sqlStructure.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sqlStructure.Location = new System.Drawing.Point(7, 115);
            this.sqlStructure.Name = "sqlStructure";
            this.sqlStructure.Size = new System.Drawing.Size(254, 24);
            this.sqlStructure.TabIndex = 13;
            this.sqlStructure.Text = "数据库结构(库名-表名-字段名)";
            // 
            // sqlTreeView
            // 
            this.sqlTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sqlTreeView.Location = new System.Drawing.Point(5, 142);
            this.sqlTreeView.Name = "sqlTreeView";
            this.sqlTreeView.Size = new System.Drawing.Size(316, 1431);
            this.sqlTreeView.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(11, 70);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox3.Size = new System.Drawing.Size(785, 32);
            this.textBox3.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(330, 10);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(466, 54);
            this.textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 10);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(310, 54);
            this.textBox1.TabIndex = 9;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(330, 109);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.RowTemplate.Height = 30;
            this.dataGridView.Size = new System.Drawing.Size(2664, 1464);
            this.dataGridView.TabIndex = 8;
            // 
            // sign
            // 
            this.sign.Location = new System.Drawing.Point(816, 4);
            this.sign.Margin = new System.Windows.Forms.Padding(32);
            this.sign.Name = "sign";
            this.sign.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sign.Size = new System.Drawing.Size(92, 48);
            this.sign.TabIndex = 7;
            this.sign.Text = "登陆";
            this.sign.UseVisualStyleBackColor = true;
            this.sign.Click += new System.EventHandler(this.sign_Click);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(816, 58);
            this.refresh.Margin = new System.Windows.Forms.Padding(32);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(92, 49);
            this.refresh.TabIndex = 6;
            this.refresh.Text = "刷新";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // sqlInfo
            // 
            this.sqlInfo.Location = new System.Drawing.Point(5, 1);
            this.sqlInfo.Margin = new System.Windows.Forms.Padding(32);
            this.sqlInfo.Multiline = true;
            this.sqlInfo.Name = "sqlInfo";
            this.sqlInfo.ReadOnly = true;
            this.sqlInfo.Size = new System.Drawing.Size(807, 106);
            this.sqlInfo.TabIndex = 5;
            // 
            // sqlSearch
            // 
            this.sqlSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sqlSearch.Location = new System.Drawing.Point(2856, 10);
            this.sqlSearch.Margin = new System.Windows.Forms.Padding(32);
            this.sqlSearch.Name = "sqlSearch";
            this.sqlSearch.Size = new System.Drawing.Size(122, 92);
            this.sqlSearch.TabIndex = 4;
            this.sqlSearch.Text = "查询";
            this.sqlSearch.UseVisualStyleBackColor = true;
            this.sqlSearch.Click += new System.EventHandler(this.sqlSearch_Click);
            // 
            // sqlCommand
            // 
            this.sqlCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sqlCommand.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlCommand.Location = new System.Drawing.Point(915, 4);
            this.sqlCommand.Margin = new System.Windows.Forms.Padding(32);
            this.sqlCommand.Multiline = true;
            this.sqlCommand.Name = "sqlCommand";
            this.sqlCommand.Size = new System.Drawing.Size(1925, 103);
            this.sqlCommand.TabIndex = 3;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.xp_cmdshellpanelControl);
            this.xtraTabPage2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("xtraTabPage2.ImageOptions.SvgImage")));
            this.xtraTabPage2.Margin = new System.Windows.Forms.Padding(32);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1999, 1052);
            this.xtraTabPage2.Text = "Xp_cmdshell";
            // 
            // xp_cmdshellpanelControl
            // 
            this.xp_cmdshellpanelControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xp_cmdshellpanelControl.Controls.Add(this.xp_cmdshellButton);
            this.xp_cmdshellpanelControl.Controls.Add(this.xp_cmdshellOutPutTextBox);
            this.xp_cmdshellpanelControl.Controls.Add(this.xp_cmdshellInPutTextBox);
            this.xp_cmdshellpanelControl.Location = new System.Drawing.Point(0, 5);
            this.xp_cmdshellpanelControl.Name = "xp_cmdshellpanelControl";
            this.xp_cmdshellpanelControl.Size = new System.Drawing.Size(2800, 1493);
            this.xp_cmdshellpanelControl.TabIndex = 0;
            // 
            // xp_cmdshellButton
            // 
            this.xp_cmdshellButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xp_cmdshellButton.Location = new System.Drawing.Point(1684, 909);
            this.xp_cmdshellButton.Name = "xp_cmdshellButton";
            this.xp_cmdshellButton.Size = new System.Drawing.Size(304, 127);
            this.xp_cmdshellButton.TabIndex = 2;
            this.xp_cmdshellButton.Text = "执行";
            this.xp_cmdshellButton.UseVisualStyleBackColor = true;
            this.xp_cmdshellButton.Click += new System.EventHandler(this.xp_cmdshellButton_Click);
            // 
            // xp_cmdshellOutPutTextBox
            // 
            this.xp_cmdshellOutPutTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xp_cmdshellOutPutTextBox.Location = new System.Drawing.Point(5, 5);
            this.xp_cmdshellOutPutTextBox.Multiline = true;
            this.xp_cmdshellOutPutTextBox.Name = "xp_cmdshellOutPutTextBox";
            this.xp_cmdshellOutPutTextBox.ReadOnly = true;
            this.xp_cmdshellOutPutTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.xp_cmdshellOutPutTextBox.Size = new System.Drawing.Size(1991, 898);
            this.xp_cmdshellOutPutTextBox.TabIndex = 0;
            this.xp_cmdshellOutPutTextBox.Text = "请连接数据库！";
            this.xp_cmdshellOutPutTextBox.TextChanged += new System.EventHandler(this.xp_cmdshellOutPutTextBox_TextChanged);
            // 
            // xp_cmdshellInPutTextBox
            // 
            this.xp_cmdshellInPutTextBox.AllowDrop = true;
            this.xp_cmdshellInPutTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xp_cmdshellInPutTextBox.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xp_cmdshellInPutTextBox.Location = new System.Drawing.Point(5, 909);
            this.xp_cmdshellInPutTextBox.Multiline = true;
            this.xp_cmdshellInPutTextBox.Name = "xp_cmdshellInPutTextBox";
            this.xp_cmdshellInPutTextBox.Size = new System.Drawing.Size(1822, 127);
            this.xp_cmdshellInPutTextBox.TabIndex = 1;
            this.xp_cmdshellInPutTextBox.Text = "输入命令点击执行即可";
            // 
            // cmd
            // 
            this.cmd.Controls.Add(this.cmdpanelControl);
            this.cmd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmd.ImageOptions.SvgImage")));
            this.cmd.Margin = new System.Windows.Forms.Padding(32);
            this.cmd.Name = "cmd";
            this.cmd.Size = new System.Drawing.Size(1999, 1052);
            this.cmd.Text = "Cmd";
            // 
            // cmdpanelControl
            // 
            this.cmdpanelControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdpanelControl.Controls.Add(this.cmdButton);
            this.cmdpanelControl.Controls.Add(this.cmdInPutTextBox);
            this.cmdpanelControl.Controls.Add(this.cmdOutPutTextBox);
            this.cmdpanelControl.Location = new System.Drawing.Point(0, 1);
            this.cmdpanelControl.Margin = new System.Windows.Forms.Padding(32);
            this.cmdpanelControl.Name = "cmdpanelControl";
            this.cmdpanelControl.Size = new System.Drawing.Size(6029, 3153);
            this.cmdpanelControl.TabIndex = 0;
            // 
            // cmdButton
            // 
            this.cmdButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdButton.Location = new System.Drawing.Point(3857, 1985);
            this.cmdButton.Margin = new System.Windows.Forms.Padding(21);
            this.cmdButton.Name = "cmdButton";
            this.cmdButton.Size = new System.Drawing.Size(123, 70);
            this.cmdButton.TabIndex = 2;
            this.cmdButton.Text = "执行";
            this.cmdButton.UseVisualStyleBackColor = true;
            this.cmdButton.Click += new System.EventHandler(this.cmdButton_Click);
            // 
            // cmdInPutTextBox
            // 
            this.cmdInPutTextBox.AllowDrop = true;
            this.cmdInPutTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdInPutTextBox.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdInPutTextBox.Location = new System.Drawing.Point(10, 1956);
            this.cmdInPutTextBox.Margin = new System.Windows.Forms.Padding(21);
            this.cmdInPutTextBox.Multiline = true;
            this.cmdInPutTextBox.Name = "cmdInPutTextBox";
            this.cmdInPutTextBox.Size = new System.Drawing.Size(3818, 139);
            this.cmdInPutTextBox.TabIndex = 1;
            this.cmdInPutTextBox.Text = "输入命令";
            // 
            // cmdOutPutTextBox
            // 
            this.cmdOutPutTextBox.AcceptsReturn = true;
            this.cmdOutPutTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOutPutTextBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.cmdOutPutTextBox.Location = new System.Drawing.Point(8, 9);
            this.cmdOutPutTextBox.Margin = new System.Windows.Forms.Padding(21);
            this.cmdOutPutTextBox.Multiline = true;
            this.cmdOutPutTextBox.Name = "cmdOutPutTextBox";
            this.cmdOutPutTextBox.ReadOnly = true;
            this.cmdOutPutTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cmdOutPutTextBox.Size = new System.Drawing.Size(3990, 1934);
            this.cmdOutPutTextBox.TabIndex = 0;
            this.cmdOutPutTextBox.TextChanged += new System.EventHandler(this.cmdOutPutTextBox_TextChanged);
            // 
            // getsendFile
            // 
            this.getsendFile.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("getsendFile.ImageOptions.SvgImage")));
            this.getsendFile.Margin = new System.Windows.Forms.Padding(32);
            this.getsendFile.Name = "getsendFile";
            this.getsendFile.Size = new System.Drawing.Size(1999, 1052);
            this.getsendFile.Text = "文件传输";
            // 
            // xtraTabPage5
            // 
            this.xtraTabPage5.Controls.Add(this.spreadsheetControl2);
            this.xtraTabPage5.Margin = new System.Windows.Forms.Padding(32);
            this.xtraTabPage5.Name = "xtraTabPage5";
            this.xtraTabPage5.Size = new System.Drawing.Size(1999, 1052);
            this.xtraTabPage5.Text = "xtraTabPage5";
            // 
            // jsonDataSource1
            // 
            this.jsonDataSource1.ConnectionName = null;
            customJsonSource1.Json = resources.GetString("customJsonSource1.Json");
            this.jsonDataSource1.JsonSource = customJsonSource1;
            this.jsonDataSource1.Name = "jsonDataSource1";
            jsonSchemaNode3.Nodes.Add(jsonSchemaNode4);
            jsonSchemaNode3.Nodes.Add(jsonSchemaNode5);
            jsonSchemaNode3.Nodes.Add(jsonSchemaNode6);
            jsonSchemaNode3.Nodes.Add(jsonSchemaNode7);
            jsonSchemaNode3.Nodes.Add(jsonSchemaNode8);
            jsonSchemaNode3.Nodes.Add(jsonSchemaNode9);
            jsonSchemaNode2.Nodes.Add(jsonSchemaNode3);
            jsonSchemaNode1.Nodes.Add(jsonSchemaNode2);
            this.jsonDataSource1.Schema = jsonSchemaNode1;
            // 
            // spreadsheetControl2
            // 
            this.spreadsheetControl2.Location = new System.Drawing.Point(235, 178);
            this.spreadsheetControl2.MenuManager = this.ribbonControl1;
            this.spreadsheetControl2.Name = "spreadsheetControl2";
            this.spreadsheetControl2.Size = new System.Drawing.Size(635, 286);
            this.spreadsheetControl2.TabIndex = 0;
            this.spreadsheetControl2.Text = "spreadsheetControl1";
            // 
            // spreadsheetControl1
            // 
            this.spreadsheetControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spreadsheetControl1.Location = new System.Drawing.Point(435, 186);
            this.spreadsheetControl1.MenuManager = this.ribbonControl1;
            this.spreadsheetControl1.Name = "spreadsheetControl1";
            this.spreadsheetControl1.Size = new System.Drawing.Size(2451, 1312);
            this.spreadsheetControl1.TabIndex = 14;
            this.spreadsheetControl1.Text = "spreadsheetControl1";
            // 
            // MSATServer
            // 
            this.ClientSize = new System.Drawing.Size(2001, 1341);
            this.Controls.Add(this.xp_cmdshell);
            this.Controls.Add(this.ribbonControl1);
            this.HtmlText = "MSATServer";
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("MSATServer.IconOptions.SvgImage")));
            this.Name = "MSATServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MSATServer_FormClosing);
            this.Load += new System.EventHandler(this.MSATServer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xp_cmdshell)).EndInit();
            this.xp_cmdshell.ResumeLayout(false);
            this.sqlserver.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sqlServerPanel)).EndInit();
            this.sqlServerPanel.ResumeLayout(false);
            this.sqlServerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xp_cmdshellpanelControl)).EndInit();
            this.xp_cmdshellpanelControl.ResumeLayout(false);
            this.xp_cmdshellpanelControl.PerformLayout();
            this.cmd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmdpanelControl)).EndInit();
            this.cmdpanelControl.ResumeLayout(false);
            this.cmdpanelControl.PerformLayout();
            this.xtraTabPage5.ResumeLayout(false);
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
        private System.Windows.Forms.Button sqlSearch;
        private System.Windows.Forms.TextBox sqlCommand;
        private System.Windows.Forms.TextBox sqlInfo;
        private System.Windows.Forms.Button sign;
        private System.Windows.Forms.Button refresh;
        private DevExpress.XtraEditors.PanelControl cmdpanelControl;
        private System.Windows.Forms.TextBox cmdInPutTextBox;
        private System.Windows.Forms.Button cmdButton;
        internal System.Windows.Forms.TextBox cmdOutPutTextBox;
        private DevExpress.XtraEditors.PanelControl xp_cmdshellpanelControl;
        private System.Windows.Forms.Button xp_cmdshellButton;
        private System.Windows.Forms.TextBox xp_cmdshellInPutTextBox;
        private System.Windows.Forms.TextBox xp_cmdshellOutPutTextBox;
        //private System.Windows.Forms.DataGridView dataGridView;
        private DataGridViewEx dataGridView;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private TreeView sqlTreeView;
        private Label sqlStructure;
        private DevExpress.DataAccess.Json.JsonDataSource jsonDataSource1;
        private DevExpress.XtraSpreadsheet.SpreadsheetControl spreadsheetControl1;
        private DevExpress.XtraSpreadsheet.SpreadsheetControl spreadsheetControl2;
    }

    class DataGridViewEx : DataGridView
    {
        SolidBrush solidBrush;

        //重写OnRowPostPaint事件，展示数据时，在第一列添加编号
        public DataGridViewEx()
        {
            solidBrush = new SolidBrush(this.RowHeadersDefaultCellStyle.ForeColor);
        }
        protected override void OnRowPostPaint(DataGridViewRowPostPaintEventArgs e)
        {
            //e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, solidBrush, e.RowBounds.Location.X + 5, e.RowBounds.Location.Y + 5);
            //base.OnRowPostPaint(e);
            e.Graphics.DrawString((e.RowIndex + 1).ToString(System.Globalization.CultureInfo.CurrentUICulture), e.InheritedRowStyle.Font,solidBrush, e.RowBounds.Location.X + 5, e.RowBounds.Location.Y + 4);
        }
    }
}

