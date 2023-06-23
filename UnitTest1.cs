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
        [TestMethod]
        public void TestMethodForCustomizedNullException()

        {

            try
            {
                string input = null;
                var analyze = new MoodAnalyzer(input);
            }
            catch (NullReferenceException Exception)
            {
                Assert.AreEqual("Mood can not be Null.", Exception.Message);
            }
        }
        [TestMethod]
        public void TestMethodForCustomizedEmptyException()

        {
            string expected = "Mood should not be empty";
            try
            {

                MoodAnalyzer moodAnalyser = new MoodAnalyzer(string.Empty);
                moodAnalyser.AnalyzeMood();
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }

        }
    }
}
