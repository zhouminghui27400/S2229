using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegist a = new FrmRegist(this);
           
           
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //非空验证;

            if ((this.tbemail.Text == null || this.tbemail.Text == "") || (this.textBox1.Text == null || this.textBox1.Text == ""))
            {
                MessageBox.Show("邮箱和密码不允许为空。", "提示");
            }
            else
            {
                string userName = tbemail.Text;
                string pwd = textBox1.Text;
                bool isOK = false;
                foreach (LoginInfo item in array)
                {
                    if (item != null)
                    {
                        if (item.Email == userName && item.Password == pwd)
                        {
                            label2.Visible = false;
                            isOK = true;
                            FrmMain fm = new FrmMain();
                            fm.lblName.Text = "欢迎,"+item.Name;
                            fm.Show();
                            break;

                        }
                    }
                }
                if (isOK == false)
                {
                    label2.Visible = true;
                    textBox1.Text = "";
                    textBox1.Focus();
                }
            }
        }
        public LoginInfo[] array;
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //初始用户信息
            array = new LoginInfo[10];
            LoginInfo info1 = new LoginInfo();
            info1.Name = "孙丽丽";
            info1.Id = "362330200104240717";
            info1.Email = "lili@.com";
            info1.Password = "lili";
            array[0] = info1;
            
            label2.Visible = false;

        }

        private void tbemail_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
