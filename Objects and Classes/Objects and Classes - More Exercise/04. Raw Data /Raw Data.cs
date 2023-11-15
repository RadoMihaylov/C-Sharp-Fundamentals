using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;

namespace _04._Raw_Data
{
    public class Engine
    {
        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }
    }
    public class Cargo
    {
        public int CargoWeight { get; set; }
        public string CargoType { get; set; }

    }
    public class Car
    {
        public Car(string model, int enginePower,int engineSpeed,  string cargoType, int cargoWeight)
        {
            Model = model;
            Engine = new Engine { EngineSpeed = engineSpeed, EnginePower = enginePower };
            Cargo = new Cargo { CargoWeight = cargoWeight, CargoType = cargoType };
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> list = new List<Car>();
            // <Model> <EngineSpeed> <EnginePower> <CargoWeight> <CargoType>
            for (int i = 0; i < n; i++)
            {
                    string[] input = Console.ReadLine().Split(" ");
                    string model = input[0];
                    int engineSpeed = int.Parse(input[1]);
                    int enginePower = int.Parse(input[2]);
                    int cargoWeight = int.Parse(input[3]);
                    string cargoType = input[4];

                    Car car = new Car(model, enginePower, enginePower, cargoType, cargoWeight);
                    list.Add(car);
                
            }
            string command = Console.ReadLine();
            if (command == "fragile")
            {
                List<Car> fragileCars = list.Where(x => x.Cargo.CargoType == "fragile" && x.Cargo.CargoWeight < 1000).ToList();

                foreach (var fragile in fragileCars)
                {
                    Console.WriteLine(fragile.Model);
                }
            }
            else if (command == "flamable")
            {
                List<Car> flamableCars = list.Where(x => x.Cargo.CargoType == "flamable" && x.Engine.EnginePower > 250).ToList();

                foreach (var flamable in flamableCars)
                {
                    Console.WriteLine(flamable.Model);
                }
            }

        }
    }
}
