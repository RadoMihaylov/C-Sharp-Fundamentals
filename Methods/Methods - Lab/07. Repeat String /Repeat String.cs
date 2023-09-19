namespace _07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int repeat = int.Parse(Console.ReadLine());
            string fullText = RepeatTimes(text, repeat);
            Console.WriteLine(fullText);
        }

        static string RepeatTimes(string text, int repeat)
        {
            string result = "";
            for (int i = 0; i < repeat; i++)
            {
                result += text;
            }
            return result;
            
        }
    }
}
