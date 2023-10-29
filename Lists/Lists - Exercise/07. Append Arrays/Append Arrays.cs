namespace _07._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ints = Console.ReadLine().Split("|").ToArray();
            Array.Reverse(ints);
            

            string result = string.Join(" ", ints.SelectMany(ints => ints.Split(' ', StringSplitOptions.RemoveEmptyEntries)));
            Console.WriteLine(result);

        }
    }
}
