namespace _04._Word_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] word = Console.ReadLine().
                Split().
                Where(w => w.Length % 2 == 0).
                ToArray();

            foreach (var word2 in word)
            {
                Console.WriteLine(word2);
            }

        }
    }
}
