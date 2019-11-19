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
 * Author:Huijing Liang
 * Description:Teachers can see all the students's grades in one exam 
*/
namespace MathBrick
{
    public partial class ViewGrade : Skin_Color
    {

        private string level = "";
        private string subject = "";
        private string duedate = "";
        private Quiz quiz = null;
        private string quizId;
        public static string StudentID = "";
        public static double grade = 0;
        public ViewGrade(ListViewItem lv)
        {
            InitializeComponent();
            quiz = QuizUtils.Instance.RetrieveOneQuiz(lv.Tag.ToString());
            quizId = lv.Tag.ToString();
            subject = lv.SubItems[2].Text;
            level = lv.SubItems[3].Text;
            duedate = lv.SubItems[1].Text;
        }
        private void reOrder()
        {
            int order = 1;
            foreach (ListViewItem lv in GradeListView.Items)
            {
                lv.Text = order.ToString();
                order++;
            }
        }

        private void ViewGrade_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            SubjectLabel.Text = subject;
            LevelLabel2.Text = level;
            DueDateLabel.Text = duedate;
          
            foreach (String Key in quiz.studentGrades.Keys)
            {
                ListViewItem lvi = new ListViewItem();
                //lvi.Text = "";
                lvi.SubItems.Add(Key);
                lvi.SubItems.Add(quiz.studentGrades[Key].ToString());
                GradeListView.Items.Add(lvi);
            }
            reOrder();
        }
    }
}
