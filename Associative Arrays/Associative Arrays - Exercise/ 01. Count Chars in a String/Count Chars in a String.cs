namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                char character = word[i];
                if (character == ' ')
                {
                    continue;
                }
                if (!dic.ContainsKey(character))
                {
                    dic.Add(character, 1);
                } 
                else
                {
                    dic[character]++;
                }
            }

            foreach (KeyValuePair<char, int> item in dic)
            {
                char symbole = item.Key;
                int count = item.Value;

                Console.WriteLine($"{symbole} -> {count}");
            }
        }
    }
}
