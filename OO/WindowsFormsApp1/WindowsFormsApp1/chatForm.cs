using Guna.UI2.WinForms;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WindowsFormsApp1;
using System.Reflection;
using static WindowsFormsApp1.chatForm;

namespace WindowsFormsApp1
{
    public partial class chatForm : Form
    {
        //定义了一个常量端口号，用于TCP连接。这意味着客户端将连接到端口号为8848的服务器。
        private const int port = 32770;
        //TcpClient对象，用于管理TCP连接
        private TcpClient tcpClient;
        //NetworkStream对象，用于读写数据流
        private NetworkStream networkStream;
        //BinaryReader对象，用于从网络流中读取数据
        private BinaryReader br;
        //BinaryWriter对象，用于向网络流中写入数据
        private BinaryWriter bw;
        //用于存储日志信息的字符串
        private String log = "";
        //布尔标志，用于指示连接是否打开。
        private Boolean flag_open = false;
        //字符串，用于存储图片目录的路径
        private String Pic_dir;

        //定义一个委托ShowLog，用于显示日志。该委托接受一个字符串参数（日志信息）
        private delegate void ShowLog(String log);
        //一个ShowLog类型的委托实例，用于实际调用显示日志的方法

        private ShowLog showLog;

        //定义一个委托UpdateComboBox，用于更新组合框。该委托接受一个字符串参数（用户名列表）
        private delegate void UpdateComboBox(string usernames);

        //一个UpdateComboBox类型的委托实例，用于实际调用更新组合框的方法
        private UpdateComboBox updateComboBox;

        //定义一个委托UpdateImgBox，用于更新图片框。该委托接受一个Image对象作为参数
        private delegate void UpdateImgBox(Image image);

        //一个UpdateImgBox类型的委托实例，用于实际调用更新图片框的方法
        private UpdateImgBox updateImgBox;
        public string username;
        private ContentAppender contentAppender;
        public chatForm(string username1,string server_ip)
        {
            InitializeComponent();
            contentAppender = new ContentAppender(webBrowserChat);
            //为委托实例分配对应的方法
            showLog = new ShowLog(SetLog);
            updateComboBox = new UpdateComboBox(setComboBox);
            updateImgBox = new UpdateImgBox(setImgBox);

            webBrowserChat.ScriptErrorsSuppressed = true;
            //设置html页面
            string HtmlPage = "WindowsFormsApp1.HTMLPage.html";
            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(HtmlPage))
            using (StreamReader reader = new StreamReader(stream))
            {
                string htmlText = reader.ReadToEnd();
                webBrowserChat.DocumentText = htmlText;
            }
            //开始连接服务器，同步方式阻塞进行

            //创建一个新的 TcpClient 实例，用于与服务器建立 TCP 连接
            tcpClient = new TcpClient();
            //使用获取到的主机名和端口号来连接服务器。这里的连接操作是阻塞的，即程序会一直等待连接成功或失败后才会继续执行后续代码。
            username=username1;
            tcpClient.Connect(server_ip, port);//阻塞啦！！！

            if (tcpClient != null)
            {
                //获取用户在 textBox_name 控件中输入的用户名。
                
                //构造日志消息，记录用户连接服务器的时间和使用的用户名。
                log = DateUtil.getTime() + "以用户名为 " + username1 + "连接服务器";
                //将上面构造的日志消息添加到 textbox_chatbox 中显示。
                SetLog(log);
                //通过 tcpClient 获取网络流，用于在客户端和服务器之间传输数据。
                networkStream = tcpClient.GetStream();
                //创建一个 BinaryReader 对象，用于从网络流中读取数据。
                br = new BinaryReader(networkStream);
                //创建一个 BinaryWriter 对象，用于向网络流中写入数据。
                bw = new BinaryWriter(networkStream);
                SendMessage(username, 1, "");//向服务器发送信息，告诉服务器自己的用户名

                //创建一个新的线程，用于接收从服务器发送过来的消息。
                Thread thread = new Thread(ReceiveMessage);
                thread.Start();
                //将线程设置为后台线程，使其随着主线程的结束而结束
                thread.IsBackground = true;
                label3.Text = server_ip;
                label4.Text = username;
            }
            else
            {

                //打印输出失败信息，因为是主线程运行所以不需要调用委托函数
                log = DateUtil.getTime() + "连接服务器失败，请重试";
                SetLog(log);
            }
        }
        void SetLog(string lg)
        {
            contentAppender.AppendLogToWebBrowser(log);
        }
        void AppendMessage(string message, string sender, bool isSelf)
        {
            contentAppender.AppendMessageToWebBrowser(message, sender, isSelf);
        }

