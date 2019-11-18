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

/* 
 * Author: Xinkai Wang
 * Description: Use to show question detail and used by teacher to create new question or edit old question.
*/

namespace MathBrick
{
    public partial class QuestionPopUp : Skin_Color
    {
        private string question = "";
        private string answer = "";
        private bool isNew = true;

        public QuestionPopUp(string inputQues, string inputAns, bool inputIsNew)
        {
            isNew = inputIsNew;
            question = inputQues;
            answer = inputAns;
            InitializeComponent();
        }
        
        private void btn_cancel_Click_1(object sender, EventArgs e)
        {
            QuizPage.returnType = "cancel";
            Close();
        }

        private void btn_save_Click_1(object sender, EventArgs e)
        {
            if (CheckValid())
            {
                QuizPage.question = textBox_question.Text;
                QuizPage.answer = textBox_answer.Text;
                if (isNew == true)
                    QuizPage.returnType = "add";
                else
                    QuizPage.returnType = "edit";
                Close();
            }
        }

        private void Question_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            textBox_question.Text = question;
            textBox_answer.Text = answer;
        }
        private bool CheckValid()
        {
            if (textBox_question.Text == "")
                MessageBox.Show("Please enter question.");
            else if (textBox_answer.Text == "")
                MessageBox.Show("Please enter answer.");
            else
                return true;
            return false;
        }

    }
}
