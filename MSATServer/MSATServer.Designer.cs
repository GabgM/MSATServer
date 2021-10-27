
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MSATServer));
            this.xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            this.getsendFile = new DevExpress.XtraTab.XtraTabPage();
            this.cmd = new DevExpress.XtraTab.XtraTabPage();
            this.cmdpanelControl = new DevExpress.XtraEditors.PanelControl();
            this.UploadButton = new System.Windows.Forms.Button();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.ClientFilePathTextEdit = new System.Windows.Forms.TextBox();
            this.cmdButton = new System.Windows.Forms.Button();
            this.cmdInPutTextBox = new System.Windows.Forms.TextBox();
            this.cmdOutPutTextBox = new System.Windows.Forms.TextBox();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.xp_cmdshellpanelControl = new DevExpress.XtraEditors.PanelControl();
            this.xp_cmdshellButton = new System.Windows.Forms.Button();
            this.xp_cmdshellOutPutTextBox = new System.Windows.Forms.TextBox();
            this.xp_cmdshellInPutTextBox = new System.Windows.Forms.TextBox();
            this.sqlserver = new DevExpress.XtraTab.XtraTabPage();
            this.sqlServerPanel = new DevExpress.XtraEditors.PanelControl();
            this.saveButton = new System.Windows.Forms.Button();
            this.spreadsheetControl1 = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.sqlStructure = new System.Windows.Forms.Label();
            this.sqlTreeView = new System.Windows.Forms.TreeView();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sign = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.sqlInfo = new System.Windows.Forms.TextBox();
            this.sqlSearch = new System.Windows.Forms.Button();
            this.sqlCommand = new System.Windows.Forms.TextBox();
            this.xp_cmdshell = new DevExpress.XtraTab.XtraTabControl();
            this.cmd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdpanelControl)).BeginInit();
            this.cmdpanelControl.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xp_cmdshellpanelControl)).BeginInit();
            this.xp_cmdshellpanelControl.SuspendLayout();
            this.sqlserver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sqlServerPanel)).BeginInit();
            this.sqlServerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xp_cmdshell)).BeginInit();
            this.xp_cmdshell.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraTabPage5
            // 
            this.xtraTabPage5.Margin = new System.Windows.Forms.Padding(32);
            this.xtraTabPage5.Name = "xtraTabPage5";
            this.xtraTabPage5.Size = new System.Drawing.Size(1489, 934);
            this.xtraTabPage5.Text = "xtraTabPage5";
            // 
            // getsendFile
            // 
            this.getsendFile.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("getsendFile.ImageOptions.SvgImage")));
            this.getsendFile.Margin = new System.Windows.Forms.Padding(32);
            this.getsendFile.Name = "getsendFile";
            this.getsendFile.Size = new System.Drawing.Size(1489, 934);
            this.getsendFile.Text = "文件传输";
            // 
            // cmd
            // 
            this.cmd.Controls.Add(this.cmdpanelControl);
            this.cmd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmd.ImageOptions.SvgImage")));
            this.cmd.Margin = new System.Windows.Forms.Padding(32);
            this.cmd.Name = "cmd";
            this.cmd.Size = new System.Drawing.Size(1489, 934);
            this.cmd.Text = "Cmd";
            // 
            // cmdpanelControl
            // 
            this.cmdpanelControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdpanelControl.Controls.Add(this.UploadButton);
            this.cmdpanelControl.Controls.Add(this.DownloadButton);
            this.cmdpanelControl.Controls.Add(this.ClientFilePathTextEdit);
            this.cmdpanelControl.Controls.Add(this.cmdButton);
            this.cmdpanelControl.Controls.Add(this.cmdInPutTextBox);
            this.cmdpanelControl.Controls.Add(this.cmdOutPutTextBox);
            this.cmdpanelControl.Location = new System.Drawing.Point(0, 1);
            this.cmdpanelControl.Margin = new System.Windows.Forms.Padding(32);
            this.cmdpanelControl.Name = "cmdpanelControl";
            this.cmdpanelControl.Size = new System.Drawing.Size(5519, 3035);
            this.cmdpanelControl.TabIndex = 0;
            // 
            // UploadButton
            // 
            this.UploadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UploadButton.Location = new System.Drawing.Point(1323, 880);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(159, 50);
            this.UploadButton.TabIndex = 5;
            this.UploadButton.Text = "上传";
            this.UploadButton.UseVisualStyleBackColor = true;
            this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // DownloadButton
            // 
            this.DownloadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DownloadButton.Location = new System.Drawing.Point(1323, 826);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(159, 56);
            this.DownloadButton.TabIndex = 4;
            this.DownloadButton.Text = "下载";
            this.DownloadButton.UseVisualStyleBackColor = true;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // ClientFilePathTextEdit
            // 
            this.ClientFilePathTextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientFilePathTextEdit.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientFilePathTextEdit.Location = new System.Drawing.Point(808, 828);
            this.ClientFilePathTextEdit.Multiline = true;
            this.ClientFilePathTextEdit.Name = "ClientFilePathTextEdit";
            this.ClientFilePathTextEdit.Size = new System.Drawing.Size(506, 94);
            this.ClientFilePathTextEdit.TabIndex = 3;
            this.ClientFilePathTextEdit.Text = "请输入想要下载的文件路径";
            // 
            // cmdButton
            // 
            this.cmdButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdButton.Location = new System.Drawing.Point(682, 842);
            this.cmdButton.Margin = new System.Windows.Forms.Padding(21);
            this.cmdButton.Name = "cmdButton";
            this.cmdButton.Size = new System.Drawing.Size(102, 70);
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
            this.cmdInPutTextBox.Location = new System.Drawing.Point(10, 828);
            this.cmdInPutTextBox.Margin = new System.Windows.Forms.Padding(21);
            this.cmdInPutTextBox.Multiline = true;
            this.cmdInPutTextBox.Name = "cmdInPutTextBox";
            this.cmdInPutTextBox.Size = new System.Drawing.Size(647, 97);
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
            this.cmdOutPutTextBox.Location = new System.Drawing.Point(0, 0);
            this.cmdOutPutTextBox.Margin = new System.Windows.Forms.Padding(21);
            this.cmdOutPutTextBox.Multiline = true;
            this.cmdOutPutTextBox.Name = "cmdOutPutTextBox";
            this.cmdOutPutTextBox.ReadOnly = true;
            this.cmdOutPutTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cmdOutPutTextBox.Size = new System.Drawing.Size(1489, 818);
            this.cmdOutPutTextBox.TabIndex = 0;
            this.cmdOutPutTextBox.Text = "/**\r\n * \r\n * 下载文件，请在下方输入客户端的文件路径。\r\n * 上传文件，点击上传，选择文件点击确定即可。\r\n * 文件传输时未加密，若需要请加密压缩" +
    "后传输。\r\n * \r\n * */\r\n";
            this.cmdOutPutTextBox.TextChanged += new System.EventHandler(this.cmdOutPutTextBox_TextChanged);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.xp_cmdshellpanelControl);
            this.xtraTabPage2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("xtraTabPage2.ImageOptions.SvgImage")));
            this.xtraTabPage2.Margin = new System.Windows.Forms.Padding(32);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1489, 934);
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
            this.xp_cmdshellpanelControl.Size = new System.Drawing.Size(2290, 1375);
            this.xp_cmdshellpanelControl.TabIndex = 0;
            // 
            // xp_cmdshellButton
            // 
            this.xp_cmdshellButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xp_cmdshellButton.Location = new System.Drawing.Point(1313, 791);
            this.xp_cmdshellButton.Name = "xp_cmdshellButton";
            this.xp_cmdshellButton.Size = new System.Drawing.Size(165, 127);
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
            this.xp_cmdshellOutPutTextBox.Size = new System.Drawing.Size(1481, 780);
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
            this.xp_cmdshellInPutTextBox.Location = new System.Drawing.Point(5, 791);
            this.xp_cmdshellInPutTextBox.Multiline = true;
            this.xp_cmdshellInPutTextBox.Name = "xp_cmdshellInPutTextBox";
            this.xp_cmdshellInPutTextBox.Size = new System.Drawing.Size(1312, 127);
            this.xp_cmdshellInPutTextBox.TabIndex = 1;
            this.xp_cmdshellInPutTextBox.Text = "输入命令点击执行即可";
            // 
            // sqlserver
            // 
            this.sqlserver.Controls.Add(this.sqlServerPanel);
            this.sqlserver.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("sqlserver.ImageOptions.SvgImage")));
            this.sqlserver.Margin = new System.Windows.Forms.Padding(32);
            this.sqlserver.Name = "sqlserver";
            this.sqlserver.Size = new System.Drawing.Size(1334, 901);
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
            this.sqlServerPanel.Controls.Add(this.sign);
            this.sqlServerPanel.Controls.Add(this.refresh);
            this.sqlServerPanel.Controls.Add(this.sqlInfo);
            this.sqlServerPanel.Controls.Add(this.sqlSearch);
            this.sqlServerPanel.Controls.Add(this.sqlCommand);
            this.sqlServerPanel.Controls.Add(this.saveButton);
            this.sqlServerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sqlServerPanel.Location = new System.Drawing.Point(0, 0);
            this.sqlServerPanel.Margin = new System.Windows.Forms.Padding(32);
            this.sqlServerPanel.Name = "sqlServerPanel";
            this.sqlServerPanel.Size = new System.Drawing.Size(2001, 1352);
            this.sqlServerPanel.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(1887, 58);
            this.saveButton.Margin = new System.Windows.Forms.Padding(32);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(109, 49);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "导出";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // spreadsheetControl1
            // 
            this.spreadsheetControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spreadsheetControl1.Location = new System.Drawing.Point(330, 115);
            this.spreadsheetControl1.Name = "spreadsheetControl1";
            this.spreadsheetControl1.Size = new System.Drawing.Size(1666, 1232);
            this.spreadsheetControl1.TabIndex = 14;
            this.spreadsheetControl1.Text = "spreadsheetControl1";
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
            this.sqlTreeView.Size = new System.Drawing.Size(316, 1205);
            this.sqlTreeView.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(11, 70);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox3.Size = new System.Drawing.Size(795, 32);
            this.textBox3.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(330, 5);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(476, 59);
            this.textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(310, 59);
            this.textBox1.TabIndex = 9;
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
            this.sqlSearch.Location = new System.Drawing.Point(1887, 5);
            this.sqlSearch.Margin = new System.Windows.Forms.Padding(32);
            this.sqlSearch.Name = "sqlSearch";
            this.sqlSearch.Size = new System.Drawing.Size(109, 47);
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
            this.sqlCommand.Size = new System.Drawing.Size(967, 103);
            this.sqlCommand.TabIndex = 3;
            // 
            // xp_cmdshell
            // 
            this.xp_cmdshell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xp_cmdshell.Location = new System.Drawing.Point(0, 0);
            this.xp_cmdshell.Margin = new System.Windows.Forms.Padding(32);
            this.xp_cmdshell.Name = "xp_cmdshell";
            this.xp_cmdshell.SelectedTabPage = this.sqlserver;
            this.xp_cmdshell.Size = new System.Drawing.Size(1336, 965);
            this.xp_cmdshell.TabIndex = 1;
            this.xp_cmdshell.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.sqlserver,
            this.xtraTabPage2,
            this.cmd,
            this.getsendFile,
            this.xtraTabPage5});
            // 
            // MSATServer
            // 
            this.ClientSize = new System.Drawing.Size(1336, 965);
            this.Controls.Add(this.xp_cmdshell);
            this.HtmlText = "MSATServer";
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("MSATServer.IconOptions.SvgImage")));
            this.Name = "MSATServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MSATServer_FormClosing);
            this.Load += new System.EventHandler(this.MSATServer_Load);
            this.cmd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmdpanelControl)).EndInit();
            this.cmdpanelControl.ResumeLayout(false);
            this.cmdpanelControl.PerformLayout();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xp_cmdshellpanelControl)).EndInit();
            this.xp_cmdshellpanelControl.ResumeLayout(false);
            this.xp_cmdshellpanelControl.PerformLayout();
            this.sqlserver.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sqlServerPanel)).EndInit();
            this.sqlServerPanel.ResumeLayout(false);
            this.sqlServerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xp_cmdshell)).EndInit();
            this.xp_cmdshell.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabPage xtraTabPage5;
        private DevExpress.XtraTab.XtraTabPage getsendFile;
        private DevExpress.XtraTab.XtraTabPage cmd;
        private DevExpress.XtraEditors.PanelControl cmdpanelControl;
        private Button UploadButton;
        private Button DownloadButton;
        private TextBox ClientFilePathTextEdit;
        private Button cmdButton;
        private TextBox cmdInPutTextBox;
        internal TextBox cmdOutPutTextBox;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.PanelControl xp_cmdshellpanelControl;
        private Button xp_cmdshellButton;
        private TextBox xp_cmdshellOutPutTextBox;
        private TextBox xp_cmdshellInPutTextBox;
        private DevExpress.XtraTab.XtraTabPage sqlserver;
        private DevExpress.XtraEditors.PanelControl sqlServerPanel;
        private Button saveButton;
        private DevExpress.XtraSpreadsheet.SpreadsheetControl spreadsheetControl1;
        private Label sqlStructure;
        private TreeView sqlTreeView;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button sign;
        private Button refresh;
        private TextBox sqlInfo;
        private Button sqlSearch;
        private TextBox sqlCommand;
        private DevExpress.XtraTab.XtraTabControl xp_cmdshell;
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

