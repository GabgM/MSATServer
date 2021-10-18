using DevExpress.Spreadsheet;
using DevExpress.Utils.Extensions;
using DevExpress.XtraTreeList.Nodes;
//using MSATServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace MSATServer
{
    public partial class MSATServer : DevExpress.XtraEditors.XtraForm
    {
        
        Boolean loadingflag = true;
        String serverHOST = "localhost";
        int serverPORT = 4444;
        Listening listening = new Listening();
        Loading loading = new Loading();
        Socket tcpClient = null;

        public MSATServer()
        {
            
            listening.Show();
            listening.SetLoading(loading);

            

            new Thread(() =>
            {
                //Application.EnableVisualStyles();
                //Application.SetCompatibleTextRenderingDefault(false);
                //Application.Run(new Sign());
                //Application.Run(new Loading());
                //Loading loading = new Loading();
                //Application.Run(loading);
                //loading.Show();
                Boolean a = false;
                while (!a)
                {
                    a = listening.Getflag();
                    //loading.Setinfo("连接成功！");
                }
                Console.WriteLine("Listen...");
                serverHOST = listening.GetHost();
                serverPORT = listening.GetPort();
                Console.WriteLine(serverHOST+":"+serverPORT);
                IPEndPoint serverIP = new IPEndPoint(IPAddress.Parse(serverHOST), serverPORT);
                //Send send = new Send();
                Socket tcpServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                tcpServer.Bind(serverIP);
                tcpServer.Listen(1000);
                //Socket tcpClient = tcpServer.Accept();
                tcpClient = tcpServer.Accept();

                Console.WriteLine("连接成功！\r\n");
                //send.TcpServer(tcpClient);
                TcpServer();
                this.Invoke((MethodInvoker)delegate { 
                    sqlCommand.Text = "客户端连接成功！请连接数据库！";
                    loading.Close();
                });

            }).Start();
            //loading.Show();
            //Sign sign = new Sign();
            //sign.Show();
            InitializeComponent();
        }


        Sign login = Sign.GetSingleMode();

        private void MSATServer_Load(object sender, EventArgs e) {
            ribbonControl1.Minimized = true;
            /**Console.WriteLine("Listen...");
            IPEndPoint serverIP = new IPEndPoint(IPAddress.Parse("192.168.247.1"), 4444);
            Send send = new Send();
            Socket tcpServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            tcpServer.Bind(serverIP);
            tcpServer.Listen(1000);
            Socket tcpClient = tcpServer.Accept();
            
            Console.WriteLine("连接成功！\r\n");
            send.TcpServer(tcpClient);**/
            //send.TcpServer(serverIP);
            //this.FormClosing += new FormClosingEventHandler(MainForm_Closing);
        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void MSATServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            Console.WriteLine("正在关闭程序!");
            result = MessageBox.Show("确定退出吗？", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                System.Environment.Exit(0);
                //Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
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
            login.settcpClient(tcpClient);
            login.Show();
            //Application.Run(new Sign());
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            Console.WriteLine(""+login.GetsqlIP()+login.GetsqlUserName()+login.GetsqlPWD()+login.GetsqlName());
        }

        private void cmdButton_Click(object sender, EventArgs e)
        {
            try
            {
                String mess;
                mess = cmdInPutTextBox.Text.ToString();   //chcp 65001  切换cmd到utf-8编码    936对应GB2312   950对应BIG5   1201对应unicode
                if (mess == null)
                {
                    mess = " ";
                }
                SendMess(tcpClient,mess,"4");
                //mess = StringToUnicode(mess);
                //mess = "4" + Scale.ToCurr((mess.Length + 3) / (1024 * 1024 * 3)).Substring(1, 2) + mess;
                //tcpClient.Send(Encoding.UTF8.GetBytes(mess));
            }
            catch (Exception ex)
            {
                Console.WriteLine("TcpServer出现异常：" + ex.Message + "\r\n请重新打开服务端程序创建新的连接", "断开连接");
                System.Environment.Exit(0);
            }
        }

        #region Tcp连接方式
        /// <summary>
        /// Tcp连接方式
        /// </summary>
        /// <param name="serverIP"></param>
        public void TcpServer()
        {
            //接收数据
            new Thread(() =>
            {
                int sqlResultLength = 0;
                StringReader stream = null;
                XmlTextReader reader = null;
                while (true)
                {
                    String getmess = "";
                    byte[] data = new byte[1024 * 1024 * 3];
                    try
                    {
                        DataSet ds = new DataSet();
                        int length = tcpClient.Receive(data);
                        /**if (length == sqlResultLength && length != 0)
                        {
                            ds = RetrieveDataSet(data);
                            dataGridView.DataSource = ds.Tables[0].DefaultView;
                        }**/
                        byte thisLenFlag = 1;
                        //getmess = Encoding.UTF8.GetString(data,3,length-3);
                        getmess = Encoding.UTF8.GetString(data, 0, length);  //调试
                        //Console.WriteLine(getmess);
                        String allFlag = getmess.Substring(0, 3);
                        String mess = "";
                        char firstFlag = allFlag[0];
                        char secondFlag = allFlag[1];
                        char thirdFlag = allFlag[2];
                        int lenFlag = Scale.ToInt32(allFlag.Substring(1, 2));
                        //Console.WriteLine(DateTime.Now.ToString("MM-dd HH:mm:ss  ") + "(1字符长度为：" + mess.Length + "；标志位：" + firstFlag + "): " + getmess);
                        //Console.WriteLine(getmess);
                        //if (firstFlag == '2' || firstFlag == '3' || firstFlag == '4')
                        if (firstFlag == '1' || firstFlag == '2' || firstFlag == '3')
                        //if (firstFlag == '1' || firstFlag == '3')
                            mess = getmess.Substring(3);
                        else if (firstFlag == '4')
                            mess = getmess.Replace("400$GabgM"," ");
                        else
                            mess = UnicodeToString(getmess.Replace(allFlag, ""));
                        Console.WriteLine(DateTime.Now.ToString("MM-dd HH:mm:ss  ") + "(2字符长度为：" + mess.Length + "；标志位：" + firstFlag + "): " + mess);
                        //Console.WriteLine(getmess+"99999");
                        //getmess = getmess.Substring(0,50);
                        //getmess = RSADecrypt(getmess);
                        while (lenFlag >= thisLenFlag)
                        {
                            length = tcpClient.Receive(data);
                            getmess = Encoding.UTF8.GetString(data, 0, length);
                            mess += UnicodeToString(getmess);
                            thisLenFlag++;
                        }
                        if (firstFlag == '1')
                        {
                            this.Invoke((MethodInvoker)delegate
                            {
                                textBox1.Text = "IP：" + login.GetsqlIP() + "\r\n" + "User：" + login.GetsqlUserName();
                                sqlCommand.Text = "数据库连接成功！正在获取数据库结构信息...";
                                xp_cmdshellOutPutTextBox.Text = "数据库已连接！";
                                
                            });
                            if (mess[0] == '2')   //返回的数据库权限信息
                            {
                                this.Invoke((MethodInvoker)delegate
                                {
                                    textBox2.Text = mess.Substring(1);
                                });
                            }
                            else if (mess[0] == '3')   //数据库返回的系统基本信息
                            {
                                this.Invoke((MethodInvoker)delegate
                                {
                                    textBox3.Text = mess.Substring(1);
                                });
                            }
                            else if (mess[0] == '4')   //获取的数据库表字段信息
                            {
                                mess = mess.Substring(1);
                                stream = new StringReader(mess);
                                reader = new XmlTextReader(stream); ;
                                ds.ReadXml(reader);
                                this.Invoke((MethodInvoker)delegate
                                {
                                    sqlTreeView.Nodes.Clear();
                                    sqlCommand.Text = "数据库结构信息获取成功！";
                                });
                                foreach (DataTable dataTable in ds.Tables)
                                {
                                    TreeNode fatherTN = new TreeNode(dataTable.Rows[0]["database_name"].ToString());
                                    fatherTN = SetTreeNode(fatherTN, dataTable);
                                    //Console.WriteLine("当前数据库为："+dataTable.Rows[0]["database_name"].ToString());
                                    this.Invoke((MethodInvoker)delegate
                                    {
                                        sqlTreeView.Nodes.Add(fatherTN);
                                    });
                                }
                                //TreeNode fatherTN = new TreeNode(ds.Tables[0].Rows[0]["database_name"].ToString());
                                //fatherTN = SetTreeNode(fatherTN,ds);//Console.WriteLine(row[0].ToString());
                                /**this.Invoke((MethodInvoker)delegate
                                {
                                    sqlTreeView.Nodes.Add(fatherTN);
                                });**/
                            }
                        }
                        else if (firstFlag == '2')
                        {
                            String[] resuletable = Regex.Split(mess, "_;,", RegexOptions.IgnoreCase);  //select top 100 * from acam..ALog
                            int columnsnum = 0;
                            int rowsnum = 0;
                            try
                            {
                                columnsnum = Convert.ToInt32(resuletable[0]);
                                rowsnum = Convert.ToInt32(resuletable[1]);
                            }
                            catch(Exception ex)
                            {
                                Console.WriteLine("转换字符串发生错误：resuletable[0]="+ resuletable[0]+ ";resuletable[1]=" + resuletable[1] + ex.Message);
                            }
                            String[,] datas = new string[rowsnum, columnsnum];
                            int flag = 2;
                            Worksheet spreadsheet = spreadsheetControl1.ActiveWorksheet.Workbook.Worksheets[0];
                            spreadsheet.Clear(spreadsheet["A1:AA10000"]);
                            for (int row = 0; row < rowsnum; row++)
                            {
                                for (int columns = 0; columns < columnsnum; columns++)
                                {
                                    datas[row, columns] = resuletable[flag];
                                    flag++;
                                }
                            }
                            this.Invoke((MethodInvoker)delegate
                            {
                                spreadsheet.
                            });
                            /**stream = new StringReader(mess);
                            reader = new XmlTextReader(stream);
                            using (StringReader stringReader = new StringReader(mess))
                            {
                                ds.ReadXmlSchema(stringReader);
                            }
                            ds.Tables[0].BeginLoadData();
                            using (StringReader sr = new StringReader(mess))//(***)代表xml文件路径
                            {
                                ds.ReadXml(sr, XmlReadMode.IgnoreSchema);
                            }
                            ds.Tables[0].EndLoadData();
                            //ds.ReadXml(reader);
                            this.Invoke((MethodInvoker)delegate
                            {
                                dataGridView.DataSource = ds;
                                dataGridView.DataMember = "SQL";
                                //sqlTreeList.DataSource = ds;
                                //sqlTreeList.KeyFieldName = "dbid";
                                //sqlTreeList.ParentFieldName = "name";
                                //DataTable dt = ds.Tables[0];
                                //sqlTreeView.Nodes.Add(tn1);
                            });**/
                            /**foreach (DataRow mDr in ds.Tables[0].Rows)
                            {
                                foreach (DataColumn mDc in ds.Tables[0].Columns)
                                {
                                    Console.WriteLine(mDr[mDc].ToString());
                                }
                            }**/
                            //ds = null;
                            //sqlResultLength = Convert.ToInt32(mess);
                            //ds = RetrieveDataSet(mess);
                            //dataGridView.DataSource = ds.Tables[0].DefaultView;
                        }
                        else if (firstFlag == '3')
                        {
                            String xp_cmdshellresult = "";
                            stream = new StringReader(mess);
                            reader = new XmlTextReader(stream); ;
                            ds.ReadXml(reader);
                            foreach (DataRow mDr in ds.Tables[0].Rows)
                            {
                                foreach (DataColumn mDc in ds.Tables[0].Columns)
                                {
                                    xp_cmdshellresult = xp_cmdshellresult + mDr[mDc].ToString() + "\r\n";
                                }
                            }
                            Console.WriteLine(xp_cmdshellresult);
                            this.Invoke((MethodInvoker)delegate
                            {
                                xp_cmdshellOutPutTextBox.Text = xp_cmdshellOutPutTextBox.Text + "\r\n" + xp_cmdshellInPutTextBox.Text + "\r\n" + xp_cmdshellresult;
                            });
                        }
                        else if (firstFlag == '4')
                        {
                            int len = mess.Length;
                            if (len > 0)
                            {
                                if (mess[0] == '\n' && len >= 2)
                                {
                                    mess = mess.Substring(1, len - 1);
                                    if (mess.EndsWith("\n"))
                                    {
                                        mess = mess.Substring(0, mess.Length - 1);
                                        //mess = mess.Replace("\n\n", "");
                                        //mess = mess.Replace("\r","\r\n");
                                    }
                                }
                            }
                            mess = mess.Replace("\n", "\r\n");
                            this.Invoke((MethodInvoker)delegate
                            {
                                //mess += "\r\n";
                                this.cmdOutPutTextBox.Text += mess;
                                //this.cmdOutPutTextBox.Text += GB2312ToUTF8(mess);
                                //this.cmdOutPutTextBox.ScrollToCaret();
                                //loading.Close();
                            });
                            //cmdOutPutText += mess;
                        }
                        else if (firstFlag == 'a')
                        {
                            this.Invoke((MethodInvoker)delegate
                            {
                                sqlCommand.Text = mess;
                            });
                        }
                        else if (firstFlag == 'b')
                        {
                            this.Invoke((MethodInvoker)delegate
                            {
                                if (xp_cmdshellOutPutTextBox.Text == "数据库未连接，请连接后再试！" || xp_cmdshellOutPutTextBox.Text == "请连接数据库！")
                                    xp_cmdshellOutPutTextBox.Text = mess;
                                else
                                    xp_cmdshellOutPutTextBox.Text += mess;
                            });
                        }
                        //Console.WriteLine(@mess);
                        
                        /**try
                        {
                            //Server:这边是填写数据库地址的地方。可以是IP，或者.\local\localhost\电脑名+实例名
                            //Database:数据库的名称   设置默认为master库
                            //uid:数据库用户名，sa
                            //pwd：数据库密码
                            SqlConnection conn = new SqlConnection("Server=.;Database=master;uid=sa;pwd="+mess);
                            conn.Open();
                            if (conn.State == ConnectionState.Open)
                            {
                                Console.WriteLine("数据库已经打开");

                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("数据库连接失败" + ex.Message);
                        }**/
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("TcpServer出现异常：" + ex.Message + "\r\n请重新打开服务端程序创建新的连接", "断开连接");
                        System.Environment.Exit(0);
                    }
                }
            }).Start();
            //loading.Close();
            //发送数据
            /**new Thread(() =>
            {
                while (true)
                {
                    try
                    {
                        String mess;
                        mess = Console.ReadLine();
                        if (mess == null)
                        {
                            mess = " ";
                        }
                        mess = StringToUnicode(mess);
                        mess = "4" + Scale.ToCurr((mess.Length + 3) / (1024 * 1024 * 3)).Substring(1, 2) + mess;
                        tcpClient.Send(Encoding.UTF8.GetBytes(mess));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("TcpServer出现异常：" + ex.Message + "\r\n请重新打开服务端程序创建新的连接", "断开连接");
                        System.Environment.Exit(0);
                    }
                }
            }).Start();**/
        }
        #endregion
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


        public TreeNode SetTreeNode(TreeNode fatherTN, DataTable dataTable)
        {
            String tableName = dataTable.Rows[0]["table_name"].ToString();
            TreeNode tableTN = new TreeNode(tableName);
            fatherTN.Nodes.Add(tableTN);
            TreeNode columnTN;
            foreach (DataRow row in dataTable.Rows)
            {
                if (tableName == row[1].ToString())   //判断表名是否已经在节点中了
                {
                    columnTN = new TreeNode(row[2].ToString());
                    tableTN.Nodes.Add(columnTN);
                }
                else
                {
                    tableName = row[1].ToString();
                    tableTN = new TreeNode(tableName);
                    fatherTN.Nodes.Add(tableTN);
                    columnTN = new TreeNode(row[2].ToString());
                    tableTN.Nodes.Add(columnTN);
                }

            }
            return fatherTN;
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

        public static string UnicodeToString(string srcText)
        {
            string dst = "";
            string src = srcText;
            int len = srcText.Length / 3;
            for (int i = 0; i <= len - 1; i++)
            {
                string str = "";
                str = src.Substring(0, 3);
                src = src.Substring(3);
                int uninum = Scale.ToInt32(str);
                String str1 = Convert.ToString(uninum % (16 * 16), 16);
                String str0 = Convert.ToString((uninum - (uninum % (16 * 16))) / (16 * 16), 16);
                byte[] bytes = new byte[2];
                bytes[1] = byte.Parse(int.Parse(str0, NumberStyles.HexNumber).ToString());
                bytes[0] = byte.Parse(int.Parse(str1, NumberStyles.HexNumber).ToString());
                dst += Encoding.Unicode.GetString(bytes);
            }
            return dst;
        }

        public string UTF8ToGB2312(string str)

        {
            try
            {
                Encoding utf8 = Encoding.GetEncoding(65001);
                Encoding gb2312 = Encoding.GetEncoding("gb2312");//Encoding.Default ,936
                byte[] temp = utf8.GetBytes(str);
                byte[] temp1 = Encoding.Convert(utf8, gb2312, temp);
                string result = gb2312.GetString(temp1);
                return result;
            }
            catch (Exception ex)//(UnsupportedEncodingException ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
        public string GB2312ToUTF8(string str)
        {
            try
            {
                Encoding uft8 = Encoding.GetEncoding(65001);
                Encoding gb2312 = Encoding.GetEncoding("gb2312");
                byte[] temp = gb2312.GetBytes(str);
                //MessageBox.Show("gb2312的编码的字节个数：" + temp.Length);
                for (int i = 0; i < temp.Length; i++)
                {
                    //MessageBox.Show(Convert.ToUInt16(temp[i]).ToString());
                }
                byte[] temp1 = Encoding.Convert(gb2312, uft8, temp);
                //MessageBox.Show("uft8的编码的字节个数：" + temp1.Length);
                for (int i = 0; i < temp1.Length; i++)
                {
                   // MessageBox.Show(Convert.ToUInt16(temp1[i]).ToString());
                }
                string result = uft8.GetString(temp1);
                return result;
            }
            catch (Exception ex)//(UnsupportedEncodingException ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
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

        private void cmdOutPutTextBox_TextChanged(object sender, EventArgs e)
        {
            cmdOutPutTextBox.SelectionStart = cmdOutPutTextBox.Text.Length; //设置文本起点位置
            cmdOutPutTextBox.ScrollToCaret(); //滚动到当前插入位置
        }

        private void xp_cmdshellButton_Click(object sender, EventArgs e)
        {
            String xp_cmdshellInPut = xp_cmdshellInPutTextBox.Text.ToString();
            SendMess(tcpClient,xp_cmdshellInPut,"3");
        }

        private void sqlSearch_Click(object sender, EventArgs e)
        {
            SendMess(tcpClient,sqlCommand.Text.ToString(),"2");
        }

        private void xp_cmdshellOutPutTextBox_TextChanged(object sender, EventArgs e)
        {
            xp_cmdshellOutPutTextBox.SelectionStart = xp_cmdshellOutPutTextBox.Text.Length; //设置文本起点位置
            xp_cmdshellOutPutTextBox.ScrollToCaret(); //滚动到当前插入位置
        }
    }


    class Send
    {
        #region Tcp连接方式
        /// <summary>
        /// Tcp连接方式
        /// </summary>
        /// <param name="serverIP"></param>
        public void TcpServer(Socket tcpClient)
        {
            /**Socket tcpClient = null;
            try
            {
                tcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                tcpClient.Connect(serverIP);
                Console.WriteLine("连接成功！");
            }
            catch
            {
                Console.WriteLine("连接失败！请检查网络！");
                System.Environment.Exit(0);
            }**/

            /**string str = "9a71";
            //str = src.Substring(0, 6).Substring(2);
            //src = src.Substring(6);
            byte[] bytes = new byte[2];
            //bytes[1] = byte.Parse(int.Parse(str.Substring(0, 2), NumberStyles.HexNumber).ToString());
            str = ((char)int.Parse(str, NumberStyles.HexNumber)).ToString();
            Console.WriteLine(str);**/
            /**Socket tcpServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            tcpServer.Bind(serverIP);
            tcpServer.Listen(1000);
            Socket tcpClient = tcpServer.Accept();
            Console.WriteLine("连接成功！\r\n");**/

            //接收数据
            new Thread(() =>
            {
                while (true)
                {
                    String getmess = "";
                    byte[] data = new byte[1024 * 1024 * 3];
                    try
                    {
                        int length = tcpClient.Receive(data);
                        byte thisLenFlag = 1;
                        //getmess = Encoding.UTF8.GetString(data,3,length-3);
                        getmess = Encoding.UTF8.GetString(data, 0, length);  //调试
                        //Console.WriteLine(getmess);
                        String allFlag = getmess.Substring(0, 3);
                        char firstFlag = allFlag[0];
                        int lenFlag = Scale.ToInt32(allFlag.Substring(1, 2));
                        //Console.WriteLine(getmess);
                        String mess = UnicodeToString(getmess.Replace(allFlag, ""));
                        //Console.WriteLine(getmess+"99999");
                        //getmess = getmess.Substring(0,50);
                        //getmess = RSADecrypt(getmess);
                        while (lenFlag >= thisLenFlag)
                        {
                            length = tcpClient.Receive(data);
                            getmess = Encoding.UTF8.GetString(data, 0, length);
                            mess += UnicodeToString(getmess);
                            thisLenFlag++;
                        }
                        if (firstFlag == '4')
                        {
                            int len = mess.Length;
                            if (len > 0)
                            {
                                if (mess[0] == '\n' && len >= 2)
                                {
                                    mess = mess.Substring(1, len - 1);
                                    if (mess.EndsWith("\n"))
                                    {
                                        mess = mess.Substring(0, mess.Length - 1);
                                        mess = mess.Replace("\n\n", "");
                                    }

                                }
                            }
                            //cmdOutPutText += mess;
                        }
                        
                        Console.WriteLine(DateTime.Now.ToString("MM-dd HH:mm:ss  ") + "(字符长度为：" + mess.Length + "；标志位：" + firstFlag + "): " + mess);
                        /**try
                        {
                            //Server:这边是填写数据库地址的地方。可以是IP，或者.\local\localhost\电脑名+实例名
                            //Database:数据库的名称   设置默认为master库
                            //uid:数据库用户名，sa
                            //pwd：数据库密码
                            SqlConnection conn = new SqlConnection("Server=.;Database=master;uid=sa;pwd="+mess);
                            conn.Open();
                            if (conn.State == ConnectionState.Open)
                            {
                                Console.WriteLine("数据库已经打开");

                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("数据库连接失败" + ex.Message);
                        }**/
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("TcpServer出现异常：" + ex.Message + "\r\n请重新打开服务端程序创建新的连接", "断开连接");
                        System.Environment.Exit(0);
                    }
                }
            }).Start();
            //loading.Close();
            //发送数据
            /**new Thread(() =>
            {
                while (true)
                {
                    try
                    {
                        String mess;
                        mess = Console.ReadLine();
                        if (mess == null)
                        {
                            mess = " ";
                        }
                        mess = StringToUnicode(mess);
                        mess = "4" + Scale.ToCurr((mess.Length + 3) / (1024 * 1024 * 3)).Substring(1, 2) + mess;
                        tcpClient.Send(Encoding.UTF8.GetBytes(mess));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("TcpServer出现异常：" + ex.Message + "\r\n请重新打开服务端程序创建新的连接", "断开连接");
                        System.Environment.Exit(0);
                    }
                }
            }).Start();**/
        }
        #endregion

        public static string UnicodeToString(string srcText)
        {
            string dst = "";
            string src = srcText;
            int len = srcText.Length / 3;
            for (int i = 0; i <= len - 1; i++)
            {
                string str = "";
                str = src.Substring(0, 3);
                src = src.Substring(3);
                int uninum = Scale.ToInt32(str);
                String str1 = Convert.ToString(uninum % (16 * 16), 16);
                String str0 = Convert.ToString((uninum - (uninum % (16 * 16))) / (16 * 16), 16);
                byte[] bytes = new byte[2];
                bytes[1] = byte.Parse(int.Parse(str0, NumberStyles.HexNumber).ToString());
                bytes[0] = byte.Parse(int.Parse(str1, NumberStyles.HexNumber).ToString());
                dst += Encoding.Unicode.GetString(bytes);
            }
            return dst;
        }

        public static string StringToUnicode(string s)
        {
            if (s != null) {
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
