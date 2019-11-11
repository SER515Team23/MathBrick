using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* 
 * Author: Xinkai Wang
 * Description: Use to show the quiz detail and could also used by teacher to create new quiz or edit old quiz.
*/

namespace MathBrick
{
    public partial class QuizPage : Form
    {
        public static string question = "";
        public static string answer = "";
        public static string returnType = "";
        public static bool isTakeQuiz = false;
        private bool isNew = true;
        private string dueDate = "";
        private string level = "";
        private string subjet = "";
        private ListViewItem editItem = null;

        public QuizPage(string inputDueDate, string inputSubject, string inputLevel, bool inputIsNew)
        {
            InitializeComponent();
            dueDate = inputDueDate;
            level = inputLevel;
            subjet = inputSubject;
            isNew = inputIsNew;
        }

        private void QuizPage_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            dateTimePicker_dueDate.Text = dueDate;
            comboBox_level.Text = level;
            textBox_subject.Text = subjet;
            if (isTakeQuiz)
                ChangeForTakeQuiz();
        }

        private void ChangeForTakeQuiz()
        {
            textBox_subject.Enabled = false;
            comboBox_level.Enabled = false;
            dateTimePicker_dueDate.Enabled = false;
            btn_add.Hide();
            btn_save.Hide();
            btn_delete.Hide();
            btn_edit.Hide();
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            QuizList.returnType = "cancel";
            Close();
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            if(CheckValid())
            {
                QuizList.dueDate = dateTimePicker_dueDate.Text;
                QuizList.subject = textBox_subject.Text;
                QuizList.level = comboBox_level.Text;
                if(isNew)
                    QuizList.returnType = "add";
                else
                    QuizList.returnType = "edit";
                Close();
            }
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            timer_question.Enabled = true;
            Question newQues = new Question("", "", true);
            newQues.Show();
        }

        private void Timer_question_Tick(object sender, EventArgs e)
        {
            if (returnType == "add")
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = "";
                lvi.SubItems.Add(question);
                lvi.SubItems.Add(answer);
                listView1.Items.Add(lvi);
                returnType = "";
                reOrder();
                timer_question.Enabled = false;
            }
            else if (returnType == "cancel")
            {
                returnType = "";
                reOrder();
                timer_question.Enabled = false;
            }
            else if (returnType == "edit")
            {
                if(!listView1.Items.Contains(editItem))
                {
                    listView1.Items.Add(editItem);
                }
                editItem.SubItems[1].Text = question;
                editItem.SubItems[2].Text = answer;
                returnType = "";
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

        private bool CheckValid()
        {
            if (comboBox_level.Text == "")
            {
                MessageBox.Show("Please select level.");
            }
            else if (textBox_subject.Text == "")
            {
                MessageBox.Show("Please enter subject.");
            }
            else
                return true;
            return false;
        }

        private void QuizPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            question = "";
            answer = "";
            returnType = "";
            isTakeQuiz = false;
        }
    }
}
