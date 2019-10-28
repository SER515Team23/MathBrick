using System.Windows.Forms;

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
            this.welcomePanel = new CCWin.SkinControl.SkinPanel();
            this.fooLabel = new System.Windows.Forms.Label();
            this.fogetPasswordButton = new CCWin.SkinControl.SkinButton();
            this.signUpButton = new CCWin.SkinControl.SkinButton();
            this.signInButton = new CCWin.SkinControl.SkinButton();
            this.passwordTextBox = new CCWin.SkinControl.SkinTextBox();
            this.userNameTextBox = new CCWin.SkinControl.SkinTextBox();
            this.passwordLabel = new CCWin.SkinControl.SkinLabel();
            this.userNameLabel = new CCWin.SkinControl.SkinLabel();
            this.welcomePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomePanel
            // 
            this.welcomePanel.BackColor = System.Drawing.Color.PeachPuff;
            this.welcomePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("welcomePanel.BackgroundImage")));
            this.welcomePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.welcomePanel.Controls.Add(this.fooLabel);
            this.welcomePanel.Controls.Add(this.fogetPasswordButton);
            this.welcomePanel.Controls.Add(this.signUpButton);
            this.welcomePanel.Controls.Add(this.signInButton);
            this.welcomePanel.Controls.Add(this.passwordTextBox);
            this.welcomePanel.Controls.Add(this.userNameTextBox);
            this.welcomePanel.Controls.Add(this.passwordLabel);
            this.welcomePanel.Controls.Add(this.userNameLabel);
            this.welcomePanel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.welcomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcomePanel.DownBack = null;
            this.welcomePanel.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomePanel.Location = new System.Drawing.Point(8, 39);
            this.welcomePanel.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.welcomePanel.MouseBack = null;
            this.welcomePanel.Name = "welcomePanel";
            this.welcomePanel.NormlBack = null;
            this.welcomePanel.Size = new System.Drawing.Size(570, 363);
            this.welcomePanel.TabIndex = 0;
            // 
            // fooLabel
            // 
            this.fooLabel.AutoSize = true;
            this.fooLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fooLabel.Location = new System.Drawing.Point(17, 269);
            this.fooLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.fooLabel.Name = "fooLabel";
            this.fooLabel.Size = new System.Drawing.Size(192, 80);
            this.fooLabel.TabIndex = 8;
            this.fooLabel.Text = "Teacher: t01 pwd: 123\nBeginner: b01 pwd:123\nIntermediate: i01 pwd:123\nAdvanced:a0" +
    "1 pwd:123";
            // 
            // fogetPasswordButton
            // 
            this.fogetPasswordButton.BackColor = System.Drawing.Color.Transparent;
            this.fogetPasswordButton.BaseColor = System.Drawing.Color.Transparent;
            this.fogetPasswordButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fogetPasswordButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.fogetPasswordButton.DownBack = null;
            this.fogetPasswordButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fogetPasswordButton.Location = new System.Drawing.Point(338, 544);
            this.fogetPasswordButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.fogetPasswordButton.MouseBack = null;
            this.fogetPasswordButton.Name = "fogetPasswordButton";
            this.fogetPasswordButton.NormlBack = null;
            this.fogetPasswordButton.Radius = 15;
            this.fogetPasswordButton.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.fogetPasswordButton.Size = new System.Drawing.Size(327, 62);
            this.fogetPasswordButton.TabIndex = 7;
            this.fogetPasswordButton.Text = "Forgot Password";
            this.fogetPasswordButton.UseVisualStyleBackColor = false;
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.Color.Transparent;
            this.signUpButton.BaseColor = System.Drawing.Color.MistyRose;
            this.signUpButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.signUpButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.signUpButton.DownBack = null;
            this.signUpButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpButton.Location = new System.Drawing.Point(354, 214);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.signUpButton.MouseBack = null;
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.NormlBack = null;
            this.signUpButton.Radius = 15;
            this.signUpButton.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.signUpButton.Size = new System.Drawing.Size(104, 37);
            this.signUpButton.TabIndex = 6;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.SignUpClick);
            // 
            // signInButton
            // 
            this.signInButton.BackColor = System.Drawing.Color.Transparent;
            this.signInButton.BaseColor = System.Drawing.Color.MistyRose;
            this.signInButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.signInButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.signInButton.DownBack = null;
            this.signInButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInButton.Location = new System.Drawing.Point(105, 214);
            this.signInButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.signInButton.MouseBack = null;
            this.signInButton.Name = "signInButton";
            this.signInButton.NormlBack = null;
            this.signInButton.Radius = 15;
            this.signInButton.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.signInButton.Size = new System.Drawing.Size(104, 37);
            this.signInButton.TabIndex = 5;
            this.signInButton.Text = "Sign In";
            this.signInButton.UseVisualStyleBackColor = false;
            this.signInButton.Click += new System.EventHandler(this.SignInClick);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.Transparent;
            this.passwordTextBox.DownBack = null;
            this.passwordTextBox.Icon = null;
            this.passwordTextBox.IconIsButton = false;
            this.passwordTextBox.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.passwordTextBox.IsPasswordChat = '\0';
            this.passwordTextBox.IsSystemPasswordChar = true;
            this.passwordTextBox.Lines = new string[0];
            this.passwordTextBox.Location = new System.Drawing.Point(276, 83);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.passwordTextBox.MaxLength = 5;
            this.passwordTextBox.MinimumSize = new System.Drawing.Size(61, 35);
            this.passwordTextBox.MouseBack = null;
            this.passwordTextBox.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.passwordTextBox.Multiline = true;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.NormlBack = null;
            this.passwordTextBox.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.passwordTextBox.ReadOnly = false;
            this.passwordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordTextBox.Size = new System.Drawing.Size(182, 35);
            // 
            // 
            // 
            this.passwordTextBox.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordTextBox.SkinTxt.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.passwordTextBox.SkinTxt.Location = new System.Drawing.Point(11, 10);
            this.passwordTextBox.SkinTxt.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.passwordTextBox.SkinTxt.MaxLength = 5;
            this.passwordTextBox.SkinTxt.Multiline = true;
            this.passwordTextBox.SkinTxt.Name = "BaseText";
            this.passwordTextBox.SkinTxt.Size = new System.Drawing.Size(160, 15);
            this.passwordTextBox.SkinTxt.TabIndex = 0;
            this.passwordTextBox.SkinTxt.UseSystemPasswordChar = true;
            this.passwordTextBox.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.passwordTextBox.SkinTxt.WaterText = "";
            this.passwordTextBox.TabIndex = 4;
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
            this.userNameTextBox.Location = new System.Drawing.Point(276, 39);
            this.userNameTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.userNameTextBox.MaxLength = 32767;
            this.userNameTextBox.MinimumSize = new System.Drawing.Size(61, 35);
            this.userNameTextBox.MouseBack = null;
            this.userNameTextBox.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.userNameTextBox.Multiline = true;
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.NormlBack = null;
            this.userNameTextBox.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.userNameTextBox.ReadOnly = false;
            this.userNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userNameTextBox.Size = new System.Drawing.Size(182, 35);
            // 
            // 
            // 
            this.userNameTextBox.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userNameTextBox.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userNameTextBox.SkinTxt.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.userNameTextBox.SkinTxt.Location = new System.Drawing.Point(11, 10);
            this.userNameTextBox.SkinTxt.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.userNameTextBox.SkinTxt.Multiline = true;
            this.userNameTextBox.SkinTxt.Name = "BaseText";
            this.userNameTextBox.SkinTxt.Size = new System.Drawing.Size(160, 15);
            this.userNameTextBox.SkinTxt.TabIndex = 0;
            this.userNameTextBox.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.userNameTextBox.SkinTxt.WaterText = "";
            this.userNameTextBox.TabIndex = 3;
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
            this.passwordLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(133, 94);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(102, 24);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password :";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.userNameLabel.BorderColor = System.Drawing.Color.White;
            this.userNameLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(133, 39);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(101, 24);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "Username:";
            // 
            // SignIn
            // 
            this.AcceptButton = this.signInButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionBackColorBottom = System.Drawing.Color.Silver;
            this.CaptionBackColorTop = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(586, 410);
            this.Controls.Add(this.welcomePanel);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "SignIn";
            this.Text = "MathBrick";
            this.welcomePanel.ResumeLayout(false);
            this.welcomePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinPanel welcomePanel;
        private CCWin.SkinControl.SkinTextBox userNameTextBox;
        private CCWin.SkinControl.SkinLabel passwordLabel;
        private CCWin.SkinControl.SkinLabel userNameLabel;
        private CCWin.SkinControl.SkinTextBox passwordTextBox;
        private CCWin.SkinControl.SkinButton fogetPasswordButton;
        private CCWin.SkinControl.SkinButton signUpButton;
        private CCWin.SkinControl.SkinButton signInButton;
        private Label fooLabel;
    }
}

