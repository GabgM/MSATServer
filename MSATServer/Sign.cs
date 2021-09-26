using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSATServer
{
    public partial class Sign : Form
    {
        private Sign()
        {
            InitializeComponent();
        }

        public static Sign sign = null;

        private void Sign_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public static Sign GetSingleMode() {

            if (sign == null) {
                Sign sign1 = new Sign();
                sign = sign1;
            }
            return sign;
        
        }

        private void sqlPWD_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void backOut_Click(object sender, EventArgs e)
        {
            //System.Environment.Exit(0);   //大退，你懂的
            this.Close();
        }
    }
}
