using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EncryptionHelper;
using GlobalPara;

namespace CalcPassword
{
    public partial class PasswordManager : Form
    {
        public PasswordManager()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            DataTable dt = new DataTable("Table1");
            dt.Columns.Add("区分密码");
            dt.Columns.Add("密码描述");
            //dt.Columns.Add("操作");
            Encryption.DESFileClass.DecryptFile(Paras.PwdFile, Paras.TempFile2, Paras.EncryptionPassword);
            var pwds = File.ReadAllLines(Paras.TempFile2).ToList();
            if (pwds.Count > 0)
            {
                foreach (string s in pwds)
                {
                    var pwd = s.Split(Paras.SplitStr);
                    if (pwd.Length < 2) continue;
                    DataRow dr = dt.NewRow();
                    dr["区分密码"] = pwd[0].ToString();
                    dr["密码描述"] = pwd[1].ToString();
                    dt.Rows.Add(dr);
                }
                //DataSet ds = new DataSet();
                //ds.Tables.Add(dt);
                //dataGridView1.DataSource = ds;
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[1].Width = 460;
                //dataGridView1.Columns[1].Width = 100;
            }
            File.Delete(Paras.TempFile2);
        }
    }
}
