using System.Reflection.Metadata;
using System.Linq;

namespace _03.RoundingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            int[] rounded = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                rounded[i] = (int)Math.Round(numbers[i], 0, MidpointRounding.AwayFromZero);
                Console.WriteLine("{0} => {1}", numbers[i], rounded[i]);
            }
        }
    }
}
