namespace _04._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <int> list = Console.ReadLine().
                Split().Select(int.Parse).
                ToList();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] argument = command.Split();
                switch (argument[0])
                {
                    case "Add":
                        int addNumber = int.Parse(argument[1]);
                        list.Add(addNumber);
                        break;
                    case "Insert":
                        int insertNumber = int.Parse(argument[1]);
                        int index = int.Parse(argument[2]);
                        if (index < 0 || index >= list.Count)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        else
                        {
                            list.Insert(index, insertNumber);
                        }
                        break;
                    case "Remove":
                        int removeNumber = int.Parse(argument[1]);
                        if (removeNumber < 0 || removeNumber >= list.Count)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        list.RemoveAt(removeNumber);
                        break;
                    case "Shift":
                        int count = int.Parse(argument[2]);
                        if (argument[1] == "left")
                        {
                            count %= list.Count;
                            List <int> shifted = list.GetRange(0, count);
                            list.RemoveRange(0, count);
                            list.InsertRange(list.Count, shifted);
                        }
                        else
                        {
                            count %= list.Count;
                            int lastIndex = list.Count - count;
                            List<int> shifted = list.GetRange(lastIndex, count);
                            list.RemoveRange(lastIndex, count);
                            list.InsertRange(0, shifted);
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
