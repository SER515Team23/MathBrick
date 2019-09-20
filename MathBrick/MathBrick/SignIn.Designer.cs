namespace MathBrick
{
    partial class SignIn
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_signIn = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.label_signUp = new System.Windows.Forms.Label();
            this.label_forgotPassword = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_forgotPassword);
            this.panel1.Controls.Add(this.label_signUp);
            this.panel1.Controls.Add(this.button_exit);
            this.panel1.Controls.Add(this.button_signIn);
            this.panel1.Controls.Add(this.textBox_password);
            this.panel1.Controls.Add(this.textBox_username);
            this.panel1.Controls.Add(this.label_password);
            this.panel1.Controls.Add(this.label_username);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 290);
            this.panel1.TabIndex = 0;
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_username.Location = new System.Drawing.Point(62, 58);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(108, 19);
            this.label_username.TabIndex = 0;
            this.label_username.Text = "Username:";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_password.Location = new System.Drawing.Point(62, 107);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(108, 19);
            this.label_password.TabIndex = 1;
            this.label_password.Text = "Password:";
            // 
            // textBox_username
            // 
            this.textBox_username.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_username.Location = new System.Drawing.Point(181, 55);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(195, 29);
            this.textBox_username.TabIndex = 2;
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_password.Location = new System.Drawing.Point(181, 104);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(195, 29);
            this.textBox_password.TabIndex = 3;
            // 
            // button_signIn
            // 
            this.button_signIn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_signIn.ForeColor = System.Drawing.Color.LimeGreen;
            this.button_signIn.Location = new System.Drawing.Point(85, 180);
            this.button_signIn.Name = "button_signIn";
            this.button_signIn.Size = new System.Drawing.Size(111, 39);
            this.button_signIn.TabIndex = 4;
            this.button_signIn.Text = "Sign In";
            this.button_signIn.UseVisualStyleBackColor = true;
            this.button_signIn.Click += new System.EventHandler(this.Button_signIn_Click);
            // 
            // button_exit
            // 
            this.button_exit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_exit.ForeColor = System.Drawing.Color.Red;
            this.button_exit.Location = new System.Drawing.Point(247, 180);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(111, 39);
            this.button_exit.TabIndex = 5;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            // 
            // label_signUp
            // 
            this.label_signUp.AutoSize = true;
            this.label_signUp.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_signUp.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_signUp.Location = new System.Drawing.Point(114, 240);
            this.label_signUp.Name = "label_signUp";
            this.label_signUp.Size = new System.Drawing.Size(56, 14);
            this.label_signUp.TabIndex = 6;
            this.label_signUp.Text = "Sign Up";
            this.label_signUp.Click += new System.EventHandler(this.Label_signUp_Click);
            // 
            // label_forgotPassword
            // 
            this.label_forgotPassword.AutoSize = true;
            this.label_forgotPassword.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_forgotPassword.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_forgotPassword.Location = new System.Drawing.Point(247, 240);
            this.label_forgotPassword.Name = "label_forgotPassword";
            this.label_forgotPassword.Size = new System.Drawing.Size(112, 14);
            this.label_forgotPassword.TabIndex = 7;
            this.label_forgotPassword.Text = "Forgot Password";
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 290);
            this.Controls.Add(this.panel1);
            this.Name = "SignIn";
            this.Text = "MATHBRICK";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_signIn;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_forgotPassword;
        private System.Windows.Forms.Label label_signUp;
    }
}

