namespace _7._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split();/*Select(int.Parse).ToArray();*/
            int count = 0;
            int bestCount = 0;
            string equalDigits = "";
            for (int i = 0; i < nums.Length; i++)
            {
                count = 0;              
                for (int k = i; k < nums.Length; k++)
                {
                    if (nums[k] == nums[i])
                    {
                        count++;
                        if (bestCount < count)
                        {
                            bestCount = count;
                            equalDigits = nums[i];
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            for (int i = 0;i < bestCount;i++)
            {

                Console.Write($"{equalDigits} ");
            }
        }
    }
}
