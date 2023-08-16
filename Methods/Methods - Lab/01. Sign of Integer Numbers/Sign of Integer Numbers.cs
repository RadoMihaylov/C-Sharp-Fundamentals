using System.Net.Http.Headers;

namespace _01._Sign_of_Integer_Numbers
{
    internal class Program
    {
        static void Number (int number)
        {
            if (number > 0)
            {
                Console.WriteLine ($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else if (number == 0)
            {
                Console.WriteLine($"The number {number} is zero. ");  
            }
            
        }
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Number(input);
        }
    }
}
