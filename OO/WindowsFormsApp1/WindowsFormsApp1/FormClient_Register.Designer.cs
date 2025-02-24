namespace WindowsFormsApp1
{
    partial class FormClient_Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.nickName = new System.Windows.Forms.Label();
            this.basicInfo = new System.Windows.Forms.GroupBox();
            this.PasswordABox = new Guna.UI2.WinForms.Guna2TextBox();
            this.PasswordBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ageBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.fakeNameBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordAgain = new System.Windows.Forms.Label();
            this.lblsex = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.password = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.trueName = new System.Windows.Forms.Label();
            this.xingzuo = new System.Windows.Forms.Label();
            this.bloodType = new System.Windows.Forms.Label();
            this.trueNameBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.detailInfo = new System.Windows.Forms.GroupBox();
            this.bloodBox = new System.Windows.Forms.ComboBox();
            this.xingzuoBox = new System.Windows.Forms.ComboBox();
            this.button2 = new Guna.UI2.WinForms.Guna2Button();
            this.button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.closeButton = new Guna.UI2.WinForms.Guna2Button();
            this.minimizeButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.basicInfo.SuspendLayout();
            this.detailInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nickName
            // 
            this.nickName.AutoSize = true;
            this.nickName.Location = new System.Drawing.Point(52, 75);
            this.nickName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nickName.Name = "nickName";
            this.nickName.Size = new System.Drawing.Size(71, 36);
            this.nickName.TabIndex = 1;
            this.nickName.Text = "昵称";
            this.nickName.Click += new System.EventHandler(this.label1_Click);
            // 
            // basicInfo
            // 
            this.basicInfo.Controls.Add(this.PasswordABox);
            this.basicInfo.Controls.Add(this.PasswordBox);
            this.basicInfo.Controls.Add(this.ageBox);
            this.basicInfo.Controls.Add(this.fakeNameBox);
            this.basicInfo.Controls.Add(this.passwordAgain);
            this.basicInfo.Controls.Add(this.lblsex);
            this.basicInfo.Controls.Add(this.checkBox2);
            this.basicInfo.Controls.Add(this.checkBox1);
            this.basicInfo.Controls.Add(this.password);
            this.basicInfo.Controls.Add(this.age);
            this.basicInfo.Controls.Add(this.nickName);
            this.basicInfo.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.basicInfo.Location = new System.Drawing.Point(396, 148);
            this.basicInfo.Margin = new System.Windows.Forms.Padding(4);
            this.basicInfo.Name = "basicInfo";
            this.basicInfo.Padding = new System.Windows.Forms.Padding(4);
            this.basicInfo.Size = new System.Drawing.Size(668, 460);
            this.basicInfo.TabIndex = 2;
            this.basicInfo.TabStop = false;
            this.basicInfo.Text = "基本资料（必填）";
            // 
            // PasswordABox
            // 
            this.PasswordABox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordABox.DefaultText = "";
            this.PasswordABox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordABox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordABox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordABox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordABox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordABox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PasswordABox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordABox.Location = new System.Drawing.Point(184, 314);
            this.PasswordABox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PasswordABox.Name = "PasswordABox";
            this.PasswordABox.PasswordChar = '*';
            this.PasswordABox.PlaceholderText = "";
            this.PasswordABox.SelectedText = "";
            this.PasswordABox.Size = new System.Drawing.Size(416, 46);
            this.PasswordABox.TabIndex = 14;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordBox.DefaultText = "";
            this.PasswordBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PasswordBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordBox.Location = new System.Drawing.Point(184, 236);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.PlaceholderText = "";
            this.PasswordBox.SelectedText = "";
            this.PasswordBox.Size = new System.Drawing.Size(416, 46);
            this.PasswordBox.TabIndex = 13;
            // 
            // ageBox
            // 
            this.ageBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ageBox.DefaultText = "";
            this.ageBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ageBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ageBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ageBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ageBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ageBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ageBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ageBox.Location = new System.Drawing.Point(184, 154);
            this.ageBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ageBox.Name = "ageBox";
            this.ageBox.PasswordChar = '\0';
            this.ageBox.PlaceholderText = "";
            this.ageBox.SelectedText = "";
            this.ageBox.Size = new System.Drawing.Size(416, 46);
            this.ageBox.TabIndex = 12;
            // 
            // fakeNameBox
            // 
            this.fakeNameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fakeNameBox.DefaultText = "";
            this.fakeNameBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fakeNameBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fakeNameBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fakeNameBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fakeNameBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fakeNameBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fakeNameBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fakeNameBox.Location = new System.Drawing.Point(184, 70);
            this.fakeNameBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.fakeNameBox.Name = "fakeNameBox";
            this.fakeNameBox.PasswordChar = '\0';
            this.fakeNameBox.PlaceholderText = "";
            this.fakeNameBox.SelectedText = "";
            this.fakeNameBox.Size = new System.Drawing.Size(416, 46);
            this.fakeNameBox.TabIndex = 11;
            // 
            // passwordAgain
            // 
            this.passwordAgain.AutoSize = true;
            this.passwordAgain.Location = new System.Drawing.Point(47, 319);
            this.passwordAgain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordAgain.Name = "passwordAgain";
            this.passwordAgain.Size = new System.Drawing.Size(127, 36);
            this.passwordAgain.TabIndex = 9;
            this.passwordAgain.Text = "重复密码";
            // 
            // lblsex
            // 
            this.lblsex.AutoSize = true;
            this.lblsex.Location = new System.Drawing.Point(50, 394);
            this.lblsex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsex.Name = "lblsex";
            this.lblsex.Size = new System.Drawing.Size(71, 36);
            this.lblsex.TabIndex = 8;
            this.lblsex.Text = "性别";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(427, 394);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(75, 40);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "女";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(290, 394);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(75, 40);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "男";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(52, 239);
            this.password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(71, 36);
            this.password.TabIndex = 5;
            this.password.Text = "密码";
            this.password.Click += new System.EventHandler(this.label3_Click);
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Location = new System.Drawing.Point(50, 161);
            this.age.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(71, 36);
            this.age.TabIndex = 3;
            this.age.Text = "年龄";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // trueName
            // 
            this.trueName.AutoSize = true;
            this.trueName.Location = new System.Drawing.Point(50, 80);
            this.trueName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.trueName.Name = "trueName";
            this.trueName.Size = new System.Drawing.Size(127, 36);
            this.trueName.TabIndex = 7;
            this.trueName.Text = "真实姓名";
            // 
            // xingzuo
            // 
            this.xingzuo.AutoSize = true;
            this.xingzuo.Location = new System.Drawing.Point(50, 162);
            this.xingzuo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.xingzuo.Name = "xingzuo";
            this.xingzuo.Size = new System.Drawing.Size(71, 36);
            this.xingzuo.TabIndex = 9;
            this.xingzuo.Text = "星座";
            // 
            // bloodType
            // 
            this.bloodType.AutoSize = true;
            this.bloodType.Location = new System.Drawing.Point(50, 243);
            this.bloodType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bloodType.Name = "bloodType";
            this.bloodType.Size = new System.Drawing.Size(71, 36);
            this.bloodType.TabIndex = 9;
            this.bloodType.Text = "血型";
            // 
            // trueNameBox
            // 
            this.trueNameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trueNameBox.DefaultText = "";
            this.trueNameBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.trueNameBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.trueNameBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.trueNameBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.trueNameBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.trueNameBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.trueNameBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.trueNameBox.Location = new System.Drawing.Point(184, 80);
            this.trueNameBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.trueNameBox.Name = "trueNameBox";
            this.trueNameBox.PasswordChar = '\0';
            this.trueNameBox.PlaceholderText = "";
            this.trueNameBox.SelectedText = "";
            this.trueNameBox.Size = new System.Drawing.Size(416, 46);
            this.trueNameBox.TabIndex = 15;
            // 
            // detailInfo
            // 
            this.detailInfo.Controls.Add(this.bloodBox);
            this.detailInfo.Controls.Add(this.xingzuoBox);
            this.detailInfo.Controls.Add(this.trueNameBox);
            this.detailInfo.Controls.Add(this.bloodType);
            this.detailInfo.Controls.Add(this.xingzuo);
            this.detailInfo.Controls.Add(this.trueName);
            this.detailInfo.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.detailInfo.Location = new System.Drawing.Point(396, 616);
            this.detailInfo.Margin = new System.Windows.Forms.Padding(4);
            this.detailInfo.Name = "detailInfo";
            this.detailInfo.Padding = new System.Windows.Forms.Padding(4);
            this.detailInfo.Size = new System.Drawing.Size(668, 337);
            this.detailInfo.TabIndex = 3;
            this.detailInfo.TabStop = false;
            this.detailInfo.Text = "详细信息（选填）";
            // 
            // bloodBox
            // 
            this.bloodBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bloodBox.FormattingEnabled = true;
            this.bloodBox.Location = new System.Drawing.Point(184, 243);
            this.bloodBox.Name = "bloodBox";
            this.bloodBox.Size = new System.Drawing.Size(416, 44);
            this.bloodBox.TabIndex = 19;
            // 
            // xingzuoBox
            // 
            this.xingzuoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.xingzuoBox.FormattingEnabled = true;
            this.xingzuoBox.Location = new System.Drawing.Point(184, 165);
            this.xingzuoBox.Name = "xingzuoBox";
            this.xingzuoBox.Size = new System.Drawing.Size(416, 44);
            this.xingzuoBox.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(816, 1003);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 45);
            this.button2.TabIndex = 17;
            this.button2.Text = "取消";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(581, 1003);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 45);
            this.button1.TabIndex = 11;
            this.button1.Text = "确定";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // closeButton
            // 
            this.closeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.closeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.closeButton.DisabledState.FillColor = System.Drawing.Color.DarkGray;
            this.closeButton.DisabledState.ForeColor = System.Drawing.Color.DarkGray;
            this.closeButton.FillColor = System.Drawing.SystemColors.Window;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 5.625F);
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Image = global::WindowsFormsApp1.Properties.Resources.IonClose;
            this.closeButton.Location = new System.Drawing.Point(1098, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(70, 62);
            this.closeButton.TabIndex = 11;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.minimizeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.minimizeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.minimizeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.minimizeButton.FillColor = System.Drawing.SystemColors.Window;
            this.minimizeButton.Font = new System.Drawing.Font("Segoe UI", 5.625F);
            this.minimizeButton.ForeColor = System.Drawing.Color.White;
            this.minimizeButton.Image = global::WindowsFormsApp1.Properties.Resources.IonMinusRound_;
            this.minimizeButton.Location = new System.Drawing.Point(1024, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(70, 62);
            this.minimizeButton.TabIndex = 10;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._20200325142318_jWPnn;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(87, 218);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(250, 250);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 12;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // FormClient_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1168, 1145);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.detailInfo);
            this.Controls.Add(this.basicInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormClient_Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormClient_Register";
            this.Load += new System.EventHandler(this.FormClient_Register_Load);
            this.basicInfo.ResumeLayout(false);
            this.basicInfo.PerformLayout();
            this.detailInfo.ResumeLayout(false);
            this.detailInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label nickName;
        private System.Windows.Forms.GroupBox basicInfo;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label passwordAgain;
        private System.Windows.Forms.Label lblsex;
        private Guna.UI2.WinForms.Guna2TextBox fakeNameBox;
        private Guna.UI2.WinForms.Guna2TextBox ageBox;
        private Guna.UI2.WinForms.Guna2TextBox PasswordBox;
        private Guna.UI2.WinForms.Guna2TextBox PasswordABox;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.GroupBox detailInfo;
        private Guna.UI2.WinForms.Guna2TextBox trueNameBox;
        private System.Windows.Forms.Label bloodType;
        private System.Windows.Forms.Label xingzuo;
        private System.Windows.Forms.Label trueName;
        private Guna.UI2.WinForms.Guna2Button button2;
        private Guna.UI2.WinForms.Guna2Button button1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.ComboBox bloodBox;
        private System.Windows.Forms.ComboBox xingzuoBox;
        private Guna.UI2.WinForms.Guna2Button minimizeButton;
        private Guna.UI2.WinForms.Guna2Button closeButton;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
    }
}