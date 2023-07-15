namespace _01.ConvertMetersToKilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            float kilometers = (float)meters / 1000;
            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
