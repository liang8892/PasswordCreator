namespace CalcPassword
{
    partial class Description
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
            this.tb_desc = new System.Windows.Forms.TextBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_desc
            // 
            this.tb_desc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_desc.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_desc.Location = new System.Drawing.Point(0, 0);
            this.tb_desc.Name = "tb_desc";
            this.tb_desc.Size = new System.Drawing.Size(349, 26);
            this.tb_desc.TabIndex = 0;
            this.tb_desc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_desc_KeyDown);
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(137, 49);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_confirm.TabIndex = 1;
            this.btn_confirm.Text = "OK";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // Description
            // 
            this.AcceptButton = this.btn_confirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 26);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.tb_desc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Description";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Description";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_desc;
        private System.Windows.Forms.Button btn_confirm;
    }
}