namespace 课程设计_药库管理
{
    partial class frm_LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_LogIn));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_UserNo = new System.Windows.Forms.Label();
            this.txb_UserNo = new System.Windows.Forms.TextBox();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(963, 406);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_UserNo
            // 
            this.lbl_UserNo.AutoSize = true;
            this.lbl_UserNo.Font = new System.Drawing.Font("宋体", 16F);
            this.lbl_UserNo.Location = new System.Drawing.Point(323, 453);
            this.lbl_UserNo.Name = "lbl_UserNo";
            this.lbl_UserNo.Size = new System.Drawing.Size(111, 33);
            this.lbl_UserNo.TabIndex = 1;
            this.lbl_UserNo.Text = "账号：";
            // 
            // txb_UserNo
            // 
            this.txb_UserNo.Font = new System.Drawing.Font("宋体", 13F);
            this.txb_UserNo.Location = new System.Drawing.Point(440, 446);
            this.txb_UserNo.Multiline = true;
            this.txb_UserNo.Name = "txb_UserNo";
            this.txb_UserNo.Size = new System.Drawing.Size(174, 40);
            this.txb_UserNo.TabIndex = 2;
            // 
            // txb_Password
            // 
            this.txb_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_Password.Font = new System.Drawing.Font("宋体", 13F);
            this.txb_Password.Location = new System.Drawing.Point(440, 512);
            this.txb_Password.Multiline = true;
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.PasswordChar = '*';
            this.txb_Password.Size = new System.Drawing.Size(174, 40);
            this.txb_Password.TabIndex = 4;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("宋体", 16F);
            this.lbl_Password.Location = new System.Drawing.Point(323, 519);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(111, 33);
            this.lbl_Password.TabIndex = 3;
            this.lbl_Password.Text = "密码：";
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_Login.Location = new System.Drawing.Point(353, 583);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(251, 43);
            this.btn_Login.TabIndex = 5;
            this.btn_Login.Text = "登入";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // frm_LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(964, 682);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txb_Password);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.txb_UserNo);
            this.Controls.Add(this.lbl_UserNo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frm_LogIn";
            this.Text = "药库管理 —— 登入界面";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_UserNo;
        private System.Windows.Forms.TextBox txb_UserNo;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Button btn_Login;
    }
}

