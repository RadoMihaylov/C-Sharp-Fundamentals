namespace _05._Students_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] info = command.Split().ToArray();
                string firstName = info[0];
                string lastName = info[1];
                int age = int.Parse(info[2]);
                string homeTown = info[3];


                Student studentSearch = list.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName); 

                if (studentSearch == null)
                {
                    Student student = new Student(firstName, lastName, age, homeTown);
                    list.Add(student);
                }
                else
                {
                    studentSearch.Age = age;
                    studentSearch.HomeTown = homeTown;
                }

            }
            string cityName = Console.ReadLine();

            foreach (Student student in list)
            {
                if (cityName == student.HomeTown)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }

    public class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }

    }
}
