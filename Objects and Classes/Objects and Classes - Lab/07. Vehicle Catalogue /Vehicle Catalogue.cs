using System.Reflection;

namespace _07._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Truck> truck = new List<Truck>();
            List<Car> cars = new List<Car>();
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] input = command.Split("/").ToArray();
                string type = input[0];
                string brand = input[1];
                string model = input[2];

                if (type == "Truck")
                {
                    int weight = int.Parse(input[3]);
                    truck.Add(new Truck(brand, model, weight));
                }
                else
                {
                    int horsePower = int.Parse(input[3]);
                    cars.Add(new Car(brand, model, horsePower));
                    
                }
            }
            if (cars.Count > 0)
            {    
                Console.WriteLine("Cars:");
                foreach (Car car in cars.OrderBy(c => c.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (truck.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (Truck item in truck.OrderBy(t => t.Brand))
                {
                    Console.WriteLine($"{item.Brand}: {item.Model} - {item.Weight}kg");
                }
            }
        }
    }

    public class Truck
    {
        public Truck(string brand, string model, int  weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }

    public class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }

   
}
