using System.ComponentModel.DataAnnotations;

namespace _05._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().
                Split().
                Select(int.Parse).
                ToList();
            int[] bombWithPower = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bombNumber = bombWithPower[0];
            int power = bombWithPower[1];

            while (numbers.Contains(bombNumber) == true)
            {
                int index = numbers.IndexOf(bombNumber);
                int firstRange = Math.Max(0, index - power);
                int secondRange = Math.Min(numbers.Count - 1, index + power);
                int range = secondRange - firstRange + 1;

                numbers.RemoveRange(firstRange, range);
            }
             
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            Console.WriteLine(sum);

        }
    }
}
