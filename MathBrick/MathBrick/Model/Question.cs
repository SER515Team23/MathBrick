using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathBrick.Model
{
    public class Question
    {
        public string uniqueID { get; set; }
        public string title { get; set; }
        public string answer { get; set; }

        public Question(string title, string answer) {
            // Generate unique ID.
            string uniqueID = Guid.NewGuid().ToString();
            this.uniqueID = uniqueID;
            this.title = title;
            this.answer = answer;
        }
        public Question() { }
    }
}
