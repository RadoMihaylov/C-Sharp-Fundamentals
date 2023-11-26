namespace _06._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> dic = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!dic.ContainsKey(studentName))
                {
                    dic.Add(studentName, new List<double>() { grade});
                }
                else
                {
                    dic[studentName].Add(grade);
                }
            }
            Dictionary<string, double> dicOver4 = new Dictionary<string, double>();

            foreach (var kvp in dic)
            {
                double average = kvp.Value.Average();
                if (average >= 4.5)
                {
                    dicOver4[kvp.Key] = average;
                }
            }

            foreach (var kvp in dicOver4)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:F2}");
            }

        }
    }
}
