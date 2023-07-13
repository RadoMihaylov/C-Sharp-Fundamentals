using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;

namespace _07.VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //"Nuts" with a price of 2.0
            //• "Water" with a price of 0.7
            // "Crisps" with a price of 1.5
            //  "Soda" with a price of 0.8
            //  "Coke" with a price of 1.0

           string input = Console.ReadLine();
            double sum = 0;
            double price = 0;
            bool trueProduct = false;

            while (input != "Start")
            {
                double coins = double.Parse(input);
                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                {
                    sum += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");                  
                }

                input = Console.ReadLine();
            }

            while (input == "Start")
            {
                string product = Console.ReadLine();
                if (product == "End")
                {
                    Console.WriteLine($"Change: { sum:f2}");
                    return;
                }

                switch (product)
                {
                    case "Nuts": price = 2;  trueProduct = true; break;
                    case "Water": price = 0.7; trueProduct = true; break;
                    case "Crisps": price = 1.5; trueProduct = true; break;
                    case "Soda": price = 0.8; trueProduct = true; break;
                    case "Coke": price = 1; trueProduct = true; break;
                    default: trueProduct = false; Console.WriteLine("Invalid product"); break;

                }
                if (sum >= price && trueProduct == true)
                {
                    Console.WriteLine($"Purchased {product.ToLower()}");
                    sum -= price;
                }
                else if (sum < price)
                {
                    Console.WriteLine("Sorry, not enough money");
                }



            }
            

        }
    }
}
