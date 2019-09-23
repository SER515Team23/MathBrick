using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;

namespace MathBrick
{
    public partial class Signin1 : Skin_Color
    {
        public Signin1()
        {
            InitializeComponent();
        }
        string defaultUserName = "123";
        string defaultPassword = "123";
        private void SkinLabel1_Click(object sender, EventArgs e)
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

        private void SkinTextBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SkinButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
