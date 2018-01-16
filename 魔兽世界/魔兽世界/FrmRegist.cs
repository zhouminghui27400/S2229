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
    public partial class FrmRegist : Form
    {
        public FrmLogin fl;
        public FrmRegist(FrmLogin FL)
        {
            InitializeComponent();
            fl = FL;
        }
        LoginInfo info = new LoginInfo();
        private void FrmRegist_Load(object sender, EventArgs e)
        {

        }
       
        public bool show()
        {
            bool ft = true;

             if (this.textBox1.Text.Trim() == "")
            {
                
                return ft= false;
            }
                else if(this.textBox2.Text.Trim() == "")
            {
                return ft = false;
            }
                else if (this.textBox2.Text.Trim() == "")
            {
                return ft = false;
            }
                else if (this.textBox3.Text.Trim() == "")
            {
                return ft = false;
            }
                else if (this.textBox5.Text.Trim() == "")
            {
                return ft = false;
            }
                else if (this.textBox4.Text.Trim() == "")
            {
                return ft = false;
            }
                else if (this.textBox6.Text.Trim() == "")
            {
                return ft = false;
            }
            return ft;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            info.Name = textBox1.Text;
            info.Id = textBox2.Text;
            info.Email = textBox3.Text;
            info.Password = textBox4.Text;

            if (show())
            {
                if (this.textBox3.Text.Trim().Equals(this.textBox5.Text.Trim()) && this.textBox4.Text.Trim().Equals(this.textBox6.Text.Trim()))
                {
                    MessageBox.Show("恭喜通过验证!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    for (int i = 0; i < fl.array.Length; i++)
                    {
                        if (fl.array[i] == null)
                        {
                            fl.array[i] = info;
                            break;
                        }
                    }
                    this.Close();
                }
                 else
            {
                MessageBox.Show("请输入再次输入的邮箱或密码是否与一致");
            }
                    
            }
            else
            {
                MessageBox.Show("请输入完整的文本框信息");
            }
         
                
               
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

            this.Close();
        }
    }
}
