namespace _01._Company_Roster
{
    public class Employee
    {
        public Employee(string name, double salary, string department)
        {
            Name = name;
            Salary = salary;
            Department = department;
        }

        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Employee> list = new List<Employee>();
            for (int i = 0; i < n; i++)
            {
                string[] arguments = Console.ReadLine().Split(" ").ToArray();
                string name = arguments[0];
                double salary = double.Parse(arguments[1]);
                string department = arguments[2];
                Employee employee  = new Employee(name, salary, department);
                list.Add(employee); 
            }
            double maxSalary = list.Max(t => t.Salary);
            var DeparmentName = list.FirstOrDefault(emp => emp.Salary == maxSalary);
            Console.WriteLine($"Highest Average Salary: {DeparmentName.Department}");

            var orderByDescending = list.Where(emp => emp.Department == DeparmentName.Department).OrderByDescending(emp => emp.Salary);

            foreach (Employee emp in orderByDescending)
            {
                Console.WriteLine($"{emp.Name} {emp.Salary:f2}");
            }

        }
    }
}
