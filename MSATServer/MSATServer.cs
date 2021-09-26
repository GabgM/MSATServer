using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MSATServer
{
    public partial class MSATServer : DevExpress.XtraEditors.XtraForm
    {
        

        public MSATServer()
        {
            //Sign sign = new Sign();
            //sign.Show();
            InitializeComponent();
        }

        private void MSATServer_Load(object sender, EventArgs e) {
            ribbonControl1.Minimized = true;
            //this.FormClosing += new FormClosingEventHandler(MainForm_Closing);
        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void MainForm_Closing(object sender, CancelEventArgs e)
        {
            System.Environment.Exit(0);   //点击关闭按钮强制退出
        }

        private void spreadsheetControl1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sign_Click(object sender, EventArgs e)
        {
            Sign login = Sign.GetSingleMode();
            login.Show();
            //Application.Run(new Sign());
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
