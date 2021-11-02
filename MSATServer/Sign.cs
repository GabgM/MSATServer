using System;
using System.Net.Sockets;
using System.Windows.Forms;

namespace MSATServer
{
    public partial class Sign : Form
    {
        Socket tcpClient = null;
        private Sign()
        {
            InitializeComponent();
        }

        public static Sign sign = null;

        public String GetsqlIP() {
            return sqlIP.Text;
        }

        public String GetsqlUserName() {
            return sqlUserName.Text;
        }

        public String GetsqlPWD() {
            return sqlPWD.Text;
        }

        public String GetsqlName() {
            return sqlName.Text;
        }

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
            //this.Close();
            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            String mess = "Server="+sqlIP.Text.ToString()+";Database="+sqlName.Text.ToString()+";uid="+sqlUserName.Text.ToString()+";pwd="+sqlPWD.Text.ToString();
            MSATSocket.SendMess(tcpClient,mess,"0");
            GC.Collect();
            this.Hide();
        }

        public void settcpClient(Socket socket) {
            tcpClient = socket;
        }

    }
}
