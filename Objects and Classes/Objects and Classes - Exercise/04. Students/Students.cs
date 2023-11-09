using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;

namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();   
            for (int i = 0; i < studentsCount; i++)
            {
                string[] info = Console.ReadLine().Split();
                string firstName = info[0];
                string lastName = info[1];
                float grade = float.Parse(info[2]);

                Student student = new Student(firstName, lastName, grade);
                students.Add(student);
            }
            foreach (var student in students.OrderByDescending(x => x.Grade))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
    }

    public class Student
    {
        public Student(string firstName, string lastName, float grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Grade { get; set; }
    }
}
