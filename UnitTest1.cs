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
                obj = MoodAnalyzerFactory.CreateMoodAnalyse("ModeAnalyserProject.MoodAnalyser", "MoodAnalyser");

            }
            catch (Exception e)
            {
                throw new System.Exception(e.Message);
            }
        }
        [TestMethod]

        public void Reflection_Return_Default_Constructor_No_Class_Found()
        {
            string expected = "Class not Found";

            try
            {

                MoodAnalyzerFactory.CreateMoodAnalyse("MoodAnalyserProject.Mood", "Mood");

            }
            catch (CustomException ex)

            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        [TestMethod]
        public void Reflection_Return_Default_Constructor_No_Constructor_Found()
        {
            string expected = "Constructor not found";

            try
            {

                MoodAnalyzerFactory.CreateMoodAnalyse("MoodAnalyserPro.MoodAnalyser", "MoodAnalyser");

            }
            catch (CustomException actual)

            {
                Assert.AreEqual(expected, actual.Message);
            }
        }
        [TestMethod]
        public void Reflection_Return_Parameterized_Constructor()
        {
            string message = "I am in happy mood";
            MoodAnalyzer expected = new MoodAnalyzer(message);

            try
            {

                MoodAnalyzerFactory.CreateMoodAnalyserParameter("MoodAnalyserProject.MoodAnalyser", "MoodAnalyser", message);

            }
            catch (CustomException ex)
            {
                throw new System.Exception(ex.Message);
            }

        }
        //Invalid case
        [TestMethod]
        public void Reflection_Return_Parameterized_Class_Invalid()
        {
            string message = "I am in happy mood";
            MoodAnalyzer expected = new MoodAnalyzer(message);
            object actual = null;
            try
            {

                MoodAnalyzerFactory.CreateMoodAnalyserParameter("MoodAnalyserProject.MoodAna", "MoodAnalyser", message);

            }
            catch (CustomException actual1)
            {
                Assert.AreEqual(expected, actual1.Message);
            }
        }
        [TestMethod]
        public void Reflection_Return_Method()
        {
            string expected = "happy";
            string actual = MoodAnalyzerFactory.InvokeAnalyserMethod("happy", "AnalyseMood");
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Reflection_Return_Invalid_Method()
        {
            string expected = "Method not found";
            try
            {

                string actual = MoodAnalyzerFactory.InvokeAnalyserMethod("happy", "Analyze");
            }
            catch (CustomException e)
            {

                Assert.AreEqual(expected, e.Message);
            }
        }
    }
}