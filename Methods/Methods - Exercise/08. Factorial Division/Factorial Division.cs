using System;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long long1 = long.Parse(Console.ReadLine());
            long long2 = long.Parse(Console.ReadLine());
            double result = FactorialSum(long1) / FactorialSum(long2);
            Console.WriteLine($"{result:F2}");
        }


        static double FactorialSum(long number)
        {
            double result = number;

            for (long i = number - 1; i >= 1; i--)
            {
                result *= i;
            }

            return result;
            

        }
    }
}
