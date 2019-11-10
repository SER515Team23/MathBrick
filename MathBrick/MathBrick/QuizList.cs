using System;
using System.Windows.Forms;

/* 
 * Author: Yu-Ting Tsao
 * Description: Students can see and choose their suitable quizzes here.
*/

namespace MathBrick
{
    public partial class QuizList : Form
    {
        private string[] headerTitle = { "Date", "No.", "Teacher ID", "Subject"};
        private string[] date = { "8/3", "8/15", "9/1", "10/5"};
        private int[] mockQuizNo = { 0, 1, 3, 7};
        private string[] teacherID = {"hi9527", "zebra5566", "qoo996", "godlike777", "ai520" };
        private string[] subject = { "Addition knowledge check", "Substraction small quiz", "Linear equation test",
            "Midterm for intermediate", "Practice multiplication" };


        public QuizList()
        {
            InitializeComponent();
            CreateMyListView();
        }

        private void CreateMyListView()
        {
            quizListView.View = View.Details;
            quizListView.FullRowSelect = true;
            quizListView.Sorting = SortOrder.Ascending;

            for (int i = 0; i < date.Length; i++) {
                quizListView.Columns.Add(headerTitle[i], -2, HorizontalAlignment.Center);
                ListViewItem item = new ListViewItem(date[i], i);
                string numString = mockQuizNo[i].ToString();
                item.SubItems.Add(numString);
                item.SubItems.Add(teacherID[i]);
                item.SubItems.Add(subject[i]);
                quizListView.Items.Add(item);
            }
            this.Controls.Add(quizListView);
        }

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

        private void AddButton_Click(object sender, EventArgs e)
        {
            QuizPage quizPage = new QuizPage();
            quizPage.Show();
        }
    }
}
