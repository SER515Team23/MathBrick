using System;
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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void Button_signup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
