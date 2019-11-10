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

namespace MathBrick
{
    public partial class TeacherManagePage : Skin_Color
    {
        
            private string[] headerTitle = { "Date", "Grade", "StudentName", "Subject" };
            private string[] date = { "8/3", "8/15", "9/1", "10/25" };
            private string[] grade = { " 100 ", " 100 ", " 100 ", " 100 " };
            //private int[] mockQuizNo = { 2, 1, 3, 7 };
            private string[] studentName = { "Xinkai Wang", "Huijing Liang", "YuTing Tsao", "Bingrui Feng" };
            private string[] subject = { "Addition knowledge check", "Substraction small quiz", "Linear equation test",
            "Midterm for intermediate", "Practice multiplication" };
            //private string[] grade = { "100", "100", "100", "100" };

        public TeacherManagePage()
        {
            InitializeComponent();
            CreateMyListView();
        }
        private void CreateMyListView()
        {
            gradeListView.View = View.Details;
            gradeListView.FullRowSelect = true;
            gradeListView.Sorting = SortOrder.Ascending;

            for (int i = 0; i < date.Length; i++)
            {
                gradeListView.Columns.Add(headerTitle[i], -2, HorizontalAlignment.Center);
                ListViewItem item = new ListViewItem(date[i], i);
                //string numString = mockQuizNo[i].ToString();
                //item.SubItems.Add(numString);
                item.SubItems.Add(grade[i]);
                item.SubItems.Add(studentName[i]);
                item.SubItems.Add(subject[i]);
                
                gradeListView.Items.Add(item);
            }
            this.Controls.Add(gradeListView);
        }
        

        
    }
}
