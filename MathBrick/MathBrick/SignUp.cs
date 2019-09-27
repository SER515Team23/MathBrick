﻿using System;
using System.Windows.Forms;
using CCWin;

namespace MathBrick
{
    public partial class SignUp : Skin_Color
    {
        private string beginnerActivateCode = "0000";
        private string intermediateActivateCode = "6666";
        private string advancedActivateCode = "7777";

        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUpClick(object sender, EventArgs e)
        {
            string userName = this.usernameTextBox.Text;
            string password = this.passwordTextBox.Text;
            string activateCode = this.activateCodeTextBox.Text;

            if (string.IsNullOrEmpty(userName) 
                || string.IsNullOrEmpty(password)
                || string.IsNullOrEmpty(activateCode))
            {
                MessageBox.Show("Some fields are missing. Check again.", "Oops!"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (activateCode == beginnerActivateCode)
            {
                User beginner = new User { userName = userName, password = password, authorizeLevel = 1, isLogin = false };
                this.AddUser(beginner);
            }
            else if (activateCode == intermediateActivateCode)
            {
                User intermediate = new User { userName = userName, password = password, authorizeLevel = 2, isLogin = false };
                this.AddUser(intermediate);
            }
            else if (activateCode == advancedActivateCode)
            {
                User advanced = new User { userName = userName, password = password, authorizeLevel = 3, isLogin = false };
                this.AddUser(advanced);
            }
            else
            {
                MessageBox.Show("Invalid activate code.", "Oops!"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AddUser(User user)
        {
            DataBase.Instance.WriteInDataBase(user);
            DialogResult result = MessageBox.Show("Success!", "Hint"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void QuitClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void SigninButton_Click(object sender, EventArgs e)
        {
            string userName = this.usernameTextBox.Text;
            string password = this.passwordTextBox.Text;
            string activateCode = this.activateCodeTextBox.Text;

            if (string.IsNullOrEmpty(userName)
                || string.IsNullOrEmpty(password)
                || string.IsNullOrEmpty(activateCode))
            {
                MessageBox.Show("Some fields are missing. Check again.", "Oops!"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (activateCode == beginnerActivateCode)
            {
                User beginner = new User { userName = userName, password = password, authorizeLevel = 1, isLogin = false };
                this.AddUser(beginner);
            }
            else if (activateCode == intermediateActivateCode)
            {
                User intermediate = new User { userName = userName, password = password, authorizeLevel = 2, isLogin = false };
                this.AddUser(intermediate);
            }
            else if (activateCode == advancedActivateCode)
            {
                User advanced = new User { userName = userName, password = password, authorizeLevel = 3, isLogin = false };
                this.AddUser(advanced);
            }
            else
            {
                MessageBox.Show("Invalid activate code.", "Oops!"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
