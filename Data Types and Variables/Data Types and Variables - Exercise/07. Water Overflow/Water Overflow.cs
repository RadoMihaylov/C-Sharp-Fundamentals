namespace _07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte capacity = 255;
            int n = int.Parse(Console.ReadLine());
            ushort sum = 0; 

            for (int i = 0; i < n; i++)
            {
                short quantities = short.Parse(Console.ReadLine());
                sum += (ushort)quantities;

                if (sum > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sum -= (ushort)quantities;
                    continue;
                }

            }
            Console.WriteLine(sum);
        }
    }
}
