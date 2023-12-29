using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW1_Zdrazhevskaya_114
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        List<Image> images = new List<Image>();
        DirectoryInfo directory_ = new DirectoryInfo(Environment.CurrentDirectory);
        string imagePath = Path.Combine(Environment.CurrentDirectory, "handleDown.GIF");
        string imagePath2 = Path.Combine(Environment.CurrentDirectory, "handleUp.GIF");
        private void pictureBox1_Click(object sender, EventArgs e) { }

        public void Form1_Load(object sender, EventArgs e)
        {
            foreach (FileInfo file in directory_.EnumerateFiles("*.JPG")) 
            {
                images.Add(Image.FromFile(file.FullName)); 
            }
        }
   
        int count_3pic = 0;
        int count_2pic = 0;

        private void btn_handle_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = images[rnd.Next(images.Count)]; 
            pictureBox2.Image = images[rnd.Next(images.Count)];
            pictureBox3.Image = images[rnd.Next(images.Count)];
            //начисление баллов
            if (pictureBox1.Image == pictureBox2.Image && pictureBox1.Image == pictureBox3.Image && pictureBox2.Image == pictureBox3.Image)
            {
                label_result.Text = "50"; //выпало 3 картинки
                count_3pic++;
            }
            else if (pictureBox1.Image == pictureBox2.Image || pictureBox1.Image == pictureBox3.Image || pictureBox2.Image == pictureBox3.Image)
            {
                label_result.Text = "10"; //выпало 2 картинки
                count_2pic++;
            }
            else { label_result.Text = "0"; }


            int res = Convert.ToInt32(label_result.Text);
            if (label_total.Text == "") { label_total.Text = "0"; }
            int sum = Convert.ToInt32(label_total.Text);
            sum += res;
            label_total.Text = Convert.ToString(sum); 
            label_2pic.Text = $"2 одинаковые картинки выпало {count_2pic} раз";
            label_3pic.Text = $"3 одинаковые картинки выпало {count_3pic} раз";

        }

        private void btn_handle_MouseDown(object sender, MouseEventArgs e) 
        {
            btn_handle.BackgroundImage = Image.FromFile(imagePath);
        }

        private void btn_handle_MouseUp(object sender, MouseEventArgs e)
        {
            btn_handle.BackgroundImage = Image.FromFile(imagePath2);
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            if (text_login.Text == "admin" && text_pass.Text == "1234")
            {
                panel_login.Hide();
            }
            else if (text_login.Text != "admin" && text_pass.Text == "1234")
            {
                MessageBox.Show("Логин неверный! Введите другой логин", "info", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else if (text_login.Text == "admin" && text_pass.Text != "1234")
            {
                MessageBox.Show("Пароль неверный! Введите другой пароль", "info", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else { MessageBox.Show("Логин и пароль неверные. Введите другие логин и пароль.", "info", MessageBoxButtons.OKCancel, MessageBoxIcon.Error); }
        }
     
        private void checkbox_login_CheckedChanged(object sender, EventArgs e)
        {
            bool flag = true;
            DialogResult yes_no;
            if (checkbox_login.Checked)
            {
                yes_no = MessageBox.Show("дать подсказку?", "question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (yes_no == DialogResult.Yes) { checkbox_login.BackColor = Color.Green; label_showLogin.BackColor = Color.White; }
                else
                {
                    checkbox_login.BackColor = Color.Red;
                    label_showLogin.BackColor = Color.Red;
                }
            }
            if (checkbox_login.Checked && flag)
            {
                label_showLogin.Text = "Логин:admin \r\n Пароль:1234";
                flag = !flag;
            }
            else
            {
                label_showLogin.Text = "";
                flag = !flag;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool flag1 = true;
        private void btn_color_Click(object sender, EventArgs e)
        {
            if (flag1)
            {
                btn_color.BackColor = Color.AntiqueWhite;
                btn_color.ForeColor = Color.Black;
                lbl_authorize.ForeColor = Color.White;
                label_pass.ForeColor = Color.White;
                label_login.ForeColor = Color.White;
                btn_login.BackColor = Color.White;
                btn_login.ForeColor = Color.Blue;
                btn_exit.BackColor = Color.Blue;
                btn_exit.ForeColor = Color.White;
                checkbox_login.ForeColor = Color.White;
                panel_login.BackColor = Color.Black;
                label1.ForeColor = Color.White;
                flag1 = !flag1;
            }
            else
            {
                btn_color.BackColor = Color.Black;
                btn_color.ForeColor = Color.White;
                lbl_authorize.ForeColor = Color.Black;
                label_pass.ForeColor = Color.Black;
                label_login.ForeColor = Color.Black;
                btn_login.BackColor = Color.White;
                btn_login.ForeColor = Color.Black;
                btn_exit.BackColor = Color.IndianRed;
                btn_exit.ForeColor = Color.Black;
                checkbox_login.ForeColor = Color.Black;
                panel_login.BackColor = Color.White;
                label1.ForeColor= Color.Black;
                flag1 = !flag1;
            }

        }

        private void Pic_MouseHover(object sender, EventArgs e)
        {
            pic.Image = images[rnd.Next(images.Count)];
        }

        private void pic_MouseLeave(object sender, EventArgs e)
        {
            pic.Image = images[rnd.Next(images.Count)];
        }
    }
}
