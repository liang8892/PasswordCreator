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
    public partial class Form1 : Form
    {
        public Form1()
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
                //pwd += hash[i].ToString("x2");
                pwd += hash[i].ToString("X2");
            }
            tb_pwdFinal.Text = pwd;
        }
    }
}
