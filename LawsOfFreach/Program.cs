namespace LawsOfFreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int sum2 = 0;
            int[] array = new int[] { 4, 51, 65, -55, 3, 99 };
            int[] array2 = new int[] { 7, 7, 7, 7, 7, 7, 7 };
            foreach (int value in array)
            {
                sum += value;
            }
            Console.WriteLine($"The average in arrayis: {(double)sum / array.Length}");

            foreach (int value in array2)
            {
                sum2 += value;
            }
            Console.WriteLine($"The average in array2 is: {(double)sum2 / array2.Length}");
        }
    }
}
