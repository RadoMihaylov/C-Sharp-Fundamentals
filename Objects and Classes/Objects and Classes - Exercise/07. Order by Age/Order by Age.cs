using System;

namespace _07._Order_by_Age
{
    /*
George 123456 20
Kure 123456 56       
Stephen 524244 10
End
    */


    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            List<StudentInfo> students = new List<StudentInfo>();   
            while ((command = Console.ReadLine()) != "End")
            {
                string[] data = command.Split().ToArray();
                string name = data[0];
                int id = int.Parse(data[1]);
                int age = int.Parse(data[2]);

                StudentInfo existingPerson = students.FirstOrDefault(x => x.Id == id);
                if (existingPerson != null)
                {
                    existingPerson.Name = name;
                    existingPerson.Age = age;
                }
                else
                {
                    StudentInfo newStudent = new StudentInfo(name, id, age);
                    students.Add(newStudent);
                }
            }

            List<StudentInfo> sortedPeople = students.OrderBy(p => p.Age).ToList();
            foreach (var student in sortedPeople)
            {
                Console.WriteLine($"{student.Name} with ID: {student.Id} is {student.Age} years old.");
            }
        }
    }

    public class StudentInfo
    {
        public StudentInfo(string name, int id, int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }

        public string Name { get; set; }
        public int Id { get; set; }
        public int Age { get; set; }
    }
}
