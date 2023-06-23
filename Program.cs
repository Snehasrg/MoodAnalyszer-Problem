using MoodAnalyserProblem;

namespace ModeAnalyzerProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter mood Happy/Sad : ");
            string M = Console.ReadLine();
            MoodAnalyzer mood = new MoodAnalyzer(M);
            Console.WriteLine(mood.AnalyzeMood());
        }
    }
}


