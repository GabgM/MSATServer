using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSATServer
{
    public partial class Listening : Form
    {
        Loading loading;
        Boolean flag = false;

        public Listening()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void host_Click(object sender, EventArgs e)
        {

        }

        public void SetLoading(Loading mainloading) {
            loading = mainloading;
        }

        public Boolean Getflag() {
            return flag;
        }

        public String GetHost() {
            return this.serverhost.Text.ToString();
        }

        public int GetPort()
        {
            return Convert.ToInt32(this.serverport.Text.ToString());
        }

        private void yes_Click(object sender, EventArgs e)
        {
            // Loading loading = new Loading();
            //Application.Run(loading);
            loading.Show();
            this.Hide();
            flag = true;
        }

        private void back_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void Listening_Load(object sender, EventArgs e)
        {

        }
    }
}
