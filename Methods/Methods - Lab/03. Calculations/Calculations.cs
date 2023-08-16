using System.Data;
using System.Xml;

namespace _03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());

            switch (command)
            {
                case "add":
                    AddTwoNumbers(number2, number1);
                    break;
                case "multiply":
                    MultiplyNumbers(number2, number1);
                    break;
                case "subtract":
                    SubstractNumbers(number2, number1);
                break;
                case "divide":
                    DivideNumbers(number2, number1);
                    break;
            }

        }

        static void AddTwoNumbers(double a, double b)
        {
            double sum = a + b;
            Console.WriteLine(sum);
        }

        static void MultiplyNumbers(double a, double b)
        {
            double sum = a * b;
            Console.WriteLine(sum);
        }

        static void SubstractNumbers(double a, double b)
        {
            double sum = Math.Abs(a - b);
            Console.WriteLine(sum);
        }

        static void DivideNumbers(double a, double b)
        {
            if (b > a)
            {
                double sumB = b / a;
                Console.WriteLine(sumB);
            }
            //if (b != 0)
            //{
            //    double sum = a / b;
            //    Console.WriteLine(sum);
            //}
        }
    }
}
