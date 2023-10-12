namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = new List<int>(Console.ReadLine().
                Split().
                Select(int.Parse).
                ToList());
            int maxCapacity = int.Parse(Console.ReadLine());

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] argument = command.Split(" ");
                if (argument[0] == "Add")
                {
                    int passengersToAdd = int.Parse(argument[1]);
                    wagons.Add(passengersToAdd);
                }
                else
                {
                    int passengers = int.Parse(argument[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passengers <= maxCapacity)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", wagons));

        }
    }
}
