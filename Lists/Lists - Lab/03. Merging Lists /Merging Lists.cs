namespace _03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> bigerList = new List<int>();

            if (firstList.Count > secondList.Count)
            {
                bigerList.AddRange(firstList);
            }
            else
            {
                bigerList.AddRange(secondList);
            }
            List<int> newList = new List<int>();
            for (int i = 0; i < bigerList.Count; i++)
            {
                if (firstList.Count  > i)
                {
                    newList.Add(firstList[i]);
                }

                if (secondList.Count > i)
                {
                    newList.Add(secondList[i]);
                }

            }

            Console.WriteLine(string.Join(" ", newList));
        }
    }
}
