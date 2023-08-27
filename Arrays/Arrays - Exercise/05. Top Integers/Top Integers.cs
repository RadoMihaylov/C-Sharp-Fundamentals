using System.Xml;

namespace _05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isTopInt = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                //if (numbers[i]< 0)
                //{
                //    break;
                //}
                for (int j = i +1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {                       
                        isTopInt = true;
                    }
                    else
                    {
                        isTopInt= false;
                        break;
                    }
                }

                if (isTopInt)
                {
                    Console.Write($"{numbers[i]} ");
                }

                if (i == numbers.Length - 1 && numbers.Length - 1 > 0)
                {
                   
                    Console.Write($"{numbers[i]} ");

                }

                isTopInt= false;
            }
        }
    }
}
