using System.ComponentModel.DataAnnotations;
using System.Data;

namespace _10._LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int fieldSize = int.Parse(Console.ReadLine());
            //int[] bugIndexeOnTheField = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //int[] field = new int[fieldSize];

            //for (int i = 0; i < bugIndexeOnTheField.Length; i++)
            //{
            //    int bugIndex = bugIndexeOnTheField[i];
            //    if (bugIndex >= 0 && bugIndex < fieldSize)
            //    {
            //        field[i] = bugIndex;
            //    }
            //}

            //string command = "";
            //while ((command = Console.ReadLine()) != "end")
            //{
            //    string[] argument = command.Split();
            //    int bugIndex = int.Parse(argument[0]);
            //    string direction = (argument[1]);
            //    int fly = int.Parse(argument[2]);

            //    if (bugIndex < 0 || bugIndex > field.Length || field[bugIndex] == 0)
            //    {
            //        continue;
            //    }

            //    if (direction == "right")
            //    {
            //        int landIndex = fly + bugIndex;

            //        if (landIndex > field.Length - 1)
            //        {
            //            continue;
            //        }

            //        if (field[landIndex] == 1)
            //        {
            //            while (field[landIndex] == 1)
            //            {
            //                landIndex += fly;
            //                if (landIndex > field.Length - 1)
            //                {
            //                    break;
            //                }
            //            }

            //        }

            //        if (landIndex <= field.Length - 1)
            //        {
            //            field[landIndex] = 1;
            //        }

            //    }
            //    else if (direction == "left")
            //    {
            //        int landIndex = bugIndex - fly;

            //        if (landIndex < 0)
            //        {
            //            continue;
            //        }

            //        if ((field[landIndex] == 1))
            //        {
            //            while (field[landIndex] == 1)
            //            {
            //                landIndex-= fly;
            //                if (landIndex < 0)
            //                {
            //                    break;
            //                }
            //            }

            //        }


            //        if (field[landIndex] >= 0)
            //        {
            //            field[landIndex] = 1;
            //        }
            //    }

            //}
            //Console.WriteLine(string.Join(" ", field));


            /* fieldSize = the places where the bugs can be founded 
             * flyLenght = if we dont have the command "end", with flyLength we cgange our position
             * we will have array with [int, string, int] -> [bugIndex, direction, 
               fly Length]
            landIndex is position after sum of bugIndex + flyLength
            if landIndex == 1 -> continues to fly (+ flyLength);
            if landIndex > fieldSize - 1 && field[bugIndex] == 0 -> continue;
                */

            int fieldSize = int.Parse(Console.ReadLine());
            int[] bugIndexOnTheFiled = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] field = new int[fieldSize];

            for (int i = 0; i < bugIndexOnTheFiled.Length; i++)
            {
                int bugIndex = bugIndexOnTheFiled[i];
                if (bugIndex < field.Length && bugIndex >= 0)
                {
                    field[bugIndex] = 1;
                }
            }
            string command = "";
            while ((command = Console.ReadLine()) != "end")
            {
                string[] argument = command.Split();
                int bugIndex = int.Parse(argument[0]);
                string direction = argument[1];
                int flyLength = int.Parse(argument[2]);
                if (bugIndex < 0 || bugIndex > field.Length - 1 || field[bugIndex] == 0)
                {
                    continue;
                }
                field[bugIndex] = 0;
               
                if (direction == "right")
                {
                    int landIndex = flyLength + bugIndex;
                    if (landIndex > field.Length - 1)
                    {
                        continue;
                    }
                    
                    if (field[landIndex] == 1)
                    {
                        while (field[landIndex] == 1)
                        {
                            landIndex += flyLength;
                            if (landIndex > field.Length - 1)
                            {
                                break;
                            }
                        }
                    }

                    if (landIndex <= field.Length - 1)
                    {
                        field[landIndex] = 1;
                    }
                }
                else if (direction == "left")
                {
                    int landIndex = bugIndex - flyLength;

                    if (landIndex < 0)
                    {
                        continue;
                    }

                    if (field[landIndex] == 1)
                    {
                        while (field[landIndex] == 1)
                        {
                            landIndex -= flyLength;
                            if (landIndex < 0)
                            {
                                break;
                            }
                        }
                    }

                    if (landIndex >= 0 )
                    {
                        field[landIndex] = 1;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
