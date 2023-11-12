namespace _02._Oldest_Family_Member
{
    public class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }

    }
    public class Family
    {
        public List<Person> listOfPeoples;
        public Family()
        {
            listOfPeoples = new List<Person>();
        }
        public void AddMember(Person member)
        {
            listOfPeoples.Add(member);
        }
        public Person GetOldestMember()
        {
            int maxAge = -1;
            Person oldestMember = null;

            foreach (Person person in listOfPeoples)
            {
                if (person.Age > maxAge)
                {
                    maxAge = person.Age;
                    oldestMember = person;
                }
            }
            return oldestMember;
        }


        internal class Program
        {
            static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine());
                Family family = new Family();
                for (int i = 0; i < n; i++)
                {
                    string[] arguments = Console.ReadLine().Split(" ");
                    string name = arguments[0];
                    int age = int.Parse(arguments[1]);
                    if (age < 0)
                    {
                        continue;
                    }

                    Person person = new Person(name, age);
                    family.AddMember(person);
                }

                Person oldestMember = family.GetOldestMember();
                Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
            }
        }

    }
}
