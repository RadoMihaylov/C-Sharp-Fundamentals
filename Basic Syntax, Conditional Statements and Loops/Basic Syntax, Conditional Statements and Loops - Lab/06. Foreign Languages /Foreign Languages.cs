namespace _06.ForeignLanguages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();

            switch (country)
            {
                case "Spain":
                    Console.WriteLine("Spanish");
                    break;
                case "Argentina":
                    Console.WriteLine("Spanish");
                    break;
                case "Mexico":
                    Console.WriteLine("Spanish");
                    break;
                case "USA":
                    Console.WriteLine("English");
                    break;
                case "England":
                    Console.WriteLine("English");
                    break;
                    default: Console.WriteLine("unknown"); break;

            }

        }
    }
}
