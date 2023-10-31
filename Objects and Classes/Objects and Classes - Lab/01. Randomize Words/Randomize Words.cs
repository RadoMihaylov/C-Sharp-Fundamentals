namespace _01._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ").ToArray();
            Random rnd = new Random();

            for (int i = 0; i < input.Length - 1; i++)
            {
                string word = input[i];
                int random = rnd.Next(0, input.Length);
                string randomWord = input[random];

                input[i] = randomWord;
                input[random] = word;
                
            }

            foreach (string word in input)
            {
                Console.WriteLine(word);
            }
        }
    }
}
