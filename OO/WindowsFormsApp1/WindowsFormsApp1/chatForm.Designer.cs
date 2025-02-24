namespace WindowsFormsApp1
{
    partial class chatForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lable_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.webBrowserChat = new System.Windows.Forms.WebBrowser();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textbox_sendbox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_stop = new System.Windows.Forms.Button();
            this.button_receive = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_send = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button_pic_select = new System.Windows.Forms.Button();
            this.button_pic_send = new System.Windows.Forms.Button();
            this.pic_show = new System.Windows.Forms.PictureBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.addFriendButton = new System.Windows.Forms.Button();
            this.addFriendText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_show)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lable_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(617, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(225, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "配置";
            // 
            // lable_name
            // 
            this.lable_name.AutoSize = true;
            this.lable_name.Location = new System.Drawing.Point(5, 44);
            this.lable_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable_name.Name = "lable_name";
            this.lable_name.Size = new System.Drawing.Size(41, 12);
            this.lable_name.TabIndex = 3;
            this.lable_name.Text = "用户名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务器IP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.webBrowserChat);
            this.groupBox2.Location = new System.Drawing.Point(10, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(338, 246);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "聊天框";
            // 
            // webBrowserChat
            // 
            this.webBrowserChat.Location = new System.Drawing.Point(6, 20);
            this.webBrowserChat.Margin = new System.Windows.Forms.Padding(2);
            this.webBrowserChat.MinimumSize = new System.Drawing.Size(10, 10);
            this.webBrowserChat.Name = "webBrowserChat";
            this.webBrowserChat.Size = new System.Drawing.Size(322, 222);
            this.webBrowserChat.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textbox_sendbox);
            this.groupBox3.Location = new System.Drawing.Point(9, 269);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(334, 110);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发送消息";
            // 
            // textbox_sendbox
            // 
            this.textbox_sendbox.Location = new System.Drawing.Point(8, 20);
            this.textbox_sendbox.Margin = new System.Windows.Forms.Padding(2);
            this.textbox_sendbox.Multiline = true;
            this.textbox_sendbox.Name = "textbox_sendbox";
            this.textbox_sendbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textbox_sendbox.Size = new System.Drawing.Size(268, 86);
            this.textbox_sendbox.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_stop);
            this.groupBox4.Controls.Add(this.button_receive);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Location = new System.Drawing.Point(617, 240);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(218, 133);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "按钮";
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(8, 42);
            this.button_stop.Margin = new System.Windows.Forms.Padding(2);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(197, 26);
            this.button_stop.TabIndex = 4;
            this.button_stop.Text = "终止连接";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // button_receive
            // 
            this.button_receive.Location = new System.Drawing.Point(8, 73);
            this.button_receive.Margin = new System.Windows.Forms.Padding(2);
            this.button_receive.Name = "button_receive";
            this.button_receive.Size = new System.Drawing.Size(197, 26);
            this.button_receive.TabIndex = 3;
            this.button_receive.Text = "接收";
            this.button_receive.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "目标用户";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(97, 20);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(110, 20);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(287, 289);
            this.button_send.Margin = new System.Windows.Forms.Padding(2);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(52, 84);
            this.button_send.TabIndex = 2;
            this.button_send.Text = "发送";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button_pic_select);
            this.groupBox5.Controls.Add(this.button_pic_send);
            this.groupBox5.Controls.Add(this.pic_show);
            this.groupBox5.Location = new System.Drawing.Point(362, 18);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(251, 358);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "图片接收发送区域";
            // 
            // button_pic_select
            // 
            this.button_pic_select.Location = new System.Drawing.Point(5, 324);
            this.button_pic_select.Margin = new System.Windows.Forms.Padding(2);
            this.button_pic_select.Name = "button_pic_select";
            this.button_pic_select.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_pic_select.Size = new System.Drawing.Size(76, 30);
            this.button_pic_select.TabIndex = 2;
            this.button_pic_select.Text = "选择照片";
            this.button_pic_select.UseVisualStyleBackColor = true;
            this.button_pic_select.Click += new System.EventHandler(this.button_pic_select_Click);
            // 
            // button_pic_send
            // 
            this.button_pic_send.Location = new System.Drawing.Point(170, 324);
            this.button_pic_send.Margin = new System.Windows.Forms.Padding(2);
            this.button_pic_send.Name = "button_pic_send";
            this.button_pic_send.Size = new System.Drawing.Size(76, 30);
            this.button_pic_send.TabIndex = 1;
            this.button_pic_send.Text = "发送";
            this.button_pic_send.UseVisualStyleBackColor = true;
            this.button_pic_send.Click += new System.EventHandler(this.button_pic_send_Click);
            // 
            // pic_show
            // 
            this.pic_show.Location = new System.Drawing.Point(5, 20);
            this.pic_show.Margin = new System.Windows.Forms.Padding(2);
            this.pic_show.Name = "pic_show";
            this.pic_show.Size = new System.Drawing.Size(242, 282);
            this.pic_show.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_show.TabIndex = 0;
            this.pic_show.TabStop = false;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // addFriendButton
            // 
            this.addFriendButton.Location = new System.Drawing.Point(760, 212);
            this.addFriendButton.Name = "addFriendButton";
            this.addFriendButton.Size = new System.Drawing.Size(75, 23);
            this.addFriendButton.TabIndex = 5;
            this.addFriendButton.Text = "添加好友";
            this.addFriendButton.UseVisualStyleBackColor = true;
            this.addFriendButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // addFriendText
            // 
            this.addFriendText.Location = new System.Drawing.Point(636, 212);
            this.addFriendText.Name = "addFriendText";
            this.addFriendText.Size = new System.Drawing.Size(100, 21);
            this.addFriendText.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // chatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 386);
            this.Controls.Add(this.addFriendText);
            this.Controls.Add(this.addFriendButton);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "chatForm";
            this.Text = "聊天室客户端";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textbox_sendbox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Button button_receive;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lable_name;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button_pic_send;
        private System.Windows.Forms.PictureBox pic_show;
        private System.Windows.Forms.Button button_pic_select;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.WebBrowser webBrowserChat;
        private System.Windows.Forms.TextBox addFriendText;
        private System.Windows.Forms.Button addFriendButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

