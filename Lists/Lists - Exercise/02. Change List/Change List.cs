namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>(Console.ReadLine().
               Split().
               Select(int.Parse).
               ToList());

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] argument = command.Split(' ');
                switch (argument[0])
                {
                    case "Delete":
                        list.RemoveAll(n => n == (int.Parse(argument[1])));
                        break;
                    case "Insert":
                        int element = int.Parse(argument[1]);    
                        int index = int.Parse(argument[2]);
                        list.Insert(index, element);
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
