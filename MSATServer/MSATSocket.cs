using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace MSATServer
{
    class MSATSocket
    {
        public static void TcpServer(Socket tcpClient,MSATServer msat)
        {
            String mymess = "";
            //接收数据
            new Thread(() =>
            {
                while (true)
                {
                    String getmess = "";
                    String mess = "";
                    String messFlag = "";
                    byte[] data = new byte[1024 * 1024 * 3];
                    try
                    {
                        //DataSet ds = new DataSet();
                        int length = tcpClient.Receive(data);
                        getmess = Encoding.UTF8.GetString(data, 0, length);  //调试
                        int dataLenth = getmess.Length;

                        String allFlag = null;
                        char firstFlag = '0';
                        int lenFlag = 0;
                        try
                        {
                            allFlag = getmess.Substring(0, 12);
                            firstFlag = allFlag[0];
                            lenFlag = Convert.ToInt32(allFlag.Substring(1));
                            while (lenFlag > dataLenth)
                            {
                                length = tcpClient.Receive(data);
                                getmess += Encoding.UTF8.GetString(data, 0, length);
                                dataLenth = getmess.Length;
                            }
                            mess = getmess.Substring(18, lenFlag - 18);
                            messFlag = getmess;
                            while (lenFlag < dataLenth)
                            {
                                Console.WriteLine(DateTime.Now.ToString("MM-dd HH:mm:ss  ") + "(本数据包长度为：" + dataLenth + "；标志位：" + firstFlag + "；数据包总长度：" + lenFlag + "): " + mess);
                                while (firstFlag == '4')
                                {
                                    getmess = getmess.Substring(lenFlag);
                                    dataLenth = getmess.Length;
                                    allFlag = getmess.Substring(0, 12);
                                    firstFlag = allFlag[0];
                                    if (firstFlag != '4')
                                    {
                                        dealMess(tcpClient, mess, '4', msat);
                                        lenFlag = Convert.ToInt32(allFlag.Substring(1));
                                        while (lenFlag > dataLenth)
                                        {
                                            length = tcpClient.Receive(data);
                                            getmess += Encoding.UTF8.GetString(data, 0, length);
                                            dataLenth = getmess.Length;
                                        }
                                        mess = getmess.Substring(18, lenFlag - 18);
                                    }
                                    lenFlag = Convert.ToInt32(allFlag.Substring(1));
                                    while (lenFlag > dataLenth)
                                    {
                                        length = tcpClient.Receive(data);
                                        getmess += Encoding.UTF8.GetString(data, 0, length);
                                        dataLenth = getmess.Length;
                                    }
                                    mess = mess + getmess.Substring(18, lenFlag - 18);
                                }
                                dealMess(tcpClient, mess, firstFlag, msat);
                                getmess = getmess.Substring(lenFlag);
                                dataLenth = getmess.Length;
                                allFlag = getmess.Substring(0, 12);
                                firstFlag = allFlag[0];
                                lenFlag = Convert.ToInt32(allFlag.Substring(1));
                                while (lenFlag > dataLenth)
                                {
                                    length = tcpClient.Receive(data);
                                    getmess += Encoding.UTF8.GetString(data, 0, length);
                                    dataLenth = getmess.Length;
                                }
                                mess = getmess.Substring(18, lenFlag - 18);

                                //分割数据
                            }
                         }
                         catch (Exception ex)
                         {
                             Console.WriteLine(ex.Message + "\r\ndataLenth:" + dataLenth + "; allFlag:" + allFlag + "; \r\n异常的数据:" + mess + "; \r\n获取的所有数据:" + messFlag);
                         }
                        dealMess(tcpClient, mess, firstFlag,msat);
                        Console.WriteLine(DateTime.Now.ToString("MM-dd HH:mm:ss  ") + "(本数据包长度为：" + dataLenth + "；标志位：" + firstFlag + "；数据包总长度：" + lenFlag + "): " + mess);

                        //String allFlag = getmess.Substring(0, 12);
                        //String mess = "";
                        //char firstFlag = allFlag[0];
                        //int lenFlag = Convert.ToInt32(allFlag.Substring(1));
                        /**if (firstFlag == '1' || firstFlag == '2' || firstFlag == '3')
                            if(getmess.Length > 12)
                                mess = getmess.Substring(12);
                        //else if (firstFlag == '4' || firstFlag == '5')
                        else if (firstFlag == '4')
                        {
                            getmess = getmess.Substring(18);
                            string pattern = @"[0123456abe][\d]{11}\$GabgM";
                            string replacement = "";
                            Regex rgx = new Regex(pattern);
                            string result = rgx.Replace(getmess, replacement);
                            mess += result;
                        }
                        else
                            mess = MyScale.UnicodeToString(getmess.Replace(allFlag, ""));
                        if (mess.Length < 40)
                            Console.WriteLine(DateTime.Now.ToString("MM-dd HH:mm:ss  ") + "(本数据包长度为：" + dataLenth + "；标志位：" + firstFlag + "；数据包总长度：" + lenFlag + "): " + mess);
                        else
                            Console.WriteLine(DateTime.Now.ToString("MM-dd HH:mm:ss  ") + "(本数据包长度为：" + dataLenth + "；标志位：" + firstFlag + "；数据包总长度：" + lenFlag + "): " + mess.Substring(0, 35));
                        while (lenFlag > dataLenth)
                        {
                            length = tcpClient.Receive(data);
                            getmess = Encoding.UTF8.GetString(data, 0, length);
                            dataLenth += getmess.Length;
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
                                mess += MyScale.UnicodeToString(getmess);
                            if (mess.Length < 40)
                                Console.WriteLine(DateTime.Now.ToString("MM-dd HH:mm:ss  ") + "(本数据包长度为：" + dataLenth + "；标志位：" + firstFlag + "；数据包总长度：" + lenFlag + "): " + mess);
                            else
                                Console.WriteLine(DateTime.Now.ToString("MM-dd HH:mm:ss  ") + "(本数据包长度为：" + dataLenth + "；标志位：" + firstFlag + "；数据包总长度：" + lenFlag + "): " + mess.Substring(0, 35));
                        }
                        mymess = mess;
                        if (firstFlag == '5')
                        {
                            String[] clientInfo = mess.Split(',');
                            String filename = Path.GetFileName(clientInfo[0]);
                            long fileLength = Convert.ToInt64(clientInfo[1]);
                            byte[] Filebuffer = new byte[1024 * 1024 * 3];
                            if (filename == clientInfo[0])
                            {
                                String savePath = System.Windows.Forms.Application.StartupPath + "\\" + filename;
                                int rec = 0;//定义获取接受数据的长度初始值
                                long recFileLength = 0;
                                using (FileStream fs = new FileStream(savePath, FileMode.Create, FileAccess.Write))
                                {
                                     //ClientFilePathTextEdit.Text = tcpClient.RemoteEndPoint + "; 开始下载！ 文件数据大小：" + fileLength;
                                     while (recFileLength < fileLength)//判断读取文件长度是否小于总文件长度
                                     {
                                         rec = tcpClient.Receive(Filebuffer);//继续接收文件并存入缓存
                                         fs.Write(Filebuffer, 0, rec);//将缓存中的数据写入文件中
                                         fs.Flush();//清空缓存信息
                                         recFileLength += rec;//继续记录已获取的数据大小
                                         Console.WriteLine("{0}: 已接收数据：{1}/{2}", tcpClient.RemoteEndPoint, recFileLength, fileLength);//查看已接受数据进度
                                         msat.RefreshUI('5', "已接收数据:" + recFileLength + "/" + fileLength + "\r\n");
                                     }
                                     fs.Close();
                                     Console.WriteLine("下载完成！路径为：{0}", savePath);//查看已接受数据进度
                                     msat.RefreshUI('5', "下载完成！文件路径为：" + savePath + "\r\n");
                                }
                            }
                        }
                        else
                            msat.RefreshUI(firstFlag,mess);**/
                        mess = null;
                        getmess = null;
                        GC.Collect();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("TcpServer出现异常：" + ex.Message + "\r\n请重新打开服务端程序创建新的连接", "断开连接");
                        Console.WriteLine(ex);
                        DialogResult result;
                        Console.WriteLine("Socket连接断开，正在关闭程序!");
                        result = MessageBox.Show("Socket连接断开！\r\n" + ex.Message + "\r\n" + mymess +"\r\n所有结果已保存，请退出程序后尝试重新连接！\r\n确定退出吗？", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {
                            msat.SaveData();
                        }
                    }
                }
            }).Start();
        }

        public static void dealMess(Socket tcpClient,String mess,char flag, MSATServer msat)
        {
            if (flag == '5')
            {
                String[] clientInfo = mess.Split(',');
                String filename = Path.GetFileName(clientInfo[0]);
                long fileLength = Convert.ToInt64(clientInfo[1]);
                byte[] Filebuffer = new byte[1024 * 1024 * 3];
                if (filename == clientInfo[0])
                {
                    String savePath = System.Windows.Forms.Application.StartupPath + "\\" + filename;
                    int rec = 0;//定义获取接受数据的长度初始值
                    long recFileLength = 0;
                    using (FileStream fs = new FileStream(savePath, FileMode.Create, FileAccess.Write))
                    {
                        //ClientFilePathTextEdit.Text = tcpClient.RemoteEndPoint + "; 开始下载！ 文件数据大小：" + fileLength;
                        while (recFileLength < fileLength)//判断读取文件长度是否小于总文件长度
                        {
                            rec = tcpClient.Receive(Filebuffer);//继续接收文件并存入缓存
                            fs.Write(Filebuffer, 0, rec);//将缓存中的数据写入文件中
                            fs.Flush();//清空缓存信息
                            recFileLength += rec;//继续记录已获取的数据大小
                            Console.WriteLine("{0}: 已接收数据：{1}/{2}", tcpClient.RemoteEndPoint, recFileLength, fileLength);//查看已接受数据进度
                            msat.RefreshUI('5', "已接收数据:" + recFileLength + "/" + fileLength + "\r\n");
                        }
                        fs.Close();
                        Console.WriteLine("下载完成！路径为：{0}", savePath);//查看已接受数据进度
                        msat.RefreshUI('5', "下载完成！文件路径为：" + savePath + "\r\n");
                    }
                }
            }
            else
                msat.RefreshUI(flag, mess);
        }

        public static void SendMess(Socket tcpClient, String mess, String flag)
        {
            try
            {
                mess = MyScale.StringToUnicode(mess);
                byte[] sendmess = Encoding.UTF8.GetBytes(mess);
                mess = flag + getLength(mess.Length) + mess;
                Console.WriteLine("标识位为：" + flag + getLength(mess.Length) + "；实际大小：" + mess.Length);
                sendmess = Encoding.UTF8.GetBytes(mess);
                tcpClient.Send(sendmess);
            }
            catch (Exception ex)
            {
                Console.WriteLine("发送消息：TcpServer出现异常：" + ex.Message + "\r\n请重新打开服务端程序创建新的连接", "断开连接");
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

    }
}
