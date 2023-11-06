using System.Collections.Generic;

namespace _06._Store_Boxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] argument = command.Split();
                int serialNumber = int.Parse(argument[0]);
                string productName  = argument[1];  
                int quantity = int.Parse(argument[2]);
                double priceForBox = double.Parse(argument[3]);
                Item item = new Item(productName, priceForBox);
                Box box = new Box(serialNumber, item, quantity);
                boxes.Add(box);
            }

            //{ boxSerialNumber}
            //-- { boxItemName} – ${ boxItemPrice}: { boxItemQuantity}
            //-- ${ boxPrice}

            foreach (var box in boxes.OrderByDescending(x => x.PriceForABox))
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForABox:f2}");
            }
        }
    }

    //Box, which contains these properties: Serial Number, Item, Item Quantity and Price for a Box
    public class Item
    {
        public Item(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public double Price { get; set; }
    }

    public class Box
    {
        public Box(int serialNumber, Item item, int itemQuantity)
        {
            SerialNumber = serialNumber;
            Item = item;
            ItemQuantity = itemQuantity;
        }

        public int SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public double PriceForABox => Item.Price * ItemQuantity;

    }
}
