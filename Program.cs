using MoodAnalyserProblem;

namespace ModeAnalyzerProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string message = "I am in Sad Mood";
            MoodAnalyzer moodAnalyzer1 = new MoodAnalyzer();
            moodAnalyzer1.analyseMood(message);

            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string r2 = moodAnalyser.analyseMood1();

            string r1 = moodAnalyser.msg;
            Console.WriteLine(r2);

            Console.WriteLine(r1);


        }
    }

}


