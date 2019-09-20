namespace MathBrick
{
    partial class SignUp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_signup = new System.Windows.Forms.Button();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.textBox_uniqiecode = new System.Windows.Forms.TextBox();
            this.label_uniquecode = new System.Windows.Forms.Label();
            this.textBox_realname = new System.Windows.Forms.TextBox();
            this.label_realname = new System.Windows.Forms.Label();
            this.label_birthday = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label_birthday);
            this.panel1.Controls.Add(this.textBox_realname);
            this.panel1.Controls.Add(this.label_realname);
            this.panel1.Controls.Add(this.textBox_uniqiecode);
            this.panel1.Controls.Add(this.label_uniquecode);
            this.panel1.Controls.Add(this.button_exit);
            this.panel1.Controls.Add(this.button_signup);
            this.panel1.Controls.Add(this.textBox_password);
            this.panel1.Controls.Add(this.textBox_username);
            this.panel1.Controls.Add(this.label_password);
            this.panel1.Controls.Add(this.label_username);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 487);
            this.panel1.TabIndex = 0;
            // 
            // button_exit
            // 
            this.button_exit.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_exit.ForeColor = System.Drawing.Color.Red;
            this.button_exit.Location = new System.Drawing.Point(257, 360);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(111, 39);
            this.button_exit.TabIndex = 11;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.Button_exit_Click);
            // 
            // button_signup
            // 
            this.button_signup.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_signup.ForeColor = System.Drawing.Color.LimeGreen;
            this.button_signup.Location = new System.Drawing.Point(98, 360);
            this.button_signup.Name = "button_signup";
            this.button_signup.Size = new System.Drawing.Size(111, 39);
            this.button_signup.TabIndex = 10;
            this.button_signup.Text = "Sign Up";
            this.button_signup.UseVisualStyleBackColor = true;
            this.button_signup.Click += new System.EventHandler(this.Button_signup_Click);
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_password.Location = new System.Drawing.Point(194, 114);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(195, 29);
            this.textBox_password.TabIndex = 9;
            // 
            // textBox_username
            // 
            this.textBox_username.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_username.Location = new System.Drawing.Point(194, 59);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(195, 29);
            this.textBox_username.TabIndex = 8;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_password.Location = new System.Drawing.Point(75, 117);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(108, 19);
            this.label_password.TabIndex = 7;
            this.label_password.Text = "Password:";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_username.Location = new System.Drawing.Point(75, 62);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(108, 19);
            this.label_username.TabIndex = 6;
            this.label_username.Text = "Username:";
            // 
            // textBox_uniqiecode
            // 
            this.textBox_uniqiecode.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_uniqiecode.Location = new System.Drawing.Point(194, 169);
            this.textBox_uniqiecode.Name = "textBox_uniqiecode";
            this.textBox_uniqiecode.Size = new System.Drawing.Size(195, 29);
            this.textBox_uniqiecode.TabIndex = 13;
            // 
            // label_uniquecode
            // 
            this.label_uniquecode.AutoSize = true;
            this.label_uniquecode.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_uniquecode.Location = new System.Drawing.Point(53, 172);
            this.label_uniquecode.Name = "label_uniquecode";
            this.label_uniquecode.Size = new System.Drawing.Size(130, 19);
            this.label_uniquecode.TabIndex = 12;
            this.label_uniquecode.Text = "Uniquecode:";
            // 
            // textBox_realname
            // 
            this.textBox_realname.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_realname.Location = new System.Drawing.Point(194, 229);
            this.textBox_realname.Name = "textBox_realname";
            this.textBox_realname.Size = new System.Drawing.Size(195, 29);
            this.textBox_realname.TabIndex = 15;
            // 
            // label_realname
            // 
            this.label_realname.AutoSize = true;
            this.label_realname.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_realname.Location = new System.Drawing.Point(75, 232);
            this.label_realname.Name = "label_realname";
            this.label_realname.Size = new System.Drawing.Size(108, 19);
            this.label_realname.TabIndex = 14;
            this.label_realname.Text = "Realname:";
            // 
            // label_birthday
            // 
            this.label_birthday.AutoSize = true;
            this.label_birthday.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_birthday.Location = new System.Drawing.Point(75, 288);
            this.label_birthday.Name = "label_birthday";
            this.label_birthday.Size = new System.Drawing.Size(108, 19);
            this.label_birthday.TabIndex = 16;
            this.label_birthday.Text = "Birthday:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(194, 289);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(195, 21);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 487);
            this.Controls.Add(this.panel1);
            this.Name = "SignUp";
            this.Text = "MATHBRICK";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_signup;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label_birthday;
        private System.Windows.Forms.TextBox textBox_realname;
        private System.Windows.Forms.Label label_realname;
        private System.Windows.Forms.TextBox textBox_uniqiecode;
        private System.Windows.Forms.Label label_uniquecode;
    }
}