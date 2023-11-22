namespace _02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            foreach (string word in input)
            {
                string lowerCaseWord = word.ToLower();
                if (!dictionary.ContainsKey(lowerCaseWord))
                {
                    dictionary[lowerCaseWord] = 1;
                }
                else
                {
                    dictionary[lowerCaseWord]++;
                }
            }

            foreach (var word in dictionary)
            {
                if (word.Value % 2 != 0)
                {
                    Console.Write(word.Key + " ");
                }
            }
        }
    }
}
