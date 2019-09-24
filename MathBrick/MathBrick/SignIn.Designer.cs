namespace MathBrick
{
    partial class SignIn
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.fogotPasswordButton = new CCWin.SkinControl.SkinButton();
            this.signUpButton = new CCWin.SkinControl.SkinButton();
            this.signinButton = new CCWin.SkinControl.SkinButton();
            this.passwordTextBox = new CCWin.SkinControl.SkinTextBox();
            this.userNameTextBox = new CCWin.SkinControl.SkinTextBox();
            this.passwordLabel = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.PeachPuff;
            this.skinPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skinPanel1.BackgroundImage")));
            this.skinPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.skinPanel1.Controls.Add(this.fogotPasswordButton);
            this.skinPanel1.Controls.Add(this.signUpButton);
            this.skinPanel1.Controls.Add(this.signinButton);
            this.skinPanel1.Controls.Add(this.passwordTextBox);
            this.skinPanel1.Controls.Add(this.userNameTextBox);
            this.skinPanel1.Controls.Add(this.passwordLabel);
            this.skinPanel1.Controls.Add(this.skinLabel1);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(-1, -1);
            this.skinPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(555, 407);
            this.skinPanel1.TabIndex = 0;
            // 
            // fogotPasswordButton
            // 
            this.fogotPasswordButton.BackColor = System.Drawing.Color.Transparent;
            this.fogotPasswordButton.BaseColor = System.Drawing.Color.Transparent;
            this.fogotPasswordButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fogotPasswordButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.fogotPasswordButton.DownBack = null;
            this.fogotPasswordButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fogotPasswordButton.Location = new System.Drawing.Point(186, 322);
            this.fogotPasswordButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fogotPasswordButton.MouseBack = null;
            this.fogotPasswordButton.Name = "fogotPasswordButton";
            this.fogotPasswordButton.NormlBack = null;
            this.fogotPasswordButton.Radius = 20;
            this.fogotPasswordButton.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.fogotPasswordButton.Size = new System.Drawing.Size(154, 44);
            this.fogotPasswordButton.TabIndex = 6;
            this.fogotPasswordButton.Text = "Fogot Password";
            this.fogotPasswordButton.UseVisualStyleBackColor = false;
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.Color.Transparent;
            this.signUpButton.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.signUpButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.signUpButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.signUpButton.DownBack = null;
            this.signUpButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpButton.Location = new System.Drawing.Point(324, 259);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.signUpButton.MouseBack = null;
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.NormlBack = null;
            this.signUpButton.Radius = 20;
            this.signUpButton.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.signUpButton.Size = new System.Drawing.Size(95, 41);
            this.signUpButton.TabIndex = 5;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // signinButton
            // 
            this.signinButton.BackColor = System.Drawing.Color.Transparent;
            this.signinButton.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.signinButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.signinButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.signinButton.DownBack = null;
            this.signinButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinButton.Location = new System.Drawing.Point(118, 259);
            this.signinButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.signinButton.MouseBack = null;
            this.signinButton.Name = "signinButton";
            this.signinButton.NormlBack = null;
            this.signinButton.Radius = 20;
            this.signinButton.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.signinButton.Size = new System.Drawing.Size(95, 41);
            this.signinButton.TabIndex = 4;
            this.signinButton.Text = "Sign In";
            this.signinButton.UseVisualStyleBackColor = false;
            this.signinButton.Click += new System.EventHandler(this.SigninButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.Transparent;
            this.passwordTextBox.DownBack = null;
            this.passwordTextBox.Icon = null;
            this.passwordTextBox.IconIsButton = false;
            this.passwordTextBox.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.passwordTextBox.IsPasswordChat = '\0';
            this.passwordTextBox.IsSystemPasswordChar = false;
            this.passwordTextBox.Lines = new string[0];
            this.passwordTextBox.Location = new System.Drawing.Point(234, 92);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.passwordTextBox.MaxLength = 32767;
            this.passwordTextBox.MinimumSize = new System.Drawing.Size(28, 32);
            this.passwordTextBox.MouseBack = null;
            this.passwordTextBox.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.passwordTextBox.Multiline = true;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.NormlBack = null;
            this.passwordTextBox.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.passwordTextBox.ReadOnly = false;
            this.passwordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordTextBox.Size = new System.Drawing.Size(185, 32);
            // 
            // 
            // 
            this.passwordTextBox.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordTextBox.SkinTxt.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.passwordTextBox.SkinTxt.Location = new System.Drawing.Point(5, 6);
            this.passwordTextBox.SkinTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordTextBox.SkinTxt.Multiline = true;
            this.passwordTextBox.SkinTxt.Name = "BaseText";
            this.passwordTextBox.SkinTxt.Size = new System.Drawing.Size(175, 20);
            this.passwordTextBox.SkinTxt.TabIndex = 0;
            this.passwordTextBox.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.passwordTextBox.SkinTxt.WaterText = "";
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordTextBox.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.passwordTextBox.WaterText = "";
            this.passwordTextBox.WordWrap = true;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.userNameTextBox.DownBack = null;
            this.userNameTextBox.Icon = null;
            this.userNameTextBox.IconIsButton = false;
            this.userNameTextBox.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.userNameTextBox.IsPasswordChat = '\0';
            this.userNameTextBox.IsSystemPasswordChar = false;
            this.userNameTextBox.Lines = new string[0];
            this.userNameTextBox.Location = new System.Drawing.Point(234, 48);
            this.userNameTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.userNameTextBox.MaxLength = 32767;
            this.userNameTextBox.MinimumSize = new System.Drawing.Size(28, 32);
            this.userNameTextBox.MouseBack = null;
            this.userNameTextBox.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.userNameTextBox.Multiline = true;
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.NormlBack = null;
            this.userNameTextBox.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.userNameTextBox.ReadOnly = false;
            this.userNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userNameTextBox.Size = new System.Drawing.Size(185, 32);
            // 
            // 
            // 
            this.userNameTextBox.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userNameTextBox.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userNameTextBox.SkinTxt.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.userNameTextBox.SkinTxt.Location = new System.Drawing.Point(5, 6);
            this.userNameTextBox.SkinTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userNameTextBox.SkinTxt.Multiline = true;
            this.userNameTextBox.SkinTxt.Name = "BaseText";
            this.userNameTextBox.SkinTxt.Size = new System.Drawing.Size(175, 20);
            this.userNameTextBox.SkinTxt.TabIndex = 0;
            this.userNameTextBox.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.userNameTextBox.SkinTxt.WaterText = "";
            this.userNameTextBox.TabIndex = 2;
            this.userNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.userNameTextBox.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.userNameTextBox.WaterText = "";
            this.userNameTextBox.WordWrap = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.BorderColor = System.Drawing.Color.White;
            this.passwordLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(114, 92);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(99, 23);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password  :";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinLabel1.Location = new System.Drawing.Point(114, 48);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(101, 24);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "Username:";
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(556, 406);
            this.Controls.Add(this.skinPanel1);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MATHBRICK";
            this.Load += new System.EventHandler(this.SignIn_Load);
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinButton signinButton;
        private CCWin.SkinControl.SkinTextBox passwordTextBox;
        private CCWin.SkinControl.SkinTextBox userNameTextBox;
        private CCWin.SkinControl.SkinLabel passwordLabel;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinButton fogotPasswordButton;
        private CCWin.SkinControl.SkinButton signUpButton;
    }
}

