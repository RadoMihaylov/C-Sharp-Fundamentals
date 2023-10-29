using System.Xml.Linq;

namespace _08._Anonymous_Threat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ").ToArray();
            List<string> list = new List<string>(input);

            string command;
            while ((command = Console.ReadLine()) != "3:1")
            {
                string[] arguments = command.Split(" ");
                string commandArgument = arguments[0];
                switch (commandArgument)
                {
                    case "merge":
                        int startIndex = int.Parse(arguments[1]);
                        int endIndex = int.Parse(arguments[2]);
                        
                        startIndex = Math.Max(0, Math.Min(startIndex, list.Count - 1));
                        endIndex = Math.Max(0, Math.Min(endIndex, list.Count - 1)); 
                        

                        string merged = string.Concat(list.GetRange(startIndex, endIndex - startIndex + 1));
                        list.RemoveRange(startIndex, endIndex - startIndex + 1);
                        list.Insert(startIndex, merged);                    
                        break;
                    case "divide":
                        int index = int.Parse(arguments[1]);
                        int partitions = int.Parse(arguments[2]);
                        
                        index = Math.Max(0, Math.Min(index, list.Count - 1));
                        string element = list[index];
                        int substringLength = (int)Math.Ceiling((double)element.Length / partitions);
                        List<string> divided = new List<string>();
                        for (int i = 0; i < partitions - 1; i++)
                        {
                            string substring = element.Substring(0, substringLength);
                            divided.Add(substring);
                            element = element.Remove(0, substringLength);
                        }

                        divided.Add(element);

                        list.RemoveAt(index);
                        list.InsertRange(index, divided);
                        break;
                }

            }
                Console.WriteLine(string.Join(" ", list));
        }
    }
}
