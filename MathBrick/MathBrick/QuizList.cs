using System;
using System.Collections.Generic;
using System.Windows.Forms;

/* 
 * Author: Yu-Ting Tsao
 * Description: Students can see and choose their suitable quizzes here.
*/

namespace MathBrick
{
    public partial class QuizList : Form
    {
        List<QuizListClass> mockQuizList = new List<QuizListClass>()
        {
            new QuizListClass(){ Id = 1, Level = 1, CreatedDate = new DateTime(2019, 10, 31), Title="Quiz 1", AssignedBy = "t01", Description ="This is for beginner mock quiz 1", DueDate = new DateTime(2019, 11, 11)},
            new QuizListClass(){ Id = 2, Level = 1, CreatedDate = new DateTime(2019, 10, 29), Title="Quiz 2", AssignedBy = "t01", Description ="This is for beginner mock quiz 2", DueDate = new DateTime(2019, 11, 13)},
            new QuizListClass(){ Id = 3, Level = 1, CreatedDate = new DateTime(2019, 11, 01), Title="Quiz 3", AssignedBy = "t01", Description ="This is for beginner mock quiz 3", DueDate = new DateTime(2019, 11, 15)},
            new QuizListClass(){ Id = 4, Level = 2, CreatedDate = new DateTime(2019, 10, 31), Title="Quiz 1", AssignedBy = "t01", Description ="This is for intermediate mock quiz 1", DueDate = new DateTime(2019, 11, 11)},
            new QuizListClass(){ Id = 5, Level = 2, CreatedDate = new DateTime(2019, 10, 29), Title="Quiz 2", AssignedBy = "t01", Description ="This is for intermediate mock quiz 2", DueDate = new DateTime(2019, 11, 13)},
            new QuizListClass(){ Id = 6, Level = 2, CreatedDate = new DateTime(2019, 11, 01), Title="Quiz 3", AssignedBy = "t01", Description ="This is for intermediate mock quiz 3", DueDate = new DateTime(2019, 11, 15)},
            new QuizListClass(){ Id = 7, Level = 3, CreatedDate = new DateTime(2019, 10, 31), Title="Quiz 1", AssignedBy = "t01", Description ="This is for advance mock quiz 1", DueDate = new DateTime(2019, 11, 11)},
            new QuizListClass(){ Id = 8, Level = 3, CreatedDate = new DateTime(2019, 10, 29), Title="Quiz 2", AssignedBy = "t01", Description ="This is for advance mock quiz 2", DueDate = new DateTime(2019, 11, 13)},
            new QuizListClass(){ Id = 9, Level = 3, CreatedDate = new DateTime(2019, 11, 01), Title="Quiz 3", AssignedBy = "t01", Description ="This is for advance mock quiz 3", DueDate = new DateTime(2019, 11, 15)},
        };

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

        //private void CreateMyListView()
        //{
        //    quizListView.View = View.Details;
        //    quizListView.FullRowSelect = true;
        //    quizListView.Sorting = SortOrder.Ascending;

        //    for (int i = 0; i < date.Length; i++) {
        //        quizListView.Columns.Add(headerTitle[i], -2, HorizontalAlignment.Center);
        //        ListViewItem item = new ListViewItem(date[i], i);
        //        string numString = mockQuizNo[i].ToString();
        //        item.SubItems.Add(numString);
        //        item.SubItems.Add(teacherID[i]);
        //        item.SubItems.Add(subject[i]);
        //        quizListView.Items.Add(item);
        //    }
        //    this.Controls.Add(quizListView);
        //}

        private void ConfirmButton_Click(object sender, System.EventArgs e)
        {
            ListView.SelectedListViewItemCollection quizInfo =
                this.quizListView.SelectedItems;

            foreach (ListViewItem item in quizInfo)
            {
                Console.WriteLine("Chosen: " + item.SubItems[3].Text);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
