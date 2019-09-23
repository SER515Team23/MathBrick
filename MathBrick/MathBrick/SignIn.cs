using System;
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

        private void SignInClick(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == defaultUserName && passwordTextBox.Text == defaultPassword)
            {
                Main main = new Main();
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
    }
}
