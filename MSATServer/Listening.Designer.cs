
namespace MSATServer
{
    partial class Listening
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
            this.host = new System.Windows.Forms.Label();
            this.port = new System.Windows.Forms.Label();
            this.serverport = new System.Windows.Forms.TextBox();
            this.yes = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.serverHost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // host
            // 
            this.host.AutoSize = true;
            this.host.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.host.Location = new System.Drawing.Point(61, 110);
            this.host.Name = "host";
            this.host.Size = new System.Drawing.Size(110, 28);
            this.host.TabIndex = 0;
            this.host.Text = "Host ：";
            this.host.Click += new System.EventHandler(this.host_Click);
            // 
            // port
            // 
            this.port.AutoSize = true;
            this.port.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.port.Location = new System.Drawing.Point(61, 174);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(110, 28);
            this.port.TabIndex = 1;
            this.port.Text = "Port ：";
            this.port.Click += new System.EventHandler(this.label2_Click);
            // 
            // serverport
            // 
            this.serverport.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.serverport.Location = new System.Drawing.Point(177, 167);
            this.serverport.Name = "serverport";
            this.serverport.Size = new System.Drawing.Size(209, 35);
            this.serverport.TabIndex = 3;
            this.serverport.Text = "4444";
            // 
            // yes
            // 
            this.yes.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.yes.Location = new System.Drawing.Point(59, 294);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(121, 51);
            this.yes.TabIndex = 4;
            this.yes.Text = "开始";
            this.yes.UseVisualStyleBackColor = true;
            this.yes.Click += new System.EventHandler(this.yes_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.back.Location = new System.Drawing.Point(285, 294);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(121, 51);
            this.back.TabIndex = 5;
            this.back.Text = "退出";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // serverHost
            // 
            this.serverHost.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.serverHost.Location = new System.Drawing.Point(177, 110);
            this.serverHost.Name = "serverHost";
            this.serverHost.Size = new System.Drawing.Size(209, 35);
            this.serverHost.TabIndex = 6;
            this.serverHost.Text = "0.0.0.0";
            // 
            // Listening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 398);
            this.ControlBox = false;
            this.Controls.Add(this.serverHost);
            this.Controls.Add(this.back);
            this.Controls.Add(this.yes);
            this.Controls.Add(this.serverport);
            this.Controls.Add(this.port);
            this.Controls.Add(this.host);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Listening";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listening";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Listening_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label host;
        private System.Windows.Forms.Label port;
        private System.Windows.Forms.TextBox serverport;
        private System.Windows.Forms.Button yes;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TextBox serverHost;
    }
}