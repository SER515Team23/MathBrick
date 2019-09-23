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

        String defaultUserName = "123";
        String defaultPassword = "123";

        private void SignInClick(object sender, EventArgs e)
        {
            String userName = userNameTextBox.Text;
            String password = passwordTextBox.Text;

            // This only exists during development stage.
            if (userName == defaultUserName && password == defaultPassword)
            {
                Main main = new Main();
                this.Hide();
                main.Show();
            }
            else if (DataBase.Instance.UserLogin(userName, password))
            {
                Console.WriteLine("U R GOOD TO LOGIN!!!");
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
