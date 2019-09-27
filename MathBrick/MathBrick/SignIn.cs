using System;
using System.Windows.Forms;
using CCWin;

namespace MathBrick
{
    public partial class SignIn : Skin_Color
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

        private void UserNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void SkinButton1_Click(object sender, EventArgs e)
        {
            String userName = userNameTextBox.Text;
            String password = passwordTextBox.Text;

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

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            SignUp signUpPage = new SignUp();
            signUpPage.Show();
        }

        private void UserNameTextBox_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
