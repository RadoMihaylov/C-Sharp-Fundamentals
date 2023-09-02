namespace _02.SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sumOfDigits = 0;
            int digit  = 0;

            while (number > 0)
            {
               
                digit = number % 10;
                number = number / 10;               
                sumOfDigits += digit;

                digit = 0;

            }
            Console.WriteLine(sumOfDigits);
            



        }
    }
}
