using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Data.SqlClient;
using ConsoleApp1;
using System.ComponentModel.Design;
using static ConsoleApp1.Client;
//using static ConsoleApp1.Program;

namespace ConsoleApp1
{
    public class Client : client
    {
        public String userName;
        public TcpClient tcpClient;
        public BinaryReader br;
        public BinaryWriter bw;
        public ReceiveMessageListener listener;
        public bool flag = false;

        public Client(String userName, TcpClient client, ReceiveMessageListener receiveMessageListener)
        {
            this.userName = userName;
            this.tcpClient = client;
            this.listener = receiveMessageListener;
            NetworkStream networkStream = tcpClient.GetStream();
            br = new BinaryReader(networkStream);
            bw = new BinaryWriter(networkStream);
            Thread thread = new Thread(receiveMessage);
            thread.Start();
            flag = true;
            //保证在服务器关闭的同时关闭各个客户端线程
            thread.IsBackground = true;
        }

        public override bool Equals(object obj)
        {
            return obj is Client client &&
                   userName == client.userName;
        }
        public bool sendMessage(String ecodeMessage)
        {
            try
            {
                bw.Write(ecodeMessage);
                bw.Flush();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void receiveMessage()
        {
            while (true)
            {
                try
                {
                    String temp = br.ReadString();
                    if (temp == null || temp == "")
                    {

                    }
                    else
                    {
                        //对接收到的消息进行分类并做出相对应的处理
                        listener.getMessage(userName, temp, br, bw);
                    }

                }
                catch
                {
                    return;
                }
            }
        }
        public void stop()
        {
            flag = false;
            if (bw != null)
            {
                bw.Close();
            }
            if (br != null)
            {
                br.Close();
            }
            if (tcpClient != null)
            {
                tcpClient.Close();
            }
        }





        public void update()
        {
            String message = "1" + server.getCurUserName(this);
            if (message.Contains('$'))
            {
                this.sendMessage(message);
            }
            else
            {
                message = message + "$";
                this.sendMessage(message);
            }

        }


    }


    public interface ReceiveMessageListener
    {
        void getMessage(String accountName, String message, BinaryReader br, BinaryWriter bw);
    }

    interface client
    {
        void update();
    }




    public class factory
    {
        public static Client creatproduct(String userName, TcpClient client, ReceiveMessageListener receiveMessageListener)
        {

            return (new Client(userName, client, receiveMessageListener));

        }



    }



    class server
    {



        //存储本地 IP 地址
        private static IPAddress localAddress;
        ////指定监听的端口号
        private const int port = 32770;
        //创建和管理 TCP 连接的监听器对象
        private static TcpListener tcpListener;

        private static List<Client> clientList;  //当前连接的客户端列表
        private static MyListener listener; //存储监听器对象
        private static int count = 0;//用于记录连接的数量
        private static byte[] temp;//用于临时存储图片数据

       static string connectionString = "Server=localhost;Database=oodata;User=root;Password=134679;Pooling=true;Min Pool Size=2;Max Pool Size=50;";
        private static List<string> friendname = new List<string>();
        public server()
        {
            //通配符地址（0.0.0.0），表示本地计算机上的所有可用 IP 地址
            localAddress = IPAddress.Any;
            clientList = new List<Client>();
            listener = new MyListener();
            StartServer();

        }


        private static void Friendfind(string usename)
        {
            try
            {
                // 创建数据库连接对象
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    // 打开数据库连接
                    connection.Open();

                    // 执行查询的 SQL 语句
                    string sqlQuery = "SELECT Friend_id  FROM tb_Friend WHERE HostId = " + usename;





                    using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                    {


                        // 执行查询，并返回结果集
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // 遍历结果集中的行
                            while (reader.Read())
                            {
                                string friend = reader["Friend_id"].ToString();
                                friendname.Add(friend);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("发生异常: " + ex.Message);
            }
        }

        private static void StartServer()
        {
            Console.WriteLine(getTime() + "开始启动服务器中。。。");
            tcpListener = new TcpListener(localAddress, port);
            tcpListener.Start();
            Console.WriteLine(getTime() + "IP:" + localAddress + " 端口号：" + port + " 已启用监听");

            while (true)
            {
                try
                {
                    // 创建和管理 TCP 连接的客户端对象 调用 tcpListener.AcceptTcpClient() 阻塞等待客户端连接请求
                    TcpClient tcpClient = tcpListener.AcceptTcpClient();
                    //在 TCP 连接上创建数据流对象
                    NetworkStream networkStream = tcpClient.GetStream();
                    BinaryReader br = new BinaryReader(networkStream);
                    BinaryWriter bw = new BinaryWriter(networkStream);
                    String accountName = br.ReadString();
                    accountName = decodeUserName(accountName);
                    Console.WriteLine(getTime() + "用户:" + accountName + "已上线");
                    count++;
                    Console.WriteLine("已上线" + count + "人");
                    //将新连接的客户端添加到 clientList 列表中，创建一个新的 Client 对象
                    clientList.Add(factory.creatproduct(accountName, tcpClient, listener));
                    //调用 notifyUpdateUserList() 方法通知更新用户列表
                    notifyUpdateUserList();
                }
                catch
                {
                    Console.WriteLine(getTime() + "已终止监听");
                    return;
                }
            }
        }

        public static String decodeUserName(String words)
        {
            //获取接听到的客户端的用户名
            return words.Split('$')[1];
        }

        public static String getTime()
        {
            return "\r\n" + DateTime.Now.ToString() + "\r\n";
        }

        //定义嵌套类，继承实现client类中定义的getmessage方法
        public class MyListener : ReceiveMessageListener
        {
            public void getMessage(String accountName, String message, BinaryReader br, BinaryWriter bw)
            {
                // TODO
                string[] results = message.Split('$');
                //判断消息类型
                if (int.Parse(results[0]) == 2)//普通消息类型
                {
                    String content = results[1];
                    String goalName = results[2];
                    SendMessageToClient(content, goalName, accountName, false, false);
                }
                else if (int.Parse(results[0]) == 3)//请求下线申请
                {
                    String content = results[1];
                    stopClientByName(content);
                    notifyUpdateUserList();
                }
                else if (int.Parse(results[0]) == 4)//发送图片处理
                {
                    int length = int.Parse(results[1]);
                    String goalName = results[2];
                    temp = br.ReadBytes(length);//接收真正的图片数据流
                    SendMessageToClient("3$" + length + "$" + accountName, goalName, accountName, false, true);//发送前置图片信息
                    SendMessageToClient("", goalName, accountName, true, false);//发送图片数据流
                }
            }
        }

        private static void SendMessageToClient(String content, String goalName, String userName, bool byte_flag, bool sys_flag)
        {
            bool flag = false;//标志位显示是否是向所有人转发消息
            if (goalName.Equals("所有人"))
            {
                flag = true;
                Friendfind(userName);
            }
            foreach (Client i in clientList)
            {
                if (flag)
                {
                    if (friendname.Contains(i.userName))
                    {
                        i.sendMessage("2$广播：" + userName + "说: " + content);
                    }

                }
                else
                {
                    if (i.userName.Equals(goalName))
                    {
                        if (byte_flag)
                        {
                            i.bw.Write(temp, 0, temp.Length);
                            i.bw.Flush();
                        }
                        else
                        {
                            if (sys_flag)
                            {
                                i.sendMessage(content);
                            }
                            else
                            {
                                i.sendMessage("2$" + userName + "说: " + content);
                            }
                        }
                        return;
                    }
                }
            }
        }

        private static void notifyUpdateUserList()
        {
            //一号编码代表更新用户列表

            if (clientList.Count() == 1)
            {
                String Message = "1$";
                clientList[0].sendMessage(Message);
                return;
            }
            foreach (Client i in clientList)
            {
                i.update();

            }
        }

        //获取当前在线用户信息
        public static String getCurUserName(Client client)
        {
            //创建一个空字符串 aa 用于存储所有在线用户的用户名
            String aa = "";
            Friendfind(client.userName);
            //使用 foreach 循环遍历 clientList 中的每个 Client 对象。
            //将每个 Client 对象的用户名 i.userName 与字符 "$" 拼接，并添加到字符串 aa 的末尾。
            foreach (Client i in clientList)
            {

                if (friendname != null && friendname.Contains(i.userName))
                {
                    aa = aa + "$" + i.userName;
                }



            }
            return aa;
        }


        public static void stopClientByName(String name)
        {
            foreach (Client i in clientList)
            {
                if (i.userName.Equals(name))
                {
                    i.stop();
                    count--;
                    Console.WriteLine(getTime() + name + "已下线");
                    clientList.Remove(i);
                }
            }
        }


    }





}


class Program
{

    static void Main(string[] args)
    {
        new server();



    }




}
