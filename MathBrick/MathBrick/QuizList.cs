using System;
using System.Collections.Generic;
using System.Windows.Forms;

/* 
 * Author: Yu-Ting Tsao, Xinkai Wang, Bingrui Feng
 * Description: Students can see and choose their suitable quizzes here.
*/

namespace MathBrick
{
    public partial class QuizList : Form
    {
        private string userID = "";
        private string userLevel = "";
        public static string dueDate = "";
        public static string subject = "";
        public static string level = "";
        public static string returnType = "";
        private ListViewItem editItem = null;

        public QuizList()
        {
            InitializeComponent();
            CreateMockQuizListView();
        }

        private void CreateMockQuizListView()
        {
            User currentUser = DataBase.Instance.activeUser;
            this.nameLabel.Text = currentUser.userName;
            int level = currentUser.authorizeLevel;
            this.levelLabel.Text = (level == 1 ? "Beginner" : level == 2? "Intermediate" : level == 3? "Advanced":"");
        }

        private void ConfirmButton_Click(object sender, System.EventArgs e)
        {
            foreach (ListViewItem lv in quizListView.SelectedItems)
            {
                QuizPage.isTakeQuiz = true;
                QuizPage quizPage = new QuizPage(lv.SubItems[1].Text, lv.SubItems[2].Text, lv.SubItems[3].Text, true);
                quizPage.Show();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            timer_quiz.Enabled = true;
            QuizPage quizPage = new QuizPage("", "", "", true);
            quizPage.Show();
        }

        private void QuizList_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            User nowUser = DataBase.Instance.activeUser;
            userID = nowUser.userName;
            switch (nowUser.authorizeLevel)
            {
                case -1:
                    break;
                case 1:
                    userLevel = "Beginner";
                    HideAddEdit();
                    break;
                case 2:
                    userLevel = "Intermediate";
                    HideAddEdit();
                    break;
                case 3:
                    userLevel = "Advanced";
                    HideAddEdit();
                    break;
                case 4:
                    userLevel = "Teacher";
                    break;
            }
            levelLabel.Text = userLevel;
        }

        private void reOrder()
        {
            int order = 1;
            foreach (ListViewItem lv in quizListView.Items)
            {
                lv.Text = order.ToString();
                order++;
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lv in quizListView.SelectedItems)
            {
                editItem = lv;
                timer_quiz.Enabled = true;
                QuizPage quizPage = new QuizPage(lv.SubItems[1].Text, lv.SubItems[2].Text, lv.SubItems[3].Text, false);
                quizPage.Show();
            }
        }

        private void HideAddEdit()
        {
            btn_cancel.Hide();
            btn_takeQuiz.Hide();
        }

        private void Timer_quiz_Tick(object sender, EventArgs e)
        {
            if (returnType == "add")
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = "";
                lvi.SubItems.Add(dueDate);
                lvi.SubItems.Add(subject);
                lvi.SubItems.Add(level);
                lvi.SubItems.Add(userID);
                quizListView.Items.Add(lvi);
                returnType = "";
                reOrder();
                timer_quiz.Enabled = false;
            }
            else if (returnType == "cancel")
            {
                returnType = "";
                reOrder();
                timer_quiz.Enabled = false;
            }
            else if (returnType == "edit")
            {
                if (!quizListView.Items.Contains(editItem))
                {
                    quizListView.Items.Add(editItem);
                }
                editItem.SubItems[1].Text = dueDate;
                editItem.SubItems[2].Text = subject;
                editItem.SubItems[3].Text = level;
                editItem.SubItems[4].Text = userID;
                returnType = "";
                reOrder();
                timer_quiz.Enabled = false;
            }
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lv in quizListView.SelectedItems)
            {
                lv.Remove();
            }
            reOrder();
        }

        private void QuizList_FormClosed(object sender, FormClosedEventArgs e)
        {
            dueDate = "";
            level = "";
            subject = "";
            returnType = "";
        }
    }

    public class QuizListClass
    {
        public int Id { get; set; }
        public int Level { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime DueDate { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public String AssignedBy { get; set; }
        public String Grade { get; set; }
    }
}
