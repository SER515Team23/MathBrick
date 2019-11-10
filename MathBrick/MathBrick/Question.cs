using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathBrick
{
    public partial class Question : Form
    {
        private string question = "";
        private string answer = "";
        private bool isNew = true;

        public Question(string inputQues, string inputAns, bool inputBool)
        {
            isNew = inputBool;
            question = inputQues;
            answer = inputAns;
            InitializeComponent();

        }

        private void Question_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            textBox_question.Text = question;
            textBox_answer.Text = answer;
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            QuizPage.hasReturn = 2;
            Close();
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            QuizPage.question = textBox_question.Text;
            QuizPage.answer = textBox_answer.Text;
            if (isNew == true)
                QuizPage.hasReturn = 1;
            else
                QuizPage.hasReturn = 3;
            Close();
        }
    }
}
