using System.Diagnostics.CodeAnalysis;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int int1 = int.Parse(Console.ReadLine());
            int int2 = int.Parse(Console.ReadLine());
            int sum = int1 + int2;
            int int3 = int.Parse(Console.ReadLine());

            int substractedNumsSum = SubstractedNumber(sum, int3);
            Console.WriteLine(substractedNumsSum);
        }

        static int SubstractedNumber(int sum, int int3)
        {
            int substractedNums = sum - int3;
            return substractedNums;
        }
    }
}
