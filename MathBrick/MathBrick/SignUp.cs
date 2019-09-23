using System;
using System.Windows.Forms;

namespace MathBrick
{
    public partial class SignUp : Form
    {
        private String beginnerActivateCode = "0000";
        private String intermediateActivateCode = "6666";
        private String advancedActivateCode = "7777";

        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUpClick(object sender, EventArgs e)
        {
            String userName = this.usernameTextBox.Text;
            String password = this.passwordTextBox.Text;
            String activateCode = this.activateCodeTextBox.Text;

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
            MessageBox.Show("Success!", "Hint"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void QuitClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
