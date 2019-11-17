using MathBrick.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Script.Serialization;

namespace MathBrick
{
    class QuizUtils
    {
        private static QuizUtils instance;
        private static string quizFileName = "QuizzesList.txt";
        private Dictionary<string, Quiz> quizzesDic;

        private QuizUtils()
        {
            quizzesDic = ReadQuizzes();
        }
        public static QuizUtils Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new QuizUtils();
                }
                return instance;
            }
        }

        /* Only demo in developing stage. Do not use in the release version. 
         Call this method by QuizUtils.Instance.ShowExampleForThisClass() */
        public void ShowExampleForThisClass()
        {
            // A quiz with three questions create then store.
            Console.WriteLine("Quizzes create example: ");
            Question firstQ = new Question("What is 1 + 1?", "2");
            Question secondQ = new Question("What is 8 * 7?", "56");
            Question thirdQ = new Question("What is 3 to the power of 2?", "9");
            Question[] questionsK = { firstQ, secondQ, thirdQ };
            Quiz firstQuiz = new Quiz("Intermediate Exam 1", 2, "2019/11/16", "tool003", questionsK);
            QuizUtils.Instance.StoreQuiz(firstQuiz);
            Question myRiddle = new Question("What has a head, a tail, is brown, and has no legs?", "A penny");
            Question[] questionsZ = { myRiddle };
            Quiz secondQuiz = new Quiz("Advanced Test", 3, "2019/11/11", "teacher777", questionsZ);
            QuizUtils.Instance.StoreQuiz(secondQuiz);
            PrintOutQuizDictionary();

            Console.WriteLine("\nRetrieve All Quizzes: ");
            Quiz[] allQuizzes = QuizUtils.Instance.RetrieveQuizzes();
            PrintOutQuizArray(allQuizzes);

            Console.WriteLine("\nRetrieve Advanced(Level 3) Quizzes ONLY: ");
            Quiz[] partOfQuizzes = QuizUtils.Instance.RetrieveQuizzes(3);
            PrintOutQuizArray(partOfQuizzes);

            Console.WriteLine("\nRetrieve specific ONE quiz: ");
            Quiz specificQuiz = QuizUtils.Instance.RetrieveOneQuiz(firstQuiz.uniqueID);
            PrintOutOneQuiz(specificQuiz);
        }

        private Dictionary<string, Quiz> ReadQuizzes()
        {
            var quizDic = new Dictionary<string, Quiz>();
            if (File.Exists(quizFileName))
            {
                quizzesDic = new JavaScriptSerializer()
                        .Deserialize<Dictionary<string, Quiz>>(File.ReadAllText(quizFileName));
            }
            Console.WriteLine("Cannot find any quizzes in database.");
            return quizDic;
        }

        public void StoreQuiz(Quiz myQuiz)
        {
            quizzesDic.Add(myQuiz.uniqueID, myQuiz);
            File.WriteAllText(quizFileName, new JavaScriptSerializer().Serialize(quizzesDic));
        }

        public Quiz[] RetrieveQuizzes(int level = 0)
        {
            if (level == 0)
            {
                return quizzesDic.Values.ToArray();
            }

            List<Quiz> selectedQuizzes = new List<Quiz>();

            foreach (Quiz quiz in quizzesDic.Values)
            {
                if (quiz.level == level)
                {
                    selectedQuizzes.Add(quiz);
                }
            }
            return selectedQuizzes.ToArray();
        }

        public Quiz RetrieveOneQuiz(string uniqueID) {
            return quizzesDic[uniqueID];
        }

        private void PrintOutQuizDictionary()
        {
            Quiz[] q = quizzesDic.Values.ToArray();
            foreach (Quiz quiz in q)
            {
                Console.WriteLine("Title: " + quiz.subject);
                foreach (Question s in quiz.questions)
                {
                    Console.WriteLine("Question: " + s.title);
                    Console.WriteLine("Answer: " + s.answer);
                }
            }
        }

        private void PrintOutQuizArray(Quiz[] q)
        {
            foreach (Quiz quiz in q)
            {
                Console.WriteLine("Title: " + quiz.subject);
                foreach (Question s in quiz.questions)
                {
                    Console.WriteLine("Question: " + s.title);
                    Console.WriteLine("Answer: " + s.answer);
                }
            }
        }

        private void PrintOutOneQuiz(Quiz quiz)
        {
            Console.WriteLine("Title: " + quiz.subject);
            foreach (Question s in quiz.questions)
            {
                Console.WriteLine("Question: " + s.title);
                Console.WriteLine("Answer: " + s.answer);
            }
        }
    }
}
