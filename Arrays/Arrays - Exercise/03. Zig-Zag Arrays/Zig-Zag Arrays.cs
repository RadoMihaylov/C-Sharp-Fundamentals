using System.Globalization;

namespace _03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];


            for (int i = 0; i < n; i++)
            {
                string[] numbers = Console.ReadLine().Split();
                arr1[i] = int.Parse(numbers[0]);
                arr2[i] = int.Parse(numbers[1]);
            }
            int[] allElements1 = new int[n];
            int[] allElements2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    allElements1[i] = arr1[i];
                    allElements2[i] = arr2[i];
                }
                else
                {
                    allElements1[i] = arr2[i];
                    allElements2[i] = arr1[i];
                }
            }

            Console.Write(string.Join(" ", allElements1));
            Console.WriteLine();
            Console.Write(string.Join(" ", allElements2));





        }
    }
}
