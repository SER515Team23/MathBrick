﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathBrick
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        string Init_username = "123";
        string Init_password = "123";

        private void Button_signIn_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == Init_username && passwordTextBox.Text == Init_password)
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

        private void Label_signUp_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();
            signup.Show();
        }
    }
}
