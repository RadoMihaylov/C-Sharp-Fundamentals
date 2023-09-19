namespace _08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double total = GetTheNumberPow(number, power);
            Console.WriteLine(total);
        }

        static double GetTheNumberPow(double number, double power)
        {
            double powOfNum = Math.Pow(number, power);
            return powOfNum;

        }
    }
}
