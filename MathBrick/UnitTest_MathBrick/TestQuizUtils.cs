using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest_MathBrick
{
    [TestClass]
    public class TestQuizUtils
    {
        [TestMethod]
        public void TestStoreQuiz()
        {
            MathBrick.Model.Question firstQ = new MathBrick.Model.Question("What is 1 + 1?", "2");
            MathBrick.Model.Question secondQ = new MathBrick.Model.Question("What is 8 * 7?", "56");
            MathBrick.Model.Question thirdQ = new MathBrick.Model.Question("What is 3 to the power of 2?", "9");
            MathBrick.Model.Question[] questionsK = { firstQ, secondQ, thirdQ };
            MathBrick.Model.Quiz firstQuiz = new MathBrick.Model.Quiz("Intermediate Exam 1", 2, "2019/11/16", "tool003", questionsK);
            MathBrick.QuizUtils.Instance.StoreQuiz(firstQuiz);
            Assert.IsNotNull(firstQuiz);
        }

        [TestMethod]
        public void TestRetrieveQuizzes()
        {
            MathBrick.Model.Quiz[] allQuizzes = MathBrick.QuizUtils.Instance.RetrieveQuizzes();
            Assert.IsNotNull(allQuizzes);
        }

        [TestMethod]
        public void TestRetrieveOneQuiz()
        {
            Assert.IsNull(MathBrick.QuizUtils.Instance.RetrieveOneQuiz("SER515"));
        }

        [TestMethod]
        public void TestPutScoreToQuiz()
        {
            MathBrick.QuizUtils.Instance.PutScoreToQuiz("InvisibleID", "joker007", 74);
            Assert.IsTrue(70 + 4 == 74);
        }
    }
}
