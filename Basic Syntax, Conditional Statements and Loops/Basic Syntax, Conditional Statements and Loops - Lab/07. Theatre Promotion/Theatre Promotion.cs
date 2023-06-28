namespace _07.TheatrePromotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int ticketPrice = 0;

            switch (day)
            {
                case "Weekday":
                    if (age <= 18)
                    {
                        ticketPrice = 12;
                    }
                    else if (age <= 64)
                    {
                        ticketPrice = 18;
                    }
                    else if (age <= 122)
                    {
                        ticketPrice = 12;
                    }
                    
                    if (age <= 0)
                    {
                        Console.WriteLine("Error!");
                        return;
                    }
                    break;
                case "Weekend":
                    if (age <= 18)
                    {
                        ticketPrice = 15;
                    }
                    else if (age <= 64)
                    {
                        ticketPrice = 20;
                    }
                    else if (age <= 122)
                    {
                        ticketPrice = 15;
                    }

                    if (age <= 0)
                    {
                        Console.WriteLine("Error!");
                        return;
                    }
                    break;
                case "Holiday":
                    if (age <= 18)
                    {
                        ticketPrice = 5;
                    }
                    else if (age <= 64)
                    {
                        ticketPrice = 12;
                    }
                    else if (age <= 122)
                    {
                        ticketPrice = 10;
                    }

                    if (age <= 0)
                    {
                        Console.WriteLine("Error!");
                        return;
                    }
                    break;
                
                
                    
                    
            }
            Console.WriteLine($"{ticketPrice}$");
        }
    }
}
