using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class FormClient_Register : Form
    {
        public FormClient_Register()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void registerBotton_Click(object sender, EventArgs e)
        {

        }

        private void FormClient_Register_Load(object sender, EventArgs e)
        {
            AddZodiacSigns();
            AddbloodSigns();
            bloodBox.SelectedIndex = xingzuoBox.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                if (fakeNameBox.Text.Trim() == "" || fakeNameBox.Text.Length > 20)//验证昵称
                {
                    MessageBox.Show("昵称输入有误！", "提示", MessageBoxButtons.OK,
            MessageBoxIcon.Information);
                ageBox.Focus();
                    return;
                }
                if (ageBox.Text.Trim() == "")                                   //验证年龄
                {
                    MessageBox.Show("请输入年龄！", "提示", MessageBoxButtons.OK,
            MessageBoxIcon.Information);
                ageBox.Focus();
                    return;
                }
                if (!checkBox1.Checked && !checkBox2.Checked)                   //验证性别
                {
                    MessageBox.Show("请选择性别！", "提示", MessageBoxButtons.OK,
            MessageBoxIcon.Information);
                lblsex.Focus();
                    return;
                }
                if (PasswordBox.Text.Trim() == "")                                   //验证密码
                {
                    MessageBox.Show("请输入密码！", "提示", MessageBoxButtons.OK,
            MessageBoxIcon.Information);
                PasswordBox.Focus();
                    return;
                }
                if (PasswordABox.Text.Trim() == "")                              //验证确认密码
                {
                    MessageBox.Show("请输入确认密码！", "提示", MessageBoxButtons.OK,
            MessageBoxIcon.Information);
                PasswordABox.Focus();
                    return;
                }
                if (PasswordBox.Text.Trim() != PasswordABox.Text.Trim())              //验证两次密码是否一致
                {
                    MessageBox.Show("两次输入的密码不一样！", "提示", MessageBoxButtons.OK,
            MessageBoxIcon.Information);
                PasswordABox.Focus();
                    return;
                }
                int myQQNum = 0;                                                //QQ号码
                string message="";                                             //弹出的消息
                string sex1 = checkBox1.Checked ? "男" : "女";    //获得选中的性别

             string connectionString = "Server=localhost;Database=oodata;User=root;Password=134679;Pooling=true;Min Pool Size=2;Max Pool Size=50;";

            MySqlConnection connection = new MySqlConnection(connectionString);
            Random random = new Random();
            string sql = string.Format("insert into tb_User (Pwd, NickName, Sex, Age, Name, Star, BloodType,HeadID) values('{0}', '{1}', '{2}',{3},'{4}','{5}','{6}',{7}); select @@Identity from tb_User", PasswordBox.Text.Trim(), fakeNameBox.Text.Trim(), sex1, int.Parse(ageBox.Text.Trim()), trueNameBox.Text.Trim(), xingzuoBox.Text, bloodBox.Text, random.Next(1, 9));

            MySqlCommand command = new MySqlCommand(sql, connection);
            
            try
            {
                connection.Open();
                int result = command.ExecuteNonQuery();

                if (result == 1)
                {
                    command = new MySqlCommand("SELECT LAST_INSERT_ID()", connection);
                    myQQNum = Convert.ToInt32(command.ExecuteScalar());
                    message = string.Format("注册成功！你的SunTalk号码是" + myQQNum);
                }
                else
                {
                    message = "注册失败，请重试！";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("发生错误：" + ex.Message);
            }
            finally
            {
                connection.Close();
                MessageBox.Show(message, "注册结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
               
                StartForm form3 = new StartForm(); //生成一个Form2对象，实例化即可使用
                form3.ShowDialog();  //将Form2窗体显示为模式对话框。
                this.Close();
            }

           
        }
        private void AddZodiacSigns()
        {
            // 十二个星座
            string[] zodiacSigns = { "白羊座", "金牛座", "双子座", "巨蟹座", "狮子座", "处女座", "天秤座", "天蝎座", "射手座", "摩羯座", "水瓶座", "双鱼座" };

            // 将星座选项添加到 ComboBox 中
            foreach (string sign in zodiacSigns)
            {
                xingzuoBox.Items.Add(sign);
            }
        }
        private void AddbloodSigns()
        {
            // 十二个星座
            string[] zodiacSigns = { "A型","B型","O型" };

            // 将星座选项添加到 ComboBox 中
            foreach (string sign in zodiacSigns)
            {
                bloodBox.Items.Add(sign);
            }
        }
        private void xingzuoBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        private void bloodBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //取消
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm form1 = new StartForm();
            form1.ShowDialog();
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
