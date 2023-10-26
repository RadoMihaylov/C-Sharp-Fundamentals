/*  
Arrays, Lists, Methods
Swap:Arrays:Methods
Exercise:Databases
Swap:Lists:Databases
Insert:Arrays:0
course start


Arrays, Lists, Methods
Swap:Arrays:Methods
Methods, Lists, Arrays
Exercise:Databases
Methods, Lists, Arrays, Databases, Databases-Exercise
Swap:Lists:Databases
Methods, Databases,Databases-Exercise, Arrays, Lists
Insert:Arrays:0
Methods, Databases,Databases-Exercise, Arrays, Lists
course start
Methods, Databases,Databases-Exercise, Arrays, Lists

 
 */


using System;

namespace _10._SoftUni_Course_Planning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(", ").ToList();
            
            string command;            
            while ((command = Console.ReadLine()) != "course start")
            {              
                string[] argument = command.Split(":");
                switch (argument[0])
                {
                    case "Add":
                        string addLesson = argument[1];
                        if (!list.Contains(addLesson))
                        {
                            list.Add(addLesson);
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    case "Insert":
                        string insertLesson = argument[1];
                        int insertIndex = int.Parse(argument[2]);
                        if (!list.Contains(insertLesson))
                        {
                            list.Insert(insertIndex, insertLesson);
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    case "Remove":
                        string removeLesson = argument[1];
                        string exercise = $"{removeLesson}-Exercise";
                        if (list.Contains(removeLesson))
                        {
                            list.Remove(removeLesson);
                        }
                        
                        if (list.Contains(exercise))
                        {
                            list.Remove(exercise);
                        }
                        break;
                    case "Swap":
                        string firstLesson = argument[1];
                        string secondLesson = argument[2];

                        int firstIndex = list.IndexOf(firstLesson);
                        int secondIndex = list.IndexOf(secondLesson);
                        if ((list.Contains(firstLesson)) && (list.Contains   (secondLesson)))
                        {
                            list[firstIndex] = secondLesson;
                            list[secondIndex] = firstLesson;

                            string firstExercise = $"{firstLesson}-Exercise";
                            string secondExercise = $"{secondLesson}-Exercise";
                            if (list.Contains(firstExercise))
                            {
                                int exerciseIndex1 = list.IndexOf(firstExercise);
                                list.RemoveAt(exerciseIndex1);
                                list.Insert(secondIndex + 1, firstExercise);
                            }
                            if (list.Contains(secondExercise))
                            {
                                int exerciseIndex2 = list.IndexOf(secondExercise);
                                list.RemoveAt(exerciseIndex2);
                                list.Insert(firstIndex + 1, secondExercise);
                            }
                        }                  
                        break;
                    case "Exercise":
                        string ExerciseLesson = argument[1];
                        string extraExerciseLesson = $"{ExerciseLesson}-Exercise";

                        if (list.Contains(ExerciseLesson) && !list.Contains(extraExerciseLesson))
                        {
                            int ExerciseIndex = list.IndexOf(ExerciseLesson);
                            list.Insert(ExerciseIndex + 1, extraExerciseLesson);
                        }
                        else if (!list.Contains(ExerciseLesson))
                        {
                            list.Add(ExerciseLesson);
                            list.Add(extraExerciseLesson);
                        }
                        break;
                    
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{list[i]}");
            }
            
        }
    }
}
