namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score1 = 0;
            int score2 = 3;
            int score3 = 4;
            int score4 = 7;
            int score5 = 8;

            int[] scores;
            bool[] states;
            string[] names;

            scores = new int[5];
            states = new bool[5];
            names = new string[5];

            foreach (int score in scores)
            {
                Console.WriteLine(score);
            }
            foreach (bool state in states)
            {
                Console.WriteLine(state);
            }
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            //Fill up arrays with values
            for (int i = 0; i < scores.Length; i++)
            {
                scores[i] = i+1;
            }

            foreach (int score in scores)
            {
                Console.WriteLine(score);
            }

            //Find minimum and maximum values in an array
            int min = scores[0];
            int max = scores[0];

            foreach (int score in scores)
            {
                if (score < min)
                    min = score;
                if (score > max)
                    max = score;
            }

            Console.WriteLine("Minimum score: {0}", min);
            Console.WriteLine("Maximum score: {0}", max);

            //Find the average of the values in an array
            int[] array = new[] { 4, 51, 65, -55, 3, 99 };
            int sum = 0;
            foreach (int score in array)
            {
                sum += score;
            }
            Console.WriteLine($"Average score: {(double)sum / array.Length}");
        }
    }
}