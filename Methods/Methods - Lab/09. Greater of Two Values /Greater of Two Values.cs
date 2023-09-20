using System.Reflection.Metadata.Ecma335;

namespace _09._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            if (command == "int")
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());
                int maxValue = GetMax(firstNumber, secondNumber);
                Console.WriteLine(maxValue);
            }
            else if (command == "char")
            {
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());
                char maxvalue = GetMax(firstChar, secondChar);
                Console.WriteLine(maxvalue);
            }
            else if (command == "string")
            {
                string firstStr = Console.ReadLine();
                string secondStr = Console.ReadLine();
                string maxvalue = GetMax(firstStr, secondStr);
                Console.WriteLine(maxvalue);
            }
        }

        static int GetMax(int a, int b)
        {
            int result = 0;
            if (a > b)
            {
                result = a;
                return a;
            }
            else
            {
                result = b;
                return b;
            }

        }

        static char GetMax(char a, char b)
        {
            char result = ' ';
            if (Convert.ToInt32(a) > Convert.ToInt32(b))
            {
                result = a;
                return result;
            }
            else
            {
                result = b;
                return result;
            }

        }


        static string GetMax(string a, string b)
        {
            int numericValueA = Convert.ToInt32(a[0]);
            int numericValueB = Convert.ToInt32(b[0]);

            if (numericValueA > numericValueB)
            {
                return a;
            }
            else
            {
                return b;
            }

        }
    }
}
