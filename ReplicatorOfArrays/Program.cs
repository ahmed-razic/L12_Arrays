namespace ReplicatorOfArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[5];
            int[] array2 = new int[5];

            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write("Enter value for array1[{0}]: ", i);
                array1[i] = int.Parse(Console.ReadLine());
            }

            // Copy values from array1 to array2
            for (int i = 0; i < array1.Length; i++)
            {
                array2[i] = array1[i];
            }

            // Display values in both arrays
            Console.WriteLine("Values in array1:");
            foreach (int value in array1)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("Values in array2:");
            foreach (int value in array2)
            {
                Console.WriteLine(value);
            }
        }
    }
}
