using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathBrick.Model
{
    class Quiz
    {
        public string uniqueID { get; set; }
        public string subject { get; set; }
        public int level { get; set; }
        public string date { get; set; }
        public string teacherID { get; set; }
        public Question[] questions { get; set; }

        public Dictionary<string, int> studentGrades { get; set; }

        public Quiz(string subject, int level, string date, string teacherID, Question[] questions)
        {
            // Generate unique ID.
            string uniqueID = Guid.NewGuid().ToString();
            this.uniqueID = uniqueID;
            this.subject = subject;
            this.level = level;
            this.date = date;
            this.teacherID = teacherID;
            this.questions = questions;
            this.studentGrades = new Dictionary<string, int>();
        }

        public Quiz() { }
    }
}