        private void button_connect_Click(object sender, EventArgs e)
        {

        }
        private void button_pic_send_Click(object sender, EventArgs e)
        {
            if (Pic_dir == null)
            {
                return;
            }
            int length = SetImageToByteArray(Pic_dir).Length;
            SendMessage(length + "", 4, comboBox1.Text);
            sendImg();
            pic_show.Image = null;
            Pic_dir = null;
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            //当文本框中不为空时发送当前文本框中的数据
            if (textbox_sendbox.Text != null)
            {
                SendMessage(textbox_sendbox.Text, 2, comboBox1.Text);
                //清空文本框
                textbox_sendbox.Clear();
            }


        }

        private void button_pic_select_Click(object sender, EventArgs e)
        {
            //创建一个 OpenFileDialog 对象，用于打开文件选择对话框。
            OpenFileDialog fileDialog = new OpenFileDialog();
            //设置文件过滤器，使对话框只显示特定类型的文件（即图片文件）
            //过滤器的格式为 "描述|文件扩展名"，多个扩展名用分号分隔
            fileDialog.Filter = "图片文件(*.jpg,*.gif,*.bmp,*.png)|*.jpg;*.gif;*.bmp;*.png";
            //调用 ShowDialog() 方法显示文件选择对话框，并将用户的操作结果存储在 result 变量中。
            // DialogResult 是一个枚举，常见值包括 OK, Cancel, Yes, No 等。
            DialogResult result = fileDialog.ShowDialog();
            //检查用户是否点击了“OK”按钮。如果用户选择了文件并点击“OK”，则执行下面的代码块。
            if (result == DialogResult.OK)
            {
                //将用户选择的文件路径赋值给 Pic_dir 变量。FileName 属性包含所选文件的完整路径。
                Pic_dir = fileDialog.FileName;
                //使用 Image.FromFile(Pic_dir) 方法从指定路径加载图片文件。
                // 将加载的图片赋值给 pic_show 控件的 Image 属性，从而在界面上显示图片。
                pic_show.Image = Image.FromFile(Pic_dir);

            }
        }



