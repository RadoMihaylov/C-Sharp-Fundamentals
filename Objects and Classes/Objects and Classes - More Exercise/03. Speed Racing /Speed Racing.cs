namespace _03._Speed_Racing
{
    public class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumation, int distance)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumation = fuelConsumation;
            Distance = 0;
        }

        public string Model { get; set; } 
        public double FuelAmount { get; set; }
        public double FuelConsumation { get; set; }
        public double Distance { get; set; }

        public bool Moved (double amountOfKm)
        {
            double neededFuel = amountOfKm * FuelConsumation;
            if (FuelAmount >= neededFuel)
            {
                FuelAmount -= neededFuel;
                Distance += amountOfKm;
                return true;
            }

            return false;
        }
    }
    // model, fuel amount, fuel consumption per kilometer and traveled distance
    internal class Program
    {
        static void Main(string[] args)
        {
            // <Model> <FuelAmount> < FuelConsumptionFor1km >
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Car> cars = new Dictionary<string, Car>();
            for (int i = 0; i < n; i++)
            {
                string[] arguments = Console.ReadLine().Split(" ");
                string model = arguments[0];
                double fuelMoment = double.Parse(arguments[1]);
                double fuelConsumation = double.Parse(arguments[2]);
                if(cars.ContainsKey(model))
                {
                    continue;
                }
                Car newCar = new Car(model, fuelMoment, fuelConsumation, 0);
                cars[model] = newCar;
            }
            string command;
            while((command = Console.ReadLine()) != "End")
            {
                string[] arguments = command.Split(" ").ToArray();
                string model = arguments[1];
                double amountOfKm = double.Parse(arguments[2]);
                if (cars[model].Moved(amountOfKm))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
            }

            foreach (var car in cars.Values)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.Distance}");
            }
        }
    }
}
