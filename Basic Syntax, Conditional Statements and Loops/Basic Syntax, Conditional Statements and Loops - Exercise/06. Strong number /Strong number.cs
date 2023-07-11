using System.Diagnostics.CodeAnalysis;

namespace _06.StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int digit = 0;
            int fact = 1;
            int sum = 0;
            int numberValue = number;

            while (number > 0)
            {
                digit = number % 10;
                number = number / 10;

                for (int i = 1; i <= digit; i++)
                {
                    fact = fact * i;
                }
                
                sum += fact;
                fact = 1;

                //Console.WriteLine(fact);
            }
            if (sum == numberValue)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

            //int number = int.Parse(Console.ReadLine());
            //int fact = 1;
            
            
            
            //for (int i = 1; i <= number; i++)
            //{
            //    fact = fact * i;
            //}
            //Console.WriteLine(fact);
        }
    }
    
}
