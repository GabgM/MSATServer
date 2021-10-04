using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
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
            SendMess(tcpClient,mess,"0");
            this.Hide();
        }

        public void settcpClient(Socket socket) {
            tcpClient = socket;
        }

        public void SendMess(Socket tcpClient, String mess, String flag)
        {
            try
            {
                Console.WriteLine(mess);
                mess = StringToUnicode(mess);
                mess = flag + Scale.ToCurr((mess.Length + 3) / (1024 * 1024 * 3)).Substring(1, 2) + mess;
                //Console.WriteLine(mess);
                byte[] sendmess = Encoding.UTF8.GetBytes(mess);
                //Console.WriteLine(Encoding.UTF8.GetString(sendmess));
                tcpClient.Send(sendmess);
            }
            catch (Exception ex)
            {
                Console.WriteLine("TcpServer出现异常：" + ex.Message + "\r\n请重新打开服务端程序创建新的连接", "断开连接");
                System.Environment.Exit(0);
            }
        }

        public static string StringToUnicode(string s)
        {
            if (s != null)
            {
                char[] charbuffers = s.ToCharArray();
                byte[] buffer;
                String uniString = "";
                //StringBuilder sb = new StringBuilder();
                for (int i = 0; i < charbuffers.Length; i++)
                {
                    buffer = System.Text.Encoding.Unicode.GetBytes(charbuffers[i].ToString());
                    int uninum = buffer[1] * 16 * 16 + buffer[0];
                    String uni = Scale.ToCurr(uninum);
                    uniString += uni;
                    //String uni = String.Format("{0:X2}{1:X2}", buffer[1], buffer[0]);
                    //Console.WriteLine(uninum);
                    //sb.Append(String.Format("//u{0:X2}{1:X2}", buffer[1], buffer[0]));
                }
                return uniString;
                //return sb.ToString();
            }
            return s;
        }

        public static class Scale
        {
            /// <summary>
            /// 进制符号字符串
            /// </summary>
            private static string scString = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            /// <summary>
            /// 字符集，可以根据编号索引拿到字符
            /// </summary>
            private static char[] scArray = scString.ToCharArray();
            /// <summary>
            /// 字符字典，可以根据字符拿到编号索引
            /// </summary>
            private static Dictionary<char, int> scDic = ToCharDic();
            /// <summary>
            /// 根据字符串反馈进制数
            /// </summary>
            public static int Len { get { return scString.Length; } }

            /// <summary>
            /// 将字符串处理成字符字典
            /// </summary>
            private static Dictionary<char, int> ToCharDic()
            {
                Dictionary<char, int> dic = new Dictionary<char, int>();
                for (int i = 0; i < scArray.Length; i++)
                {
                    dic.Add(scArray[i], i);
                }
                return dic;
            }
            /// <summary>
            /// 根据传入的字符符号定义进制，字符符号不能重复，模拟十进制字符串为：0123456789
            /// </summary>
            public static void SetScale(string scaleString)
            {
                scString = scaleString;
                scArray = scString.ToCharArray();
                scDic = ToCharDic();
            }
            /// <summary>
            /// 将Int64转成当前进制字符串
            /// </summary>
            public static string ToCurr(long num)
            {
                string curr = "";
                while (num >= Len)
                {
                    curr = scArray[num % Len] + curr;
                    num = num / Len;
                }
                curr = scArray[num] + curr;
                if (curr.Length == 0)
                {
                    curr = "000";
                }
                else if (curr.Length == 1)
                {
                    curr = "00" + curr;
                }
                else if (curr.Length == 2)
                {
                    curr = "0" + curr;
                }
                return curr;
            }
            /// <summary>
            /// 将当前进制字符串转成Int64
            /// </summary>
            public static int ToInt32(string curr)
            {
                double num = 0;
                for (int i = 0; i < curr.Length; i++)
                {
                    num += scDic[curr[i]] * Math.Pow(Len, curr.Length - 1 - i);
                }
                return Convert.ToInt32(num);
            }
        }
    }
}
