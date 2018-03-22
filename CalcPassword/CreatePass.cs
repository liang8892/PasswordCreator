using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcPassword
{
    public partial class CreatePass : Form
    {
        public CreatePass()
        {
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            string pwd = "";
            string pwd1 = tb_pwd1.Text;
            string pwd2 = tb_pwd2.Text;
            
            string feed = pwd1 + "@" + pwd2 + "@8892";
            byte[] feedToByte = Encoding.UTF8.GetBytes(feed);
            
            MD5 md5 = MD5.Create();
            byte[] hash = md5.ComputeHash(feedToByte);
            for (int i = 0; i < hash.Length; i++)
            {
                //pwd += hash[i].ToString("x2");//小写
                pwd += hash[i].ToString("X2");//大写
            }
            //tb_pwdFinal.Text = pwd;//32位
            tb_pwdFinal.Text = pwd.Substring(0, 16);//16位
        }
        
        private void btn_copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tb_pwdFinal.Text);
            if (Clipboard.GetText() == tb_pwdFinal.Text)
            {
                MessageBox.Show("成功复制到剪贴板。");
            }
        }

        private void Text_Changed(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tb_pwd1.Text)
                && !string.IsNullOrWhiteSpace(tb_pwd2.Text))
            {
                btn_create_Click(null, null);
            }
        }

        //
        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            this.Visible = false;
            PasswordManager pm = new PasswordManager();
            pm.ShowDialog();
            this.Visible = true;
            //var result = pm.ShowDialog();
            //if(result==DialogResult.)
        }
    }
}
