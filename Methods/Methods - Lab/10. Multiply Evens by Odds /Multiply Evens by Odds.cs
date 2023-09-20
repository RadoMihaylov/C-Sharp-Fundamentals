namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());   
            int evenSum = GetSumOfEvenDigits(numbers);
            int oddSum = GetSumOfOddDigits(numbers);
            int sum = GetMultipleOfEvenAndOdds(oddSum, evenSum);
            
            
            Console.WriteLine(sum);
        }

        
        static int GetMultipleOfEvenAndOdds(int a, int b)
        {
            int sum = a * b;
            return sum;
        }
        static int GetSumOfEvenDigits(int numbers)
        {
            int evenSum = 0;
            numbers = Math.Abs(numbers);

            while (numbers > 0)
            {
                int digit = numbers % 10;
                if (digit % 2 == 0)
                {
                    evenSum+= digit;
                }
                numbers /= 10;
            }
            return evenSum;
        }

        static int GetSumOfOddDigits(int numbers)
        {
            int oddSum = 0;
            numbers = Math.Abs(numbers);

            while (numbers > 0)
            {
                int digit = numbers % 10;
                if (digit % 2 != 0)
                {
                    oddSum += digit;
                }
                numbers /= 10;
            }
            return oddSum;
        }

        
    }
}
