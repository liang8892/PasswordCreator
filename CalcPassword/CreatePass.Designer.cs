namespace CalcPassword
{
    partial class CreatePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePass));
            this.tb_pwd1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_pwd2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_pwdFinal = new System.Windows.Forms.TextBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_copy = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_pwd1
            // 
            this.tb_pwd1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_pwd1.Location = new System.Drawing.Point(129, 183);
            this.tb_pwd1.Name = "tb_pwd1";
            this.tb_pwd1.Size = new System.Drawing.Size(168, 33);
            this.tb_pwd1.TabIndex = 0;
            this.tb_pwd1.TextChanged += new System.EventHandler(this.Text_Changed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(35, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "记忆密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(303, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "区分密码";
            // 
            // tb_pwd2
            // 
            this.tb_pwd2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_pwd2.Location = new System.Drawing.Point(397, 183);
            this.tb_pwd2.Name = "tb_pwd2";
            this.tb_pwd2.Size = new System.Drawing.Size(168, 33);
            this.tb_pwd2.TabIndex = 2;
            this.tb_pwd2.TextChanged += new System.EventHandler(this.Text_Changed);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(32, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "16位密码";
            // 
            // tb_pwdFinal
            // 
            this.tb_pwdFinal.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_pwdFinal.Location = new System.Drawing.Point(129, 266);
            this.tb_pwdFinal.Name = "tb_pwdFinal";
            this.tb_pwdFinal.ReadOnly = true;
            this.tb_pwdFinal.Size = new System.Drawing.Size(262, 33);
            this.tb_pwdFinal.TabIndex = 4;
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(149, 378);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(94, 30);
            this.btn_create.TabIndex = 6;
            this.btn_create.Text = "生成密码";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Visible = false;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_copy
            // 
            this.btn_copy.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_copy.Location = new System.Drawing.Point(442, 266);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(123, 33);
            this.btn_copy.TabIndex = 8;
            this.btn_copy.Text = "复制密码";
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CalcPassword.Properties.Resources.background;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 127);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(157, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(25, 19);
            this.panel2.TabIndex = 0;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            this.panel2.DoubleClick += new System.EventHandler(this.panel1_DoubleClick);
            // 
            // CreatePass
            // 
            this.AcceptButton = this.btn_create;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 345);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_copy);
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
            this.Name = "CreatePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "密码生成器";
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