        private void button_stop_Click(object sender, EventArgs e)
        {
            SendMessage(username, 3, "");


            log = DateUtil.getTime() + "已发起下线请求";


            flag_open = false;

            //关闭网络相关的资源
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
        //通过正则表达式分割消息得到
        private (string userName, string content)? ExtractUserNameAndContent(string input)
        {
            string userName = "";
            string content = "";
            string pattern = @"^2\$(广播：)?(.+?)说: (.*)$";
            Match match = Regex.Match(input, pattern);
            if (match.Success)
            {
                userName = match.Groups[2].Value;
                content = match.Groups[3].Value;
                return (userName, content);
            }
            else
            {
                return null;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textbox_chatbox_TextChanged(object sender, EventArgs e)
        {

        }
        public interface IMessageStrategy
        {

            string EncodeMessage(string message, string goalName);
            void DecodeMessage(string message);
        }
        public class ReportUserNameStrategy : IMessageStrategy
        {
            private chatForm _form1;  // 存储 Form1 实例

            // 通过构造函数传递 Form1 实例
            public ReportUserNameStrategy(chatForm form1)
            {
                _form1 = form1;
            }
            public string EncodeMessage(string message, string goalName)
            {
                return "1$" + message;
            }

            public void DecodeMessage(string message)
            {
                // 这里没有解码操作，因为这只是报告用户名
                _form1.comboBox1.Invoke(_form1.updateComboBox, message);
            }
        }

        public class SendMessageStrategy : IMessageStrategy
        {
            private chatForm _form1;  // 存储 Form1 实例

            // 通过构造函数传递 Form1 实例
            public SendMessageStrategy(chatForm form1)
            {
                _form1 = form1;
            }
            public string EncodeMessage(string message, string goalName)
            {
                return "2$" + message + "$" + goalName;
            }

            public void DecodeMessage(string message)
            {
                var data = _form1.ExtractUserNameAndContent(message);
                if (data.HasValue)
                {
                    string rev = data.Value.content;
                    string sender = data.Value.userName;
                    _form1.AppendMessage(rev, sender, false);
                }
            }
        }

        public class DisconnectStrategy : IMessageStrategy
        {
            private chatForm _form1;  // 存储 Form1 实例

            // 通过构造函数传递 Form1 实例
            public DisconnectStrategy(chatForm form1)
            {
                _form1 = form1;
            }
            public string EncodeMessage(string message, string goalName)
            {
                return "3$" + message;
            }

            public void DecodeMessage(string message)
            {
                // 没有具体的解码操作
            }
        }

        public class SendImageStrategy : IMessageStrategy
        {
            private chatForm _form1;  // 存储 Form1 实例

            // 通过构造函数传递 Form1 实例
            public SendImageStrategy(chatForm form1)
            {
                _form1 = form1;
            }
            public string EncodeMessage(string message, string goalName)
            {
                return "4$" + message + "$" + goalName;
            }

            public void DecodeMessage(string message)
            {
                String[] results = message.Split('$');
                // 图片的接收需要特殊处理
                _form1.log = DateUtil.getTime() + results[2] + "给你发送了一张图片";
                _form1.pic_show.Invoke(_form1.updateImgBox, _form1.SetByteToImage(_form1.br.ReadBytes(int.Parse(results[1]))));
            }
        }
        public class MessageContext
        {



            private IMessageStrategy _messageStrategy;

            public void SetStrategy(IMessageStrategy strategy)
            {
                _messageStrategy = strategy;
            }

            public string EncodeMessage(string message, string goalName)
            {
                return _messageStrategy.EncodeMessage(message, goalName);
            }

            public void DecodeMessage(string message)
            {
                _messageStrategy.DecodeMessage(message);
            }
        }
        public void SendMessage(string message, int code, string goalName)
        {
            // 设置合适的策略
            IMessageStrategy strategy;

            switch (code)
            {
                case 1:
                    strategy = new ReportUserNameStrategy(this);
                    break;
                case 2:
                    strategy = new SendMessageStrategy(this);
                    break;
                case 3:
                    strategy = new DisconnectStrategy(this);
                    break;
                case 4:
                    strategy = new SendImageStrategy(this);
                    break;
                default:
                    throw new ArgumentException("Invalid code");
            }

            // 使用策略进行消息编码
            var context = new MessageContext();
            context.SetStrategy(strategy);
            string sendmessage = context.EncodeMessage(message, goalName);

            try
            {
                bw.Write(sendmessage);
                bw.Flush();
                log = DateUtil.getTime() + "发送信息：" + message;

                if (code == 1)
                {
                    flag_open = true;
                }

                if (code == 2)
                {
                    AppendMessage(message, "我", true); // 自己发送的消息
                }
            }
            catch
            {
                log = DateUtil.getTime() + "发送信息异常，服务器已断开连接";
                return;
            }
        }

        public void ReceiveMessage()
        {
            while (flag_open)
            {
                try
                {
                    string rcvMsgStr = br.ReadString();
                    string[] results = rcvMsgStr.Split('$');
                    int code = int.Parse(results[0]);

                    // 根据 code 设置策略
                    IMessageStrategy strategy;

                    switch (code)
                    {
                        case 1:
                            strategy = new ReportUserNameStrategy(this);
                            break;
                        case 2:
                            strategy = new SendMessageStrategy(this);
                            break;
                        case 3:
                            strategy = new SendImageStrategy(this);
                            break;
                        //case 4:
                        //    strategy = new SendImageStrategy(this);
                        //break;
                        default:
                            throw new ArgumentException("Invalid code");
                    }

                    var context = new MessageContext();
                    context.SetStrategy(strategy);
                    context.DecodeMessage(rcvMsgStr);
                }
                catch
                {
                    log = DateUtil.getTime() + "接收发生异常，服务器已断开连接";
                    return;
                }
            }
        }
        public class ContentAppender
        {
            private WebBrowser webBrowser;
            public ContentAppender(WebBrowser webBrowser)
            {
                this.webBrowser = webBrowser;
            }
            public void AppendLogToWebBrowser(string log)
            {
                string htmlMessage = $@"<script type=""text/javascript"">window.location.hash = ""#ok"";</script>
                <div class = 'log'>
                    <p>{log}</p>
                </div>
                <a id='ok'></a>
                ";
                webBrowser.DocumentText = webBrowser.DocumentText.Replace("<a id = 'ok' ></ a > ", "") + htmlMessage;
            }
            public void AppendMessageToWebBrowser(string message, string sender, bool isSelf)
            {
                if (webBrowser.InvokeRequired)
                {
                    webBrowser.Invoke(new Action<string, string, bool>(AppendMessageToWebBrowser), message, sender, isSelf);
                }
                else
                {
                    string classType = isSelf ? "self" : "buddy";
                    string htmlMessage = $@"<script type=""text/javascript"">window.location.hash = ""#ok"";</script>
                    <div class='chat_content_group {classType}'>
                    <p class='chat_nick'>{sender}</p>
                    <p class='chat_content {classType}'>{message}</p>
                    </div>
                    <a id='ok'></a>
                    ";
                    webBrowser.DocumentText = webBrowser.DocumentText.Replace("<a id = 'ok' ></ a > ", "") + htmlMessage;
                }
            }
        }


        public void setComboBox(string names)
        {
            String results = names.Substring(names.IndexOf('$') + 1);

            String[] namelist = results.Split('$');

            comboBox1.Items.Clear();

            for (int i = 0; i < namelist.Length; i++)
            {
                comboBox1.Items.Add(namelist[i]);
            }
            comboBox1.Items.Add("所有人");
        }

        private void sendImg()
        {
            byte[] datas = SetImageToByteArray(Pic_dir);
            bw.Write(datas, 0, datas.Length);
            bw.Flush();
        }


        //将图像文件转换为字节数组
        private byte[] SetImageToByteArray(string fileName)
        {
            //用于读写文件的流   参数 fileName：指定要打开的文件路径。
            //参数 FileMode.Open：表示以打开现有文件的模式打开文件，如果文件不存在则会抛出异常。
            //参数 FileAccess.Read：表示以只读方式打开文件。
            //参数 FileShare.ReadWrite：允许其他进程同时读取和写入该文件
            FileStream fs = new FileStream(fileName, FileMode.Open, System.IO.FileAccess.Read, FileShare.ReadWrite);

            //创建一个大小与文件长度相同的字节数组，用于存储读取的文件数据
            byte[] byteData = new byte[fs.Length];

            //fs.Read 方法：从文件流中读取数据并填充到字节数组 byteData 中。
            //参数 byteData：目标字节数组，用于接收读取的数据。
            //参数 0：起始位置，从字节数组的第一个字节开始存储读取的数据。
            //参数 byteData.Length：要读取的字节数，即整个文件的长度。
            fs.Read(byteData, 0, byteData.Length);
            fs.Close();
            return byteData;
        }
        public Image SetByteToImage(byte[] mybyte)
        {
            //创建内存流，内存流内容为字节数组的数据
            MemoryStream ms = new MemoryStream(mybyte);
            //从数据流中创建图像对象
            Image outputImg = Image.FromStream(ms);
            return outputImg;
        }
        private void setImgBox(Image i)
        {
            pic_show.Image = i;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string connectionString = "Server=localhost;Database=oodata;User=root;Password=134679;Pooling=true;Min Pool Size=2;Max Pool Size=50;";

            MySqlConnection connection = new MySqlConnection(connectionString);
            string sql = string.Format("insert into tb_Friend (Friend_id,HostID) values('{0}','{1}')", addFriendText.Text, username);
            MySqlCommand command = new MySqlCommand(sql, connection);
            connection.Open();
            string message = "";

            try
            {

                int result = command.ExecuteNonQuery();
                connection = new MySqlConnection(connectionString);
                sql = string.Format("insert into tb_Friend (Friend_id,HostID) values('{0}','{1}')", username, addFriendText.Text);
                command = new MySqlCommand(sql, connection);
                connection.Open();
                result = command.ExecuteNonQuery();

                if (result == 1)
                {

                    message = string.Format("添加好友成功！");
                }
                else
                {
                    message = "添加好友失败，请重试！";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("发生错误：" + ex.Message);
            }
            finally
            {
                MessageBox.Show(message, "注册结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();

            }


        }

        private void textbox_ip_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
