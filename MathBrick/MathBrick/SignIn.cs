﻿using System;
using System.Windows.Forms;
using CCWin;

namespace MathBrick
{
    public partial class SignIn : Skin_Color
    {
        public SignIn()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += PasswordTextBoxKeyDown;
        }

        string defaultUserName = "123";
        string defaultPassword = "123";

        private void SignInClick(object sender, EventArgs e)
        {
            string userName = userNameTextBox.Text;
            string password = passwordTextBox.Text;

            // This only exists during development stage.
            if (userName == defaultUserName && password == defaultPassword)
            {
                Main1 main = new Main1();
                this.Hide();
                main.Show();
            }
            else if (DataBase.Instance.UserLogin(userName, password))
            {
                Console.WriteLine("U R GOOD TO LOGIN!!!");
                Main1 main = new Main1();
                this.Hide();
                main.Show();
            }
            else
            {
                MessageBox.Show("Username or password error! Please try again.", "Oops"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SignUpClick(object sender, EventArgs e)
        {
            SignUp signUpPage = new SignUp();
            signUpPage.Show();
        }

        private void PasswordTextBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                signInButton.PerformClick();
            }
        }
    }
}
