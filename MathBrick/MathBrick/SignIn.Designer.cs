﻿using System.Windows.Forms;

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
            this.userNameTextBox = new CCWin.SkinControl.SkinTextBox();
            this.passwordTextBox = new CCWin.SkinControl.SkinTextBox();
            this.signInButton = new CCWin.SkinControl.SkinButton();
            this.signUpButton = new CCWin.SkinControl.SkinButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.welcomePanel = new CCWin.SkinControl.SkinPanel();
            this.welcomePanel.SuspendLayout();
            this.SuspendLayout();
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
            this.userNameTextBox.Location = new System.Drawing.Point(351, 99);
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
            this.userNameTextBox.Size = new System.Drawing.Size(234, 35);
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
            this.userNameTextBox.SkinTxt.Size = new System.Drawing.Size(212, 15);
            this.userNameTextBox.SkinTxt.TabIndex = 0;
            this.userNameTextBox.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.userNameTextBox.SkinTxt.WaterText = "";
            this.userNameTextBox.TabIndex = 3;
            this.userNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.userNameTextBox.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.userNameTextBox.WaterText = "";
            this.userNameTextBox.WordWrap = true;
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
            this.passwordTextBox.Location = new System.Drawing.Point(351, 162);
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
            this.passwordTextBox.Size = new System.Drawing.Size(234, 35);
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
            this.passwordTextBox.SkinTxt.Size = new System.Drawing.Size(212, 15);
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
            // signInButton
            // 
            this.signInButton.BackColor = System.Drawing.Color.Transparent;
            this.signInButton.BaseColor = System.Drawing.Color.Transparent;
            this.signInButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.signInButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.signInButton.DownBack = null;
            this.signInButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.signInButton.GlowColor = System.Drawing.Color.Wheat;
            this.signInButton.Location = new System.Drawing.Point(212, 263);
            this.signInButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.signInButton.MouseBack = null;
            this.signInButton.Name = "signInButton";
            this.signInButton.NormlBack = null;
            this.signInButton.Radius = 15;
            this.signInButton.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.signInButton.Size = new System.Drawing.Size(125, 39);
            this.signInButton.TabIndex = 5;
            this.signInButton.Text = "Sign In";
            this.signInButton.UseVisualStyleBackColor = false;
            this.signInButton.Click += new System.EventHandler(this.SignInClick);
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.Color.Transparent;
            this.signUpButton.BaseColor = System.Drawing.Color.Transparent;
            this.signUpButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.signUpButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.signUpButton.DownBack = null;
            this.signUpButton.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpButton.ForeColor = System.Drawing.Color.White;
            this.signUpButton.Location = new System.Drawing.Point(460, 263);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.signUpButton.MouseBack = null;
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.NormlBack = null;
            this.signUpButton.Radius = 15;
            this.signUpButton.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.signUpButton.Size = new System.Drawing.Size(125, 39);
            this.signUpButton.TabIndex = 6;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.SignUpClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(207, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Username：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(207, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password：";
            // 
            // welcomePanel
            // 
            this.welcomePanel.BackColor = System.Drawing.Color.Transparent;
            this.welcomePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("welcomePanel.BackgroundImage")));
            this.welcomePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.welcomePanel.Controls.Add(this.label2);
            this.welcomePanel.Controls.Add(this.label1);
            this.welcomePanel.Controls.Add(this.signUpButton);
            this.welcomePanel.Controls.Add(this.signInButton);
            this.welcomePanel.Controls.Add(this.passwordTextBox);
            this.welcomePanel.Controls.Add(this.userNameTextBox);
            this.welcomePanel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.welcomePanel.DownBack = null;
            this.welcomePanel.Location = new System.Drawing.Point(4, 39);
            this.welcomePanel.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.welcomePanel.MouseBack = null;
            this.welcomePanel.Name = "welcomePanel";
            this.welcomePanel.NormlBack = null;
            this.welcomePanel.Size = new System.Drawing.Size(831, 505);
            this.welcomePanel.TabIndex = 0;
            // 
            // SignIn
            // 
            this.AcceptButton = this.signInButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionBackColorBottom = System.Drawing.Color.DarkOliveGreen;
            this.CaptionBackColorTop = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(838, 546);
            this.Controls.Add(this.welcomePanel);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(60000, 80000);
            this.MinimumSize = new System.Drawing.Size(500, 100);
            this.Name = "SignIn";
            this.Text = "MathBrick";
            this.welcomePanel.ResumeLayout(false);
            this.welcomePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinTextBox userNameTextBox;
        private CCWin.SkinControl.SkinTextBox passwordTextBox;
        private CCWin.SkinControl.SkinButton signInButton;
        private CCWin.SkinControl.SkinButton signUpButton;
        private Label label1;
        private Label label2;
        private CCWin.SkinControl.SkinPanel welcomePanel;
    }
}

