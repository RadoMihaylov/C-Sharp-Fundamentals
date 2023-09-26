using System.Diagnostics;

namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];

            for (int i = 0; i < 3; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int smallest = FindSmallestNumber(numbers);
            Console.WriteLine(smallest);

        }

        static int FindSmallestNumber(int[] numbers)
        {
            int smallest = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < smallest)
                {
                    smallest = numbers[i];
                }
            }
            return smallest;
        } 
    }
}
