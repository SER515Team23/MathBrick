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
            this.welcomePanel = new System.Windows.Forms.Panel();
            this.forgotPasswordButton = new System.Windows.Forms.Button();
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
            this.welcomePanel.Controls.Add(this.forgotPasswordButton);
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
            // forgotPasswordButton
            // 
            this.forgotPasswordButton.BackColor = System.Drawing.Color.Transparent;
            this.forgotPasswordButton.FlatAppearance.BorderSize = 0;
            this.forgotPasswordButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.forgotPasswordButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.forgotPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forgotPasswordButton.Font = new System.Drawing.Font("Calibri", 10F);
            this.forgotPasswordButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.forgotPasswordButton.Location = new System.Drawing.Point(236, 492);
            this.forgotPasswordButton.Name = "forgotPasswordButton";
            this.forgotPasswordButton.Size = new System.Drawing.Size(491, 49);
            this.forgotPasswordButton.TabIndex = 6;
            this.forgotPasswordButton.Text = "Forgot Password";
            this.forgotPasswordButton.UseVisualStyleBackColor = false;
            // 
            // signUpButton
            // 
            this.signUpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Linen;
            this.signUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.signInButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.signInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.passwordTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.passwordTextBox.Location = new System.Drawing.Point(354, 160);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(462, 51);
            this.passwordTextBox.TabIndex = 3;
            // The password character is an asterisk.
            this.passwordTextBox.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            this.passwordTextBox.MaxLength = 14;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
        private System.Windows.Forms.Button forgotPasswordButton;
    }
}

