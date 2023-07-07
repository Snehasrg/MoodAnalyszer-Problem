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
            string expected = "Mood should not be NULL";
            try
            {

                MoodAnalyzer moodAnalyser = new MoodAnalyzer(null);
                moodAnalyser.AnalyzeMood();
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
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
        [TestMethod]
        public void Fordefault()
        {
            MoodAnalyzer expected = new MoodAnalyzer();
            object obj = null;
            try
            {
                obj = MoodAnalyzerFactory.CreateMoodAnalyse("ModeAnalyserPro.MoodAnalyser", "MoodAnalyser");

            }
            catch (CustomException e)
            {
                throw new System.Exception(e.Message);
            }
        }
        [TestMethod]

        public void Reflection_Return_Default_Constructor_No_Class_Found()
        {
            string expected = "Class not Found";
            object obj = null;
            try
            {

                obj = MoodAnalyzerFactory.CreateMoodAnalyse("MoodAnalyserProject.Mood", "Mood");

            }
            catch (CustomException actual)

            {
                Assert.AreEqual(expected, actual.Message);
            }
        }

        [TestMethod]
        public void Reflection_Return_Default_Constructor_No_Constructor_Found()
        {
            string expected = "Constructor not found";

            try
            {

                MoodAnalyzerFactory.CreateMoodAnalyse("MoodAnalyserPro.MoodAnalyser", "MoodAnaly");

            }
            catch (CustomException actual)

            {
                Assert.AreEqual(expected, actual.Message);
            }
        }
    }
}