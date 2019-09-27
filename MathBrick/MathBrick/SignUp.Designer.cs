namespace MathBrick
{
    partial class SignUp
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.usernameLabel = new CCWin.SkinControl.SkinLabel();
            this.passwordLabel = new CCWin.SkinControl.SkinLabel();
            this.activateCodeLabel = new CCWin.SkinControl.SkinLabel();
            this.usernameTextBox = new CCWin.SkinControl.SkinTextBox();
            this.passwordTextBox = new CCWin.SkinControl.SkinTextBox();
            this.activateCodeTextBox = new CCWin.SkinControl.SkinTextBox();
            this.signinButton = new CCWin.SkinControl.SkinButton();
            this.quitButton = new CCWin.SkinControl.SkinButton();
            this.skinPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.PeachPuff;
            this.skinPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skinPanel1.BackgroundImage")));
            this.skinPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.skinPanel1.Controls.Add(this.quitButton);
            this.skinPanel1.Controls.Add(this.signinButton);
            this.skinPanel1.Controls.Add(this.activateCodeTextBox);
            this.skinPanel1.Controls.Add(this.passwordTextBox);
            this.skinPanel1.Controls.Add(this.usernameTextBox);
            this.skinPanel1.Controls.Add(this.activateCodeLabel);
            this.skinPanel1.Controls.Add(this.passwordLabel);
            this.skinPanel1.Controls.Add(this.usernameLabel);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(1, 42);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(492, 374);
            this.skinPanel1.TabIndex = 0;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.BorderColor = System.Drawing.Color.White;
            this.usernameLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(54, 26);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(101, 24);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.BorderColor = System.Drawing.Color.White;
            this.passwordLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(54, 68);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(97, 24);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password:";
            // 
            // activateCodeLabel
            // 
            this.activateCodeLabel.AutoSize = true;
            this.activateCodeLabel.BackColor = System.Drawing.Color.Transparent;
            this.activateCodeLabel.BorderColor = System.Drawing.Color.White;
            this.activateCodeLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activateCodeLabel.Location = new System.Drawing.Point(54, 109);
            this.activateCodeLabel.Name = "activateCodeLabel";
            this.activateCodeLabel.Size = new System.Drawing.Size(132, 24);
            this.activateCodeLabel.TabIndex = 3;
            this.activateCodeLabel.Text = "Activate Code:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.usernameTextBox.DownBack = null;
            this.usernameTextBox.Icon = null;
            this.usernameTextBox.IconIsButton = false;
            this.usernameTextBox.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.usernameTextBox.IsPasswordChat = '\0';
            this.usernameTextBox.IsSystemPasswordChar = false;
            this.usernameTextBox.Lines = new string[0];
            this.usernameTextBox.Location = new System.Drawing.Point(235, 26);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.usernameTextBox.MaxLength = 32767;
            this.usernameTextBox.MinimumSize = new System.Drawing.Size(28, 28);
            this.usernameTextBox.MouseBack = null;
            this.usernameTextBox.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.usernameTextBox.Multiline = false;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.NormlBack = null;
            this.usernameTextBox.Padding = new System.Windows.Forms.Padding(5);
            this.usernameTextBox.ReadOnly = false;
            this.usernameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.usernameTextBox.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.usernameTextBox.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTextBox.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameTextBox.SkinTxt.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.usernameTextBox.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.usernameTextBox.SkinTxt.Name = "BaseText";
            this.usernameTextBox.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.usernameTextBox.SkinTxt.TabIndex = 0;
            this.usernameTextBox.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.usernameTextBox.SkinTxt.WaterText = "";
            this.usernameTextBox.TabIndex = 4;
            this.usernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.usernameTextBox.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.usernameTextBox.WaterText = "";
            this.usernameTextBox.WordWrap = true;
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
            this.passwordTextBox.Location = new System.Drawing.Point(235, 68);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.passwordTextBox.MaxLength = 32767;
            this.passwordTextBox.MinimumSize = new System.Drawing.Size(28, 28);
            this.passwordTextBox.MouseBack = null;
            this.passwordTextBox.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.passwordTextBox.Multiline = false;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.NormlBack = null;
            this.passwordTextBox.Padding = new System.Windows.Forms.Padding(5);
            this.passwordTextBox.ReadOnly = false;
            this.passwordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordTextBox.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.passwordTextBox.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordTextBox.SkinTxt.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.passwordTextBox.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.passwordTextBox.SkinTxt.Name = "BaseText";
            this.passwordTextBox.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.passwordTextBox.SkinTxt.TabIndex = 0;
            this.passwordTextBox.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.passwordTextBox.SkinTxt.WaterText = "";
            this.passwordTextBox.TabIndex = 5;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordTextBox.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.passwordTextBox.WaterText = "";
            this.passwordTextBox.WordWrap = true;
            // 
            // activateCodeTextBox
            // 
            this.activateCodeTextBox.BackColor = System.Drawing.Color.Transparent;
            this.activateCodeTextBox.DownBack = null;
            this.activateCodeTextBox.Icon = null;
            this.activateCodeTextBox.IconIsButton = false;
            this.activateCodeTextBox.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.activateCodeTextBox.IsPasswordChat = '\0';
            this.activateCodeTextBox.IsSystemPasswordChar = false;
            this.activateCodeTextBox.Lines = new string[0];
            this.activateCodeTextBox.Location = new System.Drawing.Point(235, 109);
            this.activateCodeTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.activateCodeTextBox.MaxLength = 32767;
            this.activateCodeTextBox.MinimumSize = new System.Drawing.Size(28, 28);
            this.activateCodeTextBox.MouseBack = null;
            this.activateCodeTextBox.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.activateCodeTextBox.Multiline = false;
            this.activateCodeTextBox.Name = "activateCodeTextBox";
            this.activateCodeTextBox.NormlBack = null;
            this.activateCodeTextBox.Padding = new System.Windows.Forms.Padding(5);
            this.activateCodeTextBox.ReadOnly = false;
            this.activateCodeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.activateCodeTextBox.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.activateCodeTextBox.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.activateCodeTextBox.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activateCodeTextBox.SkinTxt.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.activateCodeTextBox.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.activateCodeTextBox.SkinTxt.Name = "BaseText";
            this.activateCodeTextBox.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.activateCodeTextBox.SkinTxt.TabIndex = 0;
            this.activateCodeTextBox.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.activateCodeTextBox.SkinTxt.WaterText = "";
            this.activateCodeTextBox.TabIndex = 6;
            this.activateCodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.activateCodeTextBox.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.activateCodeTextBox.WaterText = "";
            this.activateCodeTextBox.WordWrap = true;
            // 
            // signinButton
            // 
            this.signinButton.BackColor = System.Drawing.Color.Transparent;
            this.signinButton.BaseColor = System.Drawing.Color.MistyRose;
            this.signinButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.signinButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.signinButton.DownBack = null;
            this.signinButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinButton.Location = new System.Drawing.Point(58, 267);
            this.signinButton.MouseBack = null;
            this.signinButton.Name = "signinButton";
            this.signinButton.NormlBack = null;
            this.signinButton.Radius = 15;
            this.signinButton.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.signinButton.Size = new System.Drawing.Size(97, 31);
            this.signinButton.TabIndex = 7;
            this.signinButton.Text = "Sign Up";
            this.signinButton.UseVisualStyleBackColor = false;
            this.signinButton.Click += new System.EventHandler(this.SigninButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.Transparent;
            this.quitButton.BaseColor = System.Drawing.Color.MistyRose;
            this.quitButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.quitButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.quitButton.DownBack = null;
            this.quitButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.Location = new System.Drawing.Point(323, 267);
            this.quitButton.MouseBack = null;
            this.quitButton.Name = "quitButton";
            this.quitButton.NormlBack = null;
            this.quitButton.Radius = 15;
            this.quitButton.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.quitButton.Size = new System.Drawing.Size(97, 31);
            this.quitButton.TabIndex = 8;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionBackColorBottom = System.Drawing.Color.Silver;
            this.CaptionBackColorTop = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(494, 419);
            this.Controls.Add(this.skinPanel1);
            this.Name = "SignUp";
            this.Text = "MATHBRICK";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinTextBox activateCodeTextBox;
        private CCWin.SkinControl.SkinTextBox passwordTextBox;
        private CCWin.SkinControl.SkinTextBox usernameTextBox;
        private CCWin.SkinControl.SkinLabel activateCodeLabel;
        private CCWin.SkinControl.SkinLabel passwordLabel;
        private CCWin.SkinControl.SkinLabel usernameLabel;
        private CCWin.SkinControl.SkinButton quitButton;
        private CCWin.SkinControl.SkinButton signinButton;
    }
}