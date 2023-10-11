namespace _04._List_of_Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<string> list = new List<string> ();

            for (int i = 0; i < count; i++)
            {                
                list.Add(Console.ReadLine());
                list.Sort();
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i + 1}.{list[i]}");
            }
        }
    }
}
