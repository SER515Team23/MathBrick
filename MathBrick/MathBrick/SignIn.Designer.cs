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
            this.passwordLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordTextBox = new CCWin.SkinControl.SkinTextBox();
            this.userNameTextBox = new CCWin.SkinControl.SkinTextBox();
            this.signUpButton = new CCWin.SkinControl.SkinButton();
            this.signInButton = new CCWin.SkinControl.SkinButton();
            this.welcomePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomePanel
            // 
            this.welcomePanel.BackColor = System.Drawing.Color.SeaShell;
            this.welcomePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("welcomePanel.BackgroundImage")));
            this.welcomePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.welcomePanel.Controls.Add(this.passwordLabel);
            this.welcomePanel.Controls.Add(this.label1);
            this.welcomePanel.Controls.Add(this.passwordTextBox);
            this.welcomePanel.Controls.Add(this.userNameTextBox);
            this.welcomePanel.Controls.Add(this.signUpButton);
            this.welcomePanel.Controls.Add(this.signInButton);
            this.welcomePanel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.welcomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcomePanel.DownBack = null;
            this.welcomePanel.Location = new System.Drawing.Point(8, 39);
            this.welcomePanel.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.welcomePanel.MouseBack = null;
            this.welcomePanel.Name = "welcomePanel";
            this.welcomePanel.NormlBack = null;
            this.welcomePanel.Size = new System.Drawing.Size(684, 493);
            this.welcomePanel.TabIndex = 0;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.White;
            this.passwordLabel.Location = new System.Drawing.Point(121, 206);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(117, 26);
            this.passwordLabel.TabIndex = 14;
            this.passwordLabel.Text = "Password：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(121, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "Username：";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.Transparent;
            this.passwordTextBox.DownBack = null;
            this.passwordTextBox.Icon = null;
            this.passwordTextBox.IconIsButton = false;
            this.passwordTextBox.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.passwordTextBox.IsPasswordChat = '●';
            this.passwordTextBox.IsSystemPasswordChar = false;
            this.passwordTextBox.Lines = new string[0];
            this.passwordTextBox.Location = new System.Drawing.Point(260, 197);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.passwordTextBox.MaxLength = 32767;
            this.passwordTextBox.MinimumSize = new System.Drawing.Size(28, 28);
            this.passwordTextBox.MouseBack = null;
            this.passwordTextBox.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.passwordTextBox.Multiline = true;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.NormlBack = null;
            this.passwordTextBox.Padding = new System.Windows.Forms.Padding(5);
            this.passwordTextBox.ReadOnly = false;
            this.passwordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordTextBox.Size = new System.Drawing.Size(247, 35);
            // 
            // 
            // 
            this.passwordTextBox.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordTextBox.SkinTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.passwordTextBox.SkinTxt.Multiline = true;
            this.passwordTextBox.SkinTxt.Name = "BaseText";
            this.passwordTextBox.SkinTxt.PasswordChar = '●';
            this.passwordTextBox.SkinTxt.Size = new System.Drawing.Size(237, 25);
            this.passwordTextBox.SkinTxt.TabIndex = 0;
            this.passwordTextBox.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.passwordTextBox.SkinTxt.WaterText = "";
            this.passwordTextBox.TabIndex = 12;
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
            this.userNameTextBox.Location = new System.Drawing.Point(260, 130);
            this.userNameTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.userNameTextBox.MaxLength = 32767;
            this.userNameTextBox.MinimumSize = new System.Drawing.Size(28, 28);
            this.userNameTextBox.MouseBack = null;
            this.userNameTextBox.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.userNameTextBox.Multiline = true;
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.NormlBack = null;
            this.userNameTextBox.Padding = new System.Windows.Forms.Padding(5);
            this.userNameTextBox.ReadOnly = false;
            this.userNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userNameTextBox.Size = new System.Drawing.Size(247, 35);
            // 
            // 
            // 
            this.userNameTextBox.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userNameTextBox.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userNameTextBox.SkinTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.userNameTextBox.SkinTxt.Multiline = true;
            this.userNameTextBox.SkinTxt.Name = "BaseText";
            this.userNameTextBox.SkinTxt.Size = new System.Drawing.Size(237, 25);
            this.userNameTextBox.SkinTxt.TabIndex = 0;
            this.userNameTextBox.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.userNameTextBox.SkinTxt.WaterText = "";
            this.userNameTextBox.TabIndex = 11;
            this.userNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.userNameTextBox.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.userNameTextBox.WaterText = "";
            this.userNameTextBox.WordWrap = true;
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.Color.Transparent;
            this.signUpButton.BaseColor = System.Drawing.Color.Transparent;
            this.signUpButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.signUpButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.signUpButton.DownBack = null;
            this.signUpButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpButton.ForeColor = System.Drawing.Color.White;
            this.signUpButton.Location = new System.Drawing.Point(381, 303);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.signUpButton.MouseBack = null;
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.NormlBack = null;
            this.signUpButton.Radius = 15;
            this.signUpButton.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.signUpButton.Size = new System.Drawing.Size(119, 39);
            this.signUpButton.TabIndex = 6;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.SignUpClick);
            // 
            // signInButton
            // 
            this.signInButton.BackColor = System.Drawing.Color.Transparent;
            this.signInButton.BaseColor = System.Drawing.Color.Transparent;
            this.signInButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.signInButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.signInButton.DownBack = null;
            this.signInButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInButton.ForeColor = System.Drawing.Color.White;
            this.signInButton.Location = new System.Drawing.Point(126, 303);
            this.signInButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.signInButton.MouseBack = null;
            this.signInButton.Name = "signInButton";
            this.signInButton.NormlBack = null;
            this.signInButton.Radius = 15;
            this.signInButton.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.signInButton.Size = new System.Drawing.Size(119, 39);
            this.signInButton.TabIndex = 5;
            this.signInButton.Text = "Sign In";
            this.signInButton.UseVisualStyleBackColor = false;
            this.signInButton.Click += new System.EventHandler(this.SignInClick);
            // 
            // SignIn
            // 
            this.AcceptButton = this.signInButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionBackColorBottom = System.Drawing.Color.DarkOliveGreen;
            this.CaptionBackColorTop = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(700, 540);
            this.Controls.Add(this.welcomePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 8000);
            this.MinimumSize = new System.Drawing.Size(500, 100);
            this.Name = "SignIn";
            this.Text = "MathBrick";
            this.VisibleChanged += new System.EventHandler(this.SignIn_VisibleChanged);
            this.welcomePanel.ResumeLayout(false);
            this.welcomePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinPanel welcomePanel;
        private CCWin.SkinControl.SkinButton signUpButton;
        private CCWin.SkinControl.SkinButton signInButton;
        private CCWin.SkinControl.SkinTextBox passwordTextBox;
        private CCWin.SkinControl.SkinTextBox userNameTextBox;
        private Label passwordLabel;
        private Label label1;
    }
}

