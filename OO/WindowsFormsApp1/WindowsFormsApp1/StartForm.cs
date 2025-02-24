using AntdUI;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class StartForm : Form
    {
        Captcha captcha = new Captcha(4, Captcha.CodeType.Words);
        public StartForm()
        {
            InitializeComponent();
            captchaPictureBox.Image = Image.FromStream(captcha.CreateCheckCodeImage());
            
        }

        #region userTextBox_KeyDown
        private void userTextBox_KeyDown(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || (e.KeyChar == '\r') || (e.KeyChar == '\b'))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        #endregion
        //判断账号密码格式是否正确
        #region ValidateInput
        private bool ValidateInput()
        {
            if (userTextBox.Text.Trim() == "")
            {
                MessageBox.Show("请输入登录账号", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                userTextBox.Focus();
                return false;
            }
            else if (int.Parse(userTextBox.Text.Trim()) > 65535)
            {
                MessageBox.Show("请输入正确的登录账号", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                userTextBox.Focus();
                return false;
            }
            else if (userTextBox.Text.Length > 5 && passwordTextBox.Text.Trim() == "")
            {
                MessageBox.Show("请输入密码", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                passwordTextBox.Focus();
                return false;
            }
            return true;
        } 
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSettings(sender,e);

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();  //调用Form1的Hide()方法隐藏Form1窗口
            FormClient_Register form2 = new FormClient_Register(); //生成一个Form2对象，实例化即可使用
            form2.ShowDialog();  //将Form2窗体显示为模式对话框。
            this.Close(); //关闭From1窗体。
        }
        private bool isAuto = false;
        //登录，用户名为数字（我觉得最好改一下）
        #region LoginButton_Click
        private void LoginButton_Click(object sender, EventArgs e)
        {




            Properties.Settings.Default.userid = userTextBox.Text;
            Properties.Settings.Default.Save();
            if (ValidateInput())
            {
                 string connectionString = "Server=localhost;Database=oodata;User=root;Password=134679;Pooling=true;Min Pool Size=2;Max Pool Size=50;";

                MySqlConnection connection = new MySqlConnection(connectionString);
                string sql = "SELECT * FROM tb_User WHERE ID = " + int.Parse(userTextBox.Text.Trim()) + " AND Pwd = '" + passwordTextBox.Text.Trim() + "'";
                MySqlCommand command = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                //int num = dataOperator.ExecSQL(sql);
                if (reader.HasRows)
                {
                    reader.Close();
                    publicClass.loginID = int.Parse(userTextBox.Text.Trim());
                    if (RememberPwdcheckBox.Checked)
                    {
                        sql = "UPDATE tb_User SET Remember=1 WHERE ID =" + (int.Parse(userTextBox.Text.Trim())).ToString();
                        command.CommandText = sql;
                        command.ExecuteNonQuery();
                        //dataOperator.ExecSQLResult("UPDATE tb_User SET Remember=1 WHERE ID = " + int.Parse(userTextBox.Text.Trim()));
                        if (AutoLogincheckBox.Checked)
                        {
                            sql = "UPDATE tb_User SET AutoLogin=1 WHERE ID=" + (int.Parse(userTextBox.Text.Trim())).ToString();
                            command.CommandText = sql;
                            command.ExecuteNonQuery();
                            //dataOperator.ExecSQLResult("UPDATE tb_User SET AutoLogin=1 WHERE ID=" + int.Parse(userTextBox.Text.Trim()));
                        }
                    }
                    else
                    {
                        sql = "UPDATE tb_User SET Remember=0 WHERE ID=" + (int.Parse(userTextBox.Text.Trim())).ToString();
                        command.CommandText = sql;
                        command.ExecuteNonQuery();
                        sql = "UPDATE tb_User SET  AutoLogin=0 WHERE ID=" + (int.Parse(userTextBox.Text.Trim())).ToString();
                        command.CommandText = sql;
                        command.ExecuteNonQuery();
                        //dataOperator.ExecSQLResult("UPDATE tb_User SET Remember=0 WHERE ID=" + int.Parse(userTextBox.Text.Trim()));
                        //dataOperator.ExecSQLResult("UPDATE tb_User SET AutoLogin=0 WHERE ID=" + int.Parse(userTextBox.Text.Trim()));
                    }
                    if (!captchaTextBox.Text.Equals(captcha.CheckCode)&&!Properties.Settings.Default.AutoLogin)
                    {
                        MessageBox.Show("验证码有误！", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    chatForm  newchat = new chatForm((int.Parse(userTextBox.Text.Trim())).ToString(),"localhost");
                    newchat.Show();
                    this.Visible = false;
                    this.Hide();
                }
                else
                {
                    reader.Close();
                    MessageBox.Show("输入的用户名或密码有误！", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              
                SaveSettings();
                connection.Close();
            }
        } 
        #endregion
        //最小化
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //关闭
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadSettings(object sender, EventArgs e)
        {
            // 加载设置
            userTextBox.Text = Properties.Settings.Default.textbox;
            passwordTextBox.Text = Properties.Settings.Default.password;
            RememberPwdcheckBox.Checked = Properties.Settings.Default.Remember;
            AutoLogincheckBox.Checked= Properties.Settings.Default.AutoLogin;
            
           
            if (isAuto )
            {
                DialogResult result = MessageBox.Show("自动登录吗", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                bool userConfirmed = (result == DialogResult.Yes);
                if (userConfirmed)
                {
                    LoginButton_Click(sender, e);
                }
                   
            }
          
        }

        private void SaveSettings()
        {
          
            // 保存设置
            if (RememberPwdcheckBox.Checked)
            {
                Properties.Settings.Default.textbox = userTextBox.Text;
                Properties.Settings.Default.password = passwordTextBox.Text;
            }
            else
            {
                Properties.Settings.Default.textbox = "";
                Properties.Settings.Default.password = "";
            }
            Properties.Settings.Default.Remember = RememberPwdcheckBox.Checked;
            Properties.Settings.Default.AutoLogin = AutoLogincheckBox.Checked;
            Properties.Settings.Default.Save();
        }
        //记住密码
        private void RememberPwdcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!RememberPwdcheckBox.Checked)
            {
                AutoLogincheckBox.Checked = false;
                isAuto = false;
            }
        }
        private void AutoLogincheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AutoLogincheckBox.Checked)
            {
                isAuto = true;
            }  
        }

        private void captchaPictureBox_Click(object sender, EventArgs e)
        {
            captchaPictureBox.Image = Bitmap.FromStream(captcha.CreateCheckCodeImage());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //MainForm mainForm = new MainForm();
            //mainForm.Show();
            //this.Visible = false;
        }

        private void captchaTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
