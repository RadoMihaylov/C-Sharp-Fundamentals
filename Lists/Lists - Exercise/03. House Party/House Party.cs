namespace _03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List <string> list = new List<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string command = Console.ReadLine();
                string[] argument = command.Split();
                string name = argument[0];
                string action = argument[2];

                switch (action)
                {
                    case "going!":
                        if (!list.Contains(name))
                        {
                            list.Add(name);
                        }
                        else
                        {
                            Console.WriteLine($"{name} is already in the list!");
                        }
                        break;
                    case "not":
                        if (list.Contains(name))
                        {
                            list.Remove(name);
                        }
                        else
                        {
                            Console.WriteLine($"{name} is not in the list!");
                        }
                        break;
                }
            }
            
            
            foreach (string guests in list)
            {
                Console.WriteLine(guests);

            }
        }
    }
}
