namespace _07._Company_Users
{
    public class CompanyInfo
    {
        public CompanyInfo(string companyName, List<string> id)
        {
            CompanyName = companyName;
            Id = id;
        }

        public string CompanyName { get; set; }
        public List<string> Id { get; set; }
        
        
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] argument = command.Split(" -> ").ToArray();
                string companyName = argument[0];
                string id = argument[1];

                if (!companies.ContainsKey(companyName))
                {
                    companies[companyName] = new List<string>();
                }
                if (companies[companyName].Contains(id))
                {
                    continue;
                }
                companies[companyName].Add(id);

                
            }
            
            foreach (var item in companies)
            {
                Console.WriteLine($"{item.Key}");
                foreach (var id in item.Value)
                {
                    Console.WriteLine($"-- {id}");                   
                }
            }

        }
    }
}
