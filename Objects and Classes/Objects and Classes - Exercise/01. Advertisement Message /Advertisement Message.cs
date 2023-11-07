/*
Phrases – {"Excellent product.", "Such a great product.", "I always use that
product.", "Best product of its category.", "Exceptional product.", "I can't
live without this product."}
• Events – {"Now I feel good.", "I have succeeded with this product.", "Makes
miracles. I am happy of the results!", "I cannot believe but now I feel
awesome.", "Try it yourself, I am very satisfied.", "I feel great!"}
• Authors – {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"}
• Cities – {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"}
 
 */


namespace _01._Advertisement_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] phrases = {"Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can'tlive without this product."};
            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random random= new Random();
            for (int i = 0; i < n; i++)
            {
                string phrase = phrases[random.Next(phrases.Length)];
                string randomEvent = events[random.Next(events.Length)];
                string author = authors[random.Next(authors.Length)];
                string city = cities[random.Next(cities.Length)];

                Console.WriteLine($"{phrase} {randomEvent} {author} – {city}.");
            }
        }
    }
}
