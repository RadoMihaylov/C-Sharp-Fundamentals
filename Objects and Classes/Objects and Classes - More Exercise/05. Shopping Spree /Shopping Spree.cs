using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _05._Shopping_Spree
{
    class Person
    {
        public string Name { get; set; }
        public double Money { get; set; }
        public List<Products> Bag = new List<Products> { };

        public Person(string name, double money)
        {
            Name = name;
            Money = money;
            Bag = new List<Products> { };
        }
    }
    class Products
    {
        public Products(string productName, double cost)
        {
            ProductName = productName;
            Cost = cost;
        }

        public string ProductName { get; set; }
        public double Cost { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Person> people = new Dictionary<string, Person>();
            Dictionary<string, Products> products = new Dictionary<string, Products>();

            string[] nameInput = Console.ReadLine().Split(";");
            foreach (var personData in nameInput)
            {
                string[] arguments = personData.Split("=");
                string personName = arguments[0];
                double money = double.Parse(arguments[1]);
                Person person = new Person(personName, money);
                people[personName] = person;
            }
            string[] productsInput = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            foreach (var productsData in productsInput)
            {
                string[] arguments = productsData.Split("=");
                string productName = arguments[0];
                double cost = double.Parse(arguments[1]);
                Products product = new Products(productName, cost);
                products[productName] = product;
            }

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] arguments = input.Split();
                string personName = arguments[0];
                string productName = arguments[1];

                Person person = people[personName];
                Products product = products[productName];

                if (product.Cost <= person.Money)
                {
                    person.Money -= product.Cost;
                    person.Bag.Add(product);
                    Console.WriteLine($"{personName} bought {productName}");
                }
                else
                {
                    Console.WriteLine($"{personName} can't afford {productName}");
                }
            }

            foreach (var person in people.Values)
            {
                string bagContent = person.Bag.Count > 0 ? string.Join(", ", person.Bag.Select(p => p.ProductName)) : "Nothing bought";
                Console.WriteLine($"{person.Name} - {bagContent}");
            }

        }
    }
}
