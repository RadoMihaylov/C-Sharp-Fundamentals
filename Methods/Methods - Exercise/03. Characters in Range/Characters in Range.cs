namespace _03._Characters_in_Range
{
    internal class Program
    {
        public static void Main()
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());

            ElementsBetween(start, end);
        }

        static void ElementsBetween (char start, char end)
        {
            if (start >end)
            {
                char exchange = start;
                start = end;
                end = exchange;
            }

            for (char i = start; i <= end - 1; i++)
            {
                if (i == start)
                {
                    continue;
                }
                Console.Write(i + " ");
            }
        } 
    }
}
