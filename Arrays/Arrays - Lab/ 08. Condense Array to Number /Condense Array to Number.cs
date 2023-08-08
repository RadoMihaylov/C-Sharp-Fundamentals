using System.Linq;
namespace _8.CondenseArrayToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] nums = new int[input.Length];
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                nums[i] = int.Parse(input[i]);
            }

            while (nums.Length > 1)
            {
                int[] condensed = new int[nums.Length - 1];

                for (int i = 0; i < condensed.Length; i++)
                {
                    condensed[i] = nums[i] + nums[i +1];
                }
                nums = condensed;
            }

            Console.WriteLine(nums[0]);
        }
    }
}
