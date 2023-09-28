namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            text = text.ToLower();
            char[] letters = text.ToCharArray();

            int totalVowels = Vowels(letters);
            Console.WriteLine(totalVowels);

        }

        static int Vowels(char[] letters)
        {
            int vowelsCount = 0;
            foreach (char c in letters)
            {
                switch (c)
                {
                    case 'a':
                        vowelsCount++;
                        break;
                    case 'e':
                        vowelsCount++;
                        break;
                    case 'i':
                        vowelsCount++;
                        break;
                    case 'o':
                        vowelsCount++;
                        break;
                    case 'u':
                        vowelsCount++;
                        break;
                }
            }
            return vowelsCount;
        }
    }
}
