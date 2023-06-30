namespace _11.MultiplicationTable2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //{ n} X { times} = { product}
            int n = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());
            int product = 0;

            for (int i = times; i <= 10; i++)
            {
               
                product = n * i;
                Console.WriteLine($"{n} X {i} = {product}");
                
            }
            if (times > 10)
            {
                product = n * times;
                Console.WriteLine($"{n} X {times} = {product}");
            }
           
            
        }
    }
}
