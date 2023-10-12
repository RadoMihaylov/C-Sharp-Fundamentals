using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>(Console.ReadLine().
               Split().
               Select(int.Parse).
               ToList());
            bool listModified = false;
            string[] command = Console.ReadLine().Split();

            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "Contains":
                        int containNumber = int.Parse(command[1]);
                        Console.WriteLine(list.Contains(containNumber) ? "Yes" : "No such number");
                        break;
                    case "PrintEven":
                        List<int> evenList = new List<int>();
                        foreach (int i in list)
                        {
                            if (i % 2 == 0)
                            {
                                evenList.Add(i);
                            }
                        }
                        Console.WriteLine(string.Join(" ", evenList));
                        break;
                    case "PrintOdd":
                        List<int> oddList = new List<int>();
                        foreach (int i in list)
                        {
                            if (i % 2 != 0)
                            {
                                oddList.Add(i);
                            }
                        }
                        Console.WriteLine(string.Join(" ", oddList));
                        break;
                    case "GetSum":
                        Console.WriteLine(list.Sum());
                        break;
                    case "Filter":
                        string condition = command[1];
                        int conditionNumber = int.Parse(command[2]);
                        List<int> filteredNums = FilterNumbers(list, condition, conditionNumber);
                        Console.WriteLine(string.Join(" ", filteredNums));
                        break;
                }
                command = Console.ReadLine().Split();
            }
            if (listModified)
            {
                Console.WriteLine(string.Join(" ", list));
            }
        }

        static List<int> FilterNumbers(List<int> list, string condition, int conditionNumber)
        {
            switch (condition)
            {
                case "<":
                    return list.Where(n => n < conditionNumber).ToList();
                case "<=":
                    return list.Where(n => n <= conditionNumber).ToList();
                case ">":
                    return list.Where(n => n > conditionNumber).ToList();
                case ">=":
                    return list.Where(n => n >= conditionNumber).ToList();
                default:
                    return list;
            }
        }
    }
}
