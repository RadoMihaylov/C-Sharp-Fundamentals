namespace _03._Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary <string, List<string>> dictionary = new Dictionary<string, List<string>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                if (!dictionary.ContainsKey(word))
                {
                    dictionary.Add(word, new List<string>());
                }

                dictionary[word].Add(synonym);
                
            }

            foreach (var word in dictionary)
            {
                string key = word.Key;
                List<string> list = word.Value;
                string synonyms = string.Join(", ", list);

                Console.WriteLine($"{key} - {synonyms}");
            }

            

        }
    }
}
