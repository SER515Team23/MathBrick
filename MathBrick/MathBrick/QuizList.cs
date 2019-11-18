using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using CCWin;
using MathBrick.Model;

/* 
 * Author: Yu-Ting Tsao, Xinkai Wang, Bingrui Feng
 * Description: Students can see and choose their suitable quizzes here.
*/

namespace MathBrick
{
    public partial class QuizList : Skin_Color
    {
        public static bool hasReturn = false;

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

        private void Btn_takeQuiz_Click(object sender, EventArgs e)
        {
            if (quizListView.SelectedItems[0].SubItems[5].Text.Equals(string.Empty))
            {
                timer_quiz.Enabled = true;
                foreach (ListViewItem lv in quizListView.SelectedItems)//take quiz button click
                {
                    QuizPage.isTakeQuiz = true;
                    QuizPage quizPage = new QuizPage(lv);
                    quizPage.Show();
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("You have already taken this quiz!", "Quiz Already Taken", MessageBoxButtons.OK);
            }           
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            timer_quiz.Enabled = true;
            QuizPage quizPage = new QuizPage();
            quizPage.Show();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lv in quizListView.SelectedItems)
            {
                QuizPage.isEdit = true;
                timer_quiz.Enabled = true;
                QuizPage quizPage = new QuizPage(lv);
                quizPage.Show();
            }
        }

        private void QuizList_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            nameLabel.Text = DataBase.Instance.activeUser.userName;
            levelLabel.Text = ChangeLevelToString(DataBase.Instance.activeUser.authorizeLevel);
            List<int> studentLevelList = new List<int>{ 1, 2, 3 };
            if (studentLevelList.Contains(DataBase.Instance.activeUser.authorizeLevel))
                HideAddEdit();
            else
                btn_takeQuiz.Hide();
            RefreshListview();
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

        private void HideAddEdit()
        {
            addButton.Hide();
            editButton.Hide();
            btn_delete.Hide();
        }

        private void Timer_quiz_Tick(object sender, EventArgs e)
        {
            if (hasReturn == true)
            {
                RefreshListview();
                timer_quiz.Enabled = false;
                hasReturn = false;
            }
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lv in quizListView.SelectedItems)
            {
                QuizUtils.Instance.DeleteAQuiz(lv.Tag.ToString());
            }
            RefreshListview();
        }

        private void QuizList_FormClosed(object sender, FormClosedEventArgs e)
        {
            hasReturn = false;
        }

        private void ShowQuiz()
        {
            User user = DataBase.Instance.activeUser; 
            int userLevel = DataBase.Instance.activeUser.authorizeLevel;
            Quiz[] Quizzes;
            if (userLevel == 4)
                Quizzes = QuizUtils.Instance.RetrieveQuizzes();
            else
                Quizzes = QuizUtils.Instance.RetrieveQuizzes(userLevel);
            foreach(Quiz quiz in Quizzes)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = "";
                lvi.SubItems.Add(quiz.date);
                lvi.SubItems.Add(quiz.subject);
                lvi.SubItems.Add(ChangeLevelToString(quiz.level));
                lvi.SubItems.Add(quiz.teacherID);
                if(quiz.studentGrades.TryGetValue(user.userName, out double grade))
                {
                    lvi.SubItems.Add(grade.ToString("P2", CultureInfo.InvariantCulture));
                }
                else
                {
                    lvi.SubItems.Add("");
                }
                lvi.Tag = quiz.uniqueID;
                quizListView.Items.Add(lvi);
            }
            reOrder();
        }

        private string ChangeLevelToString(int levelInt)
        {
            string levelString;
            switch(levelInt)
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
                    levelString = "Teacher";
                    break;
            }
            return levelString;
        }

        private void RefreshListview()
        {
            foreach (ListViewItem lv in quizListView.Items)
                lv.Remove();
            ShowQuiz();
            reOrder();
        }

        private void btn_viewgrade_Click(object sender, EventArgs e)
        {
            timer_quiz.Enabled = true;
            foreach (ListViewItem lv in quizListView.SelectedItems)
            {
               
                ViewGrade gradepage = new ViewGrade();
                gradepage.Show();
            }
        }
    }
}
