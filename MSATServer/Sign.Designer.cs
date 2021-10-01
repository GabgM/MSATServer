
namespace MSATServer
{
    partial class Sign
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
            this.sqlIP = new System.Windows.Forms.TextBox();
            this.sqlUserName = new System.Windows.Forms.TextBox();
            this.sqlPWD = new System.Windows.Forms.TextBox();
            this.sqlName = new System.Windows.Forms.MaskedTextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.backOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sqlIP
            // 
            this.sqlIP.AllowDrop = true;
            this.sqlIP.Location = new System.Drawing.Point(146, 91);
            this.sqlIP.Name = "sqlIP";
            this.sqlIP.Size = new System.Drawing.Size(232, 28);
            this.sqlIP.TabIndex = 0;
            this.sqlIP.Text = "localhost";
            // 
            // sqlUserName
            // 
            this.sqlUserName.AllowDrop = true;
            this.sqlUserName.Location = new System.Drawing.Point(148, 155);
            this.sqlUserName.Name = "sqlUserName";
            this.sqlUserName.Size = new System.Drawing.Size(229, 28);
            this.sqlUserName.TabIndex = 1;
            this.sqlUserName.Text = "sa";
            // 
            // sqlPWD
            // 
            this.sqlPWD.AllowDrop = true;
            this.sqlPWD.Location = new System.Drawing.Point(145, 214);
            this.sqlPWD.Name = "sqlPWD";
            this.sqlPWD.PasswordChar = '￥';
            this.sqlPWD.Size = new System.Drawing.Size(232, 28);
            this.sqlPWD.TabIndex = 2;
            // 
            // sqlName
            // 
            this.sqlName.AllowDrop = true;
            this.sqlName.AllowPromptAsInput = false;
            this.sqlName.Location = new System.Drawing.Point(145, 273);
            this.sqlName.Name = "sqlName";
            this.sqlName.Size = new System.Drawing.Size(229, 28);
            this.sqlName.TabIndex = 3;
            this.sqlName.Text = "master";
            this.sqlName.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.sqlPWD_MaskInputRejected);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(37, 345);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(140, 69);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "登陆";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // backOut
            // 
            this.backOut.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backOut.Location = new System.Drawing.Point(252, 345);
            this.backOut.Name = "backOut";
            this.backOut.Size = new System.Drawing.Size(135, 69);
            this.backOut.TabIndex = 5;
            this.backOut.Text = "退出";
            this.backOut.UseVisualStyleBackColor = true;
            this.backOut.Click += new System.EventHandler(this.backOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(44, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "IP   ：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(22, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "用户名 ：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(22, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "密  码 ：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(22, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "库  名 ：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(173, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 33);
            this.label5.TabIndex = 10;
            this.label5.Text = "MS登陆";
            // 
            // Sign
            // 
            this.AcceptButton = this.loginButton;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.backOut;
            this.ClientSize = new System.Drawing.Size(451, 484);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sqlPWD);
            this.Controls.Add(this.sqlName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sqlIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backOut);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.sqlUserName);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sign";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL登陆";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Sign_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sqlIP;
        private System.Windows.Forms.TextBox sqlUserName;
        private System.Windows.Forms.TextBox sqlPWD;
        private System.Windows.Forms.MaskedTextBox sqlName;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button backOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}