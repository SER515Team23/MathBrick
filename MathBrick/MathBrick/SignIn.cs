using System;
using System.Windows.Forms;
using CCWin;

namespace MathBrick
{
    public partial class SignIn : Skin_Color
    {
        public static string nameToMain = null;
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
                HomePage main = new HomePage();
                this.Hide();
                main.Show();
            }
            else if (DataBase.Instance.UserLogin(userName, password))
            {
                HomePage main = new HomePage();
                User nowUser = DataBase.Instance.activeUser;
                switch (nowUser.authorizeLevel) {
                    case 1:
                        Console.Out.WriteLine("Login as: " + "初階學生");
                        break;
                    case 2:
                        Console.Out.WriteLine("Login as: " + "中階學生");
                        break;
                    case 3:
                        Console.Out.WriteLine("Login as: " + "高階學生");
                        break;
                    case 4:
                        Console.Out.WriteLine("Login as: " + "老師");
                        break;
                }
                nameToMain = userName;
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
