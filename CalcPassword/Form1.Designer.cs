namespace CalcPassword
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tb_pwd1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_pwd2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_pwdFinal = new System.Windows.Forms.TextBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_pwd1
            // 
            this.tb_pwd1.Location = new System.Drawing.Point(108, 32);
            this.tb_pwd1.Name = "tb_pwd1";
            this.tb_pwd1.Size = new System.Drawing.Size(344, 21);
            this.tb_pwd1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "记忆密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "区分密码";
            // 
            // tb_pwd2
            // 
            this.tb_pwd2.Location = new System.Drawing.Point(108, 88);
            this.tb_pwd2.Name = "tb_pwd2";
            this.tb_pwd2.Size = new System.Drawing.Size(344, 21);
            this.tb_pwd2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "生成密码";
            // 
            // tb_pwdFinal
            // 
            this.tb_pwdFinal.Location = new System.Drawing.Point(108, 145);
            this.tb_pwdFinal.Name = "tb_pwdFinal";
            this.tb_pwdFinal.ReadOnly = true;
            this.tb_pwdFinal.Size = new System.Drawing.Size(344, 21);
            this.tb_pwdFinal.TabIndex = 4;
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(209, 201);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 30);
            this.btn_create.TabIndex = 6;
            this.btn_create.Text = "生成";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_create;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 255);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_pwdFinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_pwd2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_pwd1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "密码生成器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_pwd1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_pwd2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_pwdFinal;
        private System.Windows.Forms.Button btn_create;
    }
}

