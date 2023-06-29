namespace _10.MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //{ n} X { times} = { product}
            int n = int.Parse(Console.ReadLine());
            int times = 10;
            int product = 0;

            for (int i = 1; i <= times; i++)
            {
                product = n * i;
                Console.WriteLine($"{n} X {i} = {product}");
            }
        }
    }
}
