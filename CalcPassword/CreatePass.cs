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
using EncryptionHelper;
using GlobalPara;


namespace CalcPassword
{
    public partial class CreatePass : Form
    {
        public CreatePass()
        {
            InitializeComponent();
        }

        //文本变化，重新计算密码
        private void Text_Changed(object sender, EventArgs e)
        {
            if (tb_pwd1.Text.EndsWith(" "))
            {
                tb_pwd1.Text = tb_pwd1.Text.TrimEnd(' ');
            }
            if (tb_pwd2.Text.EndsWith(" "))
            {
                tb_pwd2.Text = tb_pwd2.Text.TrimEnd(' ');
            }
            if (!string.IsNullOrWhiteSpace(tb_pwd1.Text)
                && !string.IsNullOrWhiteSpace(tb_pwd2.Text))
            {
                btn_create_Click(null, null);
            }
            else
            {
                tb_pwdFinal.Text = "";
            }
        }

        //计算密码
        private void btn_create_Click(object sender, EventArgs e)
        {
            string pwd = "";
            string pwd1 = tb_pwd1.Text;
            string pwd2 = tb_pwd2.Text;
            
            string feed = pwd1 + pwd2 + Paras.AddedString;
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
        
        //复制密码到剪贴板
        private void btn_copy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tb_pwdFinal.Text))
            {
                Clipboard.SetText(tb_pwdFinal.Text);
                if (Clipboard.GetText() == tb_pwdFinal.Text)
                {
                    //MessageBox.Show("成功复制到剪贴板。");
                    label_copy.Visible = true;
                }
            }
        }

        //密码管理
        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            this.Visible = false;
            PasswordManager pm = new PasswordManager();
            pm.ShowDialog();
            this.Visible = true;
        }

        //保存密码
        private void panel2_Click(object sender, EventArgs e)
        {
            string pwd2 = tb_pwd2.Text;
            if (string.IsNullOrWhiteSpace(pwd2)) return;

            try
            {
                //string path = Path.GetDirectoryName(Paras.PwdFile);
                if (!Directory.Exists(Path.GetDirectoryName(Paras.PwdFile)))
                {
                    Directory.CreateDirectory(Path.GetFullPath(Paras.PwdFile));
                }
                List<string> savePwd = new List<string>();
                Description desc = new CalcPassword.Description();
                var result = desc.ShowDialog();
                while (result != DialogResult.Yes)
                {
                    if (result == DialogResult.Cancel)
                        return;
                    result = desc.ShowDialog();
                }
                savePwd.Add(pwd2 + Paras.SplitStr + desc.Desc);

                if (File.Exists(Paras.PwdFile))
                {
                    Encryption.DESFileClass.DecryptFile(Paras.PwdFile, Paras.TempFile1, Paras.EncryptionPassword);
                }
                File.AppendAllLines(Paras.TempFile1, savePwd);

                Encryption.DESFileClass.EncryptFile(Paras.TempFile1, Paras.PwdFile, Paras.EncryptionPassword);
                File.Delete(Paras.TempFile1);

                label_save.Text = "保存成功";
            }
            catch (Exception exception)
            {
                label_save.Text = "保存失败";
            }
        }

        private void tb_pwdFinal_TextChanged(object sender, EventArgs e)
        {
            label_copy.Visible = false;
            label_save.Text = "";
        }
    }
}
