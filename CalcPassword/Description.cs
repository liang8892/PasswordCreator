using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcPassword
{
    public partial class Description : Form
    {
        private string _desc;
        
        public string Desc
        {
            get { return _desc; }
        }

        public Description()
        {
            InitializeComponent();
        }


        private void btn_confirm_Click(object sender, EventArgs e)
        {
            _desc = tb_desc.Text;
            if (string.IsNullOrWhiteSpace(_desc))
            {
                this.DialogResult = DialogResult.No;
            }
            else
            {
                this.DialogResult = DialogResult.Yes;
            }
        }

        private void tb_desc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
