using ClassLibrary;

namespace ConsoleApp
{
    internal class Program
    {
        static Random generator;

        static void Main(string[] args)
        {

            Episode ep1, ep2;
            ep1 = new Episode();
            ep2 = new Episode(10, 64.39, 8.7);
            int viewers = 10;
            for (int i = 0; i < viewers; i++)
            {
                ep1.AddView(GenerateRandomScore());
                Console.WriteLine(ep1.GetMaxScore());
            }
            if (ep1.GetAverageScore() > ep2.GetAverageScore())
            {
                Console.WriteLine("Episode 1 has a higher score.");
                Console.WriteLine($"Viewers: {ep1.GetViewerCount()}");
            }
            else
            {
                Console.WriteLine("Episode 2 has a higher score.");
                Console.WriteLine($"Viewers: {ep2.GetViewerCount()}");
            }
        }

        public static float GenerateRandomScore()
        {
            generator = new Random();
            double val = generator.NextDouble() * 10;
            return (float)val;
        }
    }
}
