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
    public partial class ViewGrade : Skin_Color
    {
        private string dueDate = "";
        private string level = "";
        private string subjet = "";
        public ViewGrade()
        {
            InitializeComponent();
            //dueDate = QuizUtils.Instance.;
           // level = QuizList.level;
            //subjet = QuizList.subject;
        }

        private void ViewGrade_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
