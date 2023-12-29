namespace CW1_Zdrazhevskaya_114
{
    partial class Form1
    {
 
        private System.ComponentModel.IContainer components = null;
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

 
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_handle = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.label_result = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.label_2pic = new System.Windows.Forms.Label();
            this.label_3pic = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel_login = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pic = new System.Windows.Forms.PictureBox();
            this.btn_color = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label_showLogin = new System.Windows.Forms.Label();
            this.checkbox_login = new System.Windows.Forms.CheckBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.text_pass = new System.Windows.Forms.TextBox();
            this.text_login = new System.Windows.Forms.TextBox();
            this.label_pass = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.lbl_authorize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_handle
            // 
            this.btn_handle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_handle.BackgroundImage")));
            this.btn_handle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_handle.Location = new System.Drawing.Point(521, 77);
            this.btn_handle.Name = "btn_handle";
            this.btn_handle.Size = new System.Drawing.Size(97, 320);
            this.btn_handle.TabIndex = 0;
            this.btn_handle.UseVisualStyleBackColor = true;
            this.btn_handle.Click += new System.EventHandler(this.btn_handle_Click);
            this.btn_handle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_handle_MouseDown);
            this.btn_handle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_handle_MouseUp);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(77, 231);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(182, 20);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Последний результат:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(77, 272);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(127, 20);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Набрано очков:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(81, 315);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(103, 20);
            this.lbl3.TabIndex = 3;
            this.lbl3.Text = "Статистика:";
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Location = new System.Drawing.Point(281, 231);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(9, 20);
            this.label_result.TabIndex = 4;
            this.label_result.Text = "\r\n";
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Location = new System.Drawing.Point(285, 271);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(0, 20);
            this.label_total.TabIndex = 5;
            // 
            // label_2pic
            // 
            this.label_2pic.AutoSize = true;
            this.label_2pic.Location = new System.Drawing.Point(90, 358);
            this.label_2pic.Name = "label_2pic";
            this.label_2pic.Size = new System.Drawing.Size(0, 20);
            this.label_2pic.TabIndex = 6;
            // 
            // label_3pic
            // 
            this.label_3pic.AutoSize = true;
            this.label_3pic.Location = new System.Drawing.Point(94, 393);
            this.label_3pic.Name = "label_3pic";
            this.label_3pic.Size = new System.Drawing.Size(0, 20);
            this.label_3pic.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(72, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 144);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(220, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(97, 144);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(357, 48);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(106, 144);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // panel_login
            // 
            this.panel_login.Controls.Add(this.label1);
            this.panel_login.Controls.Add(this.pic);
            this.panel_login.Controls.Add(this.btn_color);
            this.panel_login.Controls.Add(this.btn_exit);
            this.panel_login.Controls.Add(this.label_showLogin);
            this.panel_login.Controls.Add(this.checkbox_login);
            this.panel_login.Controls.Add(this.btn_login);
            this.panel_login.Controls.Add(this.text_pass);
            this.panel_login.Controls.Add(this.text_login);
            this.panel_login.Controls.Add(this.label_pass);
            this.panel_login.Controls.Add(this.label_login);
            this.panel_login.Controls.Add(this.lbl_authorize);
            this.panel_login.Location = new System.Drawing.Point(12, 12);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(696, 454);
            this.panel_login.TabIndex = 11;
                 // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(520, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "навести курсор";
            // 
            // pic
            // 
            this.pic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic.BackgroundImage")));
            this.pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic.Location = new System.Drawing.Point(535, 163);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(99, 142);
            this.pic.TabIndex = 10;
            this.pic.TabStop = false;
            this.pic.MouseLeave += new System.EventHandler(this.pic_MouseLeave);
            this.pic.MouseHover += new System.EventHandler(this.Pic_MouseHover);
            // 
            // btn_color
            // 
            this.btn_color.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_color.Cursor = System.Windows.Forms.Cursors.Help;
            this.btn_color.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_color.Location = new System.Drawing.Point(19, 23);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(155, 35);
            this.btn_color.TabIndex = 9;
            this.btn_color.Text = "Поменять цвет";
            this.btn_color.UseVisualStyleBackColor = false;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.IndianRed;
            this.btn_exit.Location = new System.Drawing.Point(524, 23);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 35);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "выход";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label_showLogin
            // 
            this.label_showLogin.AutoSize = true;
            this.label_showLogin.ForeColor = System.Drawing.Color.Tomato;
            this.label_showLogin.Location = new System.Drawing.Point(155, 376);
            this.label_showLogin.Name = "label_showLogin";
            this.label_showLogin.Size = new System.Drawing.Size(0, 20);
            this.label_showLogin.TabIndex = 7;
            // 
            // checkbox_login
            // 
            this.checkbox_login.AutoSize = true;
            this.checkbox_login.Location = new System.Drawing.Point(257, 310);
            this.checkbox_login.Name = "checkbox_login";
            this.checkbox_login.Size = new System.Drawing.Size(244, 24);
            this.checkbox_login.TabIndex = 6;
            this.checkbox_login.Text = "подсказать пароль и логин";
            this.checkbox_login.UseVisualStyleBackColor = true;
            this.checkbox_login.CheckedChanged += new System.EventHandler(this.checkbox_login_CheckedChanged);
            // 
            // btn_login
            // 
            this.btn_login.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btn_login.Location = new System.Drawing.Point(59, 301);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(182, 41);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Войти";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // text_pass
            // 
            this.text_pass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.text_pass.Location = new System.Drawing.Point(204, 243);
            this.text_pass.Name = "text_pass";
            this.text_pass.Size = new System.Drawing.Size(288, 26);
            this.text_pass.TabIndex = 4;
            // 
            // text_login
            // 
            this.text_login.Cursor = System.Windows.Forms.Cursors.Cross;
            this.text_login.Location = new System.Drawing.Point(204, 197);
            this.text_login.Name = "text_login";
            this.text_login.Size = new System.Drawing.Size(288, 26);
            this.text_login.TabIndex = 3;
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_pass.Location = new System.Drawing.Point(39, 250);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(141, 22);
            this.label_pass.TabIndex = 2;
            this.label_pass.Text = "Введите пароль:";
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_login.Location = new System.Drawing.Point(41, 198);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(130, 22);
            this.label_login.TabIndex = 1;
            this.label_login.Text = "Введите логин:";
            // 
            // lbl_authorize
            // 
            this.lbl_authorize.AutoSize = true;
            this.lbl_authorize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_authorize.Location = new System.Drawing.Point(146, 137);
            this.lbl_authorize.Name = "lbl_authorize";
            this.lbl_authorize.Size = new System.Drawing.Size(225, 22);
            this.lbl_authorize.TabIndex = 0;
            this.lbl_authorize.Text = "Пожалуйста, авторизуйтесь";
            this.lbl_authorize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(687, 454);
            this.Controls.Add(this.panel_login);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_3pic);
            this.Controls.Add(this.label_2pic);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btn_handle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Однорукий бандит";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        private System.Windows.Forms.Button btn_handle;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Label label_2pic;
        private System.Windows.Forms.Label label_3pic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel_login;
        private System.Windows.Forms.Label label_showLogin;
        private System.Windows.Forms.CheckBox checkbox_login;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox text_pass;
        private System.Windows.Forms.TextBox text_login;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label lbl_authorize;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Label label1;
    }
}

