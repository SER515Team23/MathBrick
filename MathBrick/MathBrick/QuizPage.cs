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
        public static string question = "";
        public static string answer = "";
        public static int hasReturn = 0;
        private ListViewItem editItem = null;
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
            

            timer_question.Enabled = true;
            Question newQues = new Question("", "", true);
            newQues.Show();
        }

        private void Timer_question_Tick(object sender, EventArgs e)
        {
            if (hasReturn == 1)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = "";
                lvi.SubItems.Add(question);
                lvi.SubItems.Add(answer);
                listView1.Items.Add(lvi);
                hasReturn = 0;
                reOrder();
                timer_question.Enabled = false;
            }
            else if (hasReturn == 2)
            {
                hasReturn = 0;
                reOrder();
                timer_question.Enabled = false;
            }
            else if (hasReturn == 3)
            {
                if(!listView1.Items.Contains(editItem))
                {
                    listView1.Items.Add(editItem);
                }
                editItem.SubItems[1].Text = question;
                editItem.SubItems[2].Text = answer;
                hasReturn = 0;
                reOrder();
                timer_question.Enabled = false;

            }
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lv in listView1.SelectedItems)
            {
                lv.Remove();
            }
            reOrder();
        }

        private void reOrder()
        {
            int order = 1;
            foreach (ListViewItem lv in listView1.Items)
            {
                lv.Text = order.ToString();
                order++;
            }
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            timer_question.Enabled = true;
            foreach (ListViewItem lv in listView1.SelectedItems)
            {
                editItem = lv;
                Question selectedQues = new Question(lv.SubItems[1].Text, lv.SubItems[2].Text, false);
                selectedQues.Show();
            }
        }
    }
}
