﻿using System;
using System.Windows.Forms;
using CCWin;

/* 
 * Author: Liang Huijing, Yu-Ting Tsao
 * Description: Entry page for users. Need to sign up or sign in first.
*/

namespace MathBrick
{
    public partial class SignIn : Skin_Color
    {
        public SignIn()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += PasswordTextBoxKeyDown;

            // -----------------------EXAMPLE-----------------------

            // QuizUtils.Instance.ShowExampleForThisClass();

            // -----------------------EXAMPLE-----------------------
        }

        private void SignInClick(object sender, EventArgs e)
        {
            string userName = userNameTextBox.Text;
            string password = passwordTextBox.Text;

            // ------------- This only exists during development stage. -------------
            if (userName == "t01" && password == "123")
            {
                User teacher = new User { userName = userName, password = password, authorizeLevel = 4, isLogin = true };
                DataBase.Instance.activeUser = teacher;
                HomePage main = new HomePage(this);
                this.Hide();
                main.Show();
            } else if (userName == "b01" && password == "123")
            {
                User beginner = new User { userName = userName, password = password, authorizeLevel = 1, isLogin = true };
                DataBase.Instance.activeUser = beginner;
                HomePage main = new HomePage(this);
                this.Hide();
                main.Show();
            }
            else if (userName == "i01" && password == "123")
            {
                User intermediate = new User { userName = userName, password = password, authorizeLevel = 2, isLogin = true };
                DataBase.Instance.activeUser = intermediate;
                HomePage main = new HomePage(this);
                this.Hide();
                main.Show();
            }
            else if (userName == "a01" && password == "123")
            {
                User advanced = new User { userName = userName, password = password, authorizeLevel = 3, isLogin = true };
                DataBase.Instance.activeUser = advanced;
                HomePage main = new HomePage(this);
                this.Hide();
                main.Show();
            }
            else if (userName == "admin" && password == "admin")
            {
                User admin = new User { userName = userName, password = password, authorizeLevel = 5, isLogin = true };
                DataBase.Instance.activeUser = admin;
                HomePage main = new HomePage(this);
                this.Hide();
                main.Show();
            }
            // ------------- This only exists during development stage. -------------
            else if (DataBase.Instance.UserLogin(userName, password))
            {
                HomePage main = new HomePage(this);
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

        private void SignIn_VisibleChanged(object sender, EventArgs e)
        {
            userNameTextBox.Text = "";
            passwordTextBox.Text = "";
        }
    }
}
