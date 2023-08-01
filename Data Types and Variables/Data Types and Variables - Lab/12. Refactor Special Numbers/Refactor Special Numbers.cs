namespace _12.RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int digit = 0;
            bool isTrue = false;
            for (int i = 1; i <= n; i++)
            {
                digit = i;
                while (digit > 0)
                {
                    sum += digit % 10;
                    digit = digit / 10;
                }
                isTrue = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{i} -> {isTrue}");
                sum = 0;
                    //i = n;
            }
        }
    }
}
