﻿using System;
using System.Windows.Forms;

namespace MathBrick
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        string defaultUserName = "123";
        string defaultPassword = "123";

        /*private void SignInClick(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == defaultUserName && passwordTextBox.Text == defaultPassword)
            {
                Main main = new Main();
                this.Hide();
                main.Show();
            }
            else
            {
                MessageBox.Show("Username or password error! Please try again.");
            }
        }

        private void SignUpClick(object sender, EventArgs e)
        {
            SignUp signUpPage = new SignUp();
            signUpPage.Show();
        }*/

        private void TestDataBase(object sender, EventArgs e)
        {
            bool hi = DataBase.Instance.IsOddNumber(101);
            Console.WriteLine("是否為一個奇數? 答案:" + hi);
        }

        private void SigninButton_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == defaultUserName && passwordTextBox.Text == defaultPassword)
            {
                Main1 main = new Main1();
                this.Hide();
                main.Show();
            }
            else
            {
                MessageBox.Show("Username or password error! Please try again.");
            }
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            SignUp signUpPage = new SignUp();
            signUpPage.Show();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }
    }
}
