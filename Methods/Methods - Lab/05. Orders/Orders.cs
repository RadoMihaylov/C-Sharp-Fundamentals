namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            double sum = SumPrices(product, quantity);
            Console.WriteLine($"{sum:f2}");

        }
            
        static double SumPrices(string product, int quantity)
        {
            double pricePerItem = 0;

            switch (product)
            {
                case "coffee":
                    pricePerItem = 1.5;
                    break;
                case "water":
                    pricePerItem = 1;
                    break;
                case "coke":
                    pricePerItem = 1.4;
                    break;
                case "snacks":
                    pricePerItem = 2;
                    break;
            }

            double sum = pricePerItem * quantity;
            return sum;
        }
        
        
    }
}
