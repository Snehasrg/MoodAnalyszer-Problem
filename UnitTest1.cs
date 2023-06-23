using MoodAnalyserProblem;

namespace TestCase
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodForHappyMood()
        {
            MoodAnalyzer moodAnalyser = new MoodAnalyzer("I am in happy Mood");
            string expected = "happy";
            string actual = moodAnalyser.AnalyzeMood();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodForSadMood()
        {
            MoodAnalyzer moodAnalyser = new MoodAnalyzer("I am in sad Mood");
            string expected = "sad";
            string actual = moodAnalyser.AnalyzeMood();
            Assert.AreEqual(expected, actual);
        }
    }
}
