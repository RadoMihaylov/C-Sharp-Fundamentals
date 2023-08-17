namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagonsCount = int.Parse(Console.ReadLine());

            int[] wagon = new int[wagonsCount];

            for (int i = 0; i < wagon.Length; i++)
            {
                int passangers = int.Parse(Console.ReadLine());

                wagon[i] = passangers;
            }

            Console.WriteLine(string.Join(" ", wagon));
           
            Console.WriteLine(wagon.Sum());
           
        }
    }
}
