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
    public partial class QuizPage : Form
    {
        public QuizPage()
        {
            InitializeComponent();
        }

        private void QuizPage_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = "subitem";

            lvi.SubItems.Add("第2列,第行");

            lvi.SubItems.Add("第3列,第行");

            this.listView1.Items.Add(lvi);
        }
    }
}
