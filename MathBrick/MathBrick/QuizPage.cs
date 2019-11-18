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
using MathBrick.Model;


/* 
 * Author: Xinkai Wang
 * Description: Use to show the quiz detail and could also used by teacher to create new quiz or edit old quiz.
*/

namespace MathBrick
{
    public partial class QuizPage : Skin_Color
    {
        public static string question = "";
        public static string answer = "";
        public static string returnType = "";
        public static bool isEdit = false;
        public static bool isTakeQuiz = false;
        private ListViewItem editItem = null;

        private Quiz quiz = null;

        public QuizPage()
        {
            InitializeComponent();
        }

        public QuizPage(ListViewItem lv)
        {
            InitializeComponent();
            quiz = QuizUtils.Instance.RetrieveOneQuiz(lv.Tag.ToString());
        }

        private void QuizPage_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            if (quiz != null)
            {
                dateTimePicker_dueDate.Text = quiz.date;
                comboBox_level.Text = ChangeLevelToString(quiz.level);
                textBox_subject.Text = quiz.subject;
                foreach (Question q in quiz.questions)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = "";
                    lvi.SubItems.Add(q.title);
                    lvi.SubItems.Add(q.answer);
                    listView1.Items.Add(lvi);
                    returnType = "";
                }
                reOrder();
            }
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
            //btn_edit.Hide();
            loadMockData();
        }

        private void loadMockData()
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = "";
            lvi.SubItems.Add("2+3");
            lvi.SubItems.Add("5");
            listView1.Items.Add(lvi);
            ListViewItem lvi1 = new ListViewItem();
            lvi1.Text = "";
            lvi1.SubItems.Add("4+5");
            lvi1.SubItems.Add("9");
            listView1.Items.Add(lvi1);
            ListViewItem lvi2 = new ListViewItem();
            lvi2.Text = "";
            lvi2.SubItems.Add("12-5");
            lvi2.SubItems.Add("7");
            listView1.Items.Add(lvi2);
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            QuizList.hasReturn= true;
            Close();
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            if(CheckValid())
            {
                SaveQuizToDatabase();
                QuizList.hasReturn = true; 
                Close();
            }
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            timer_question.Enabled = true;
            QuestionPopUp newQues = new QuestionPopUp("", "", true);
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
                QuestionPopUp selectedQues = new QuestionPopUp(lv.SubItems[1].Text, lv.SubItems[2].Text, false);
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
            isEdit = false;
        }

        private void SaveQuizToDatabase()
        {
            List<Question> questionsList = new List<Question>();
            foreach (ListViewItem lv in listView1.Items)
            {
                Question ques = new Question(lv.SubItems[1].Text, lv.SubItems[2].Text);
                questionsList.Add(ques);
            }
            Quiz quiz = new Quiz(textBox_subject.Text, ChangeLevelToInt(comboBox_level.Text), dateTimePicker_dueDate.Text, DataBase.Instance.activeUser.userName, questionsList.ToArray());
            QuizUtils.Instance.StoreQuiz(quiz);
        }

        private int ChangeLevelToInt(string levelString)
        {
            int levelInt;
            switch(levelString)
            {
                case "Beginner":
                    levelInt = 1;
                    break;
                case "Intermediate":
                    levelInt = 2;
                    break;
                case "Advanced":
                    levelInt = 3;
                    break;
                default:
                    levelInt = -1;
                    break;
            }
            return levelInt;
        }

        private string ChangeLevelToString(int levelInt)
        {
            string levelString;
            switch (levelInt)
            {
                case 1:
                    levelString = "Beginner";
                    break;
                case 2:
                    levelString = "Intermediate";
                    break;
                case 3:
                    levelString = "Advanced";
                    break;
                default:
                    levelString = "Error";
                    break;
            }
            return levelString;
        }
    }
}
