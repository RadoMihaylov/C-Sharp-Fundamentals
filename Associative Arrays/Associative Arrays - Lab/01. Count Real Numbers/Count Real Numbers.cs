namespace _01._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            SortedDictionary <double, int> dictionary = new SortedDictionary<double, int>();
            foreach (var number in numbers)
            {
                if (!dictionary.ContainsKey(number))
                {
                    dictionary[number] = 1;
                }
                else
                {
                    dictionary[number]++;
                }
            }

            foreach (var num in dictionary)
            {
                Console.WriteLine($"{num.Key} -> {num.Value}");
            }
        }
    }
}
