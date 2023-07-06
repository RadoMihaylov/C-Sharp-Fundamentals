namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;

                   /* Friday Saturday Sunday
            Students 8.45     9.80    10.46
            Business 10.90    15.60    16
             Regular 15       20     22.50 */




            switch (groupType)
            {
                case "Students":
                    if (day == "Friday")
                    {
                        price = peopleCount * 8.45;
                    }
                    else if (day == "Saturday")
                    {
                        price = peopleCount * 9.80;
                    }
                    else if (day == "Sunday")
                    {
                        price =peopleCount * 10.46;
                    } 
                    if (peopleCount >= 30)
                    {
                        price *= 0.85;
                    }
                    break;
                case "Business":
                    if (day == "Friday")
                    {
                        price = peopleCount * 10.9;
                    }
                    else if (day == "Saturday")
                    {
                        price = peopleCount * 15.6;
                    }
                    else if (day == "Sunday")
                    {
                        price = peopleCount * 16;
                    }

                    if (peopleCount >= 100)
                    {
                        price -= 10 * (day == "Friday" ? 10.9 : (day == "Saturday" ? 15.6 : 16));
                    }
                    break;
                case "Regular":
                    if (day == "Friday")
                    {
                        price = peopleCount * 15;
                    }
                    else if (day == "Saturday")
                    {
                        price = peopleCount * 20;
                    }
                    else if (day == "Sunday")
                    {
                        price = peopleCount * 22.5;
                    }
                    if (peopleCount >= 10 && peopleCount <= 20)
                    {
                        price *= 0.95;
                    }
                    break;

            }
            Console.WriteLine($"Total price: {price:f2}");



        }
    }
}
