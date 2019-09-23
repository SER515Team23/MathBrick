using System;
using System.Windows.Forms;

namespace MathBrick
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Quit？", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                Dispose();
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.ClickToDuplicate(this.button1.Text);
        }

        private void ClickToDuplicate(string text)
        {
            Button btn = new Button();
            this.tabPage1.Controls.Add(btn);
            btn.Location = new System.Drawing.Point(100, 100);
            btn.Size = new System.Drawing.Size(61, 62);
            btn.Text = text;
            btn.UseVisualStyleBackColor = true;
        }

        private void GradeButton_Click(object sender, EventArgs e)
        {
            Grade grade = new Grade();
            grade.Show();
        }
    }
}
