﻿namespace MathBrick
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
            this.welcomePanel = new System.Windows.Forms.Panel();
            this.forgotPasswordLabel = new System.Windows.Forms.Label();
            this.signUpLabel = new System.Windows.Forms.Label();
            this.signUpButton = new System.Windows.Forms.Button();
            this.signInButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.welcomePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomePanel
            // 
            this.welcomePanel.BackColor = System.Drawing.Color.FloralWhite;
            this.welcomePanel.Controls.Add(this.forgotPasswordLabel);
            this.welcomePanel.Controls.Add(this.signUpLabel);
            this.welcomePanel.Controls.Add(this.signUpButton);
            this.welcomePanel.Controls.Add(this.signInButton);
            this.welcomePanel.Controls.Add(this.passwordTextBox);
            this.welcomePanel.Controls.Add(this.userNameTextBox);
            this.welcomePanel.Controls.Add(this.passwordLabel);
            this.welcomePanel.Controls.Add(this.userNameLabel);
            this.welcomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcomePanel.Location = new System.Drawing.Point(0, 0);
            this.welcomePanel.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.welcomePanel.Name = "welcomePanel";
            this.welcomePanel.Size = new System.Drawing.Size(1010, 580);
            this.welcomePanel.TabIndex = 0;
            // 
            // forgotPasswordLabel
            // 
            this.forgotPasswordLabel.AutoSize = true;
            this.forgotPasswordLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPasswordLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.forgotPasswordLabel.Location = new System.Drawing.Point(347, 500);
            this.forgotPasswordLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.forgotPasswordLabel.Name = "forgotPasswordLabel";
            this.forgotPasswordLabel.Size = new System.Drawing.Size(237, 39);
            this.forgotPasswordLabel.TabIndex = 7;
            this.forgotPasswordLabel.Text = "Forgot Password";
            // 
            // signUpLabel
            // 
            this.signUpLabel.Location = new System.Drawing.Point(0, 0);
            this.signUpLabel.Name = "signUpLabel";
            this.signUpLabel.Size = new System.Drawing.Size(100, 23);
            this.signUpLabel.TabIndex = 8;
            // 
            // signUpButton
            // 
            this.signUpButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.signUpButton.Location = new System.Drawing.Point(142, 380);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(674, 78);
            this.signUpButton.TabIndex = 5;
            this.signUpButton.Text = "Sign Up Free";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.SignUpClick);
            // 
            // signInButton
            // 
            this.signInButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.signInButton.Location = new System.Drawing.Point(142, 263);
            this.signInButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(674, 78);
            this.signInButton.TabIndex = 4;
            this.signInButton.Text = "Sign In";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.SignInClick);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.passwordTextBox.Location = new System.Drawing.Point(354, 160);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(462, 51);
            this.passwordTextBox.TabIndex = 3;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userNameTextBox.Location = new System.Drawing.Point(354, 76);
            this.userNameTextBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(462, 51);
            this.userNameTextBox.TabIndex = 2;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(134, 160);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(178, 45);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password:";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(134, 76);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(188, 45);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "Username:";
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 580);
            this.Controls.Add(this.welcomePanel);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MATHBRICK";
            this.welcomePanel.ResumeLayout(false);
            this.welcomePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel welcomePanel;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label forgotPasswordLabel;
        private System.Windows.Forms.Label signUpLabel;
    }
}

