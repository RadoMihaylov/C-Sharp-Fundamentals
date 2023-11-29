using System.Security.Cryptography.X509Certificates;

namespace _02._Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            1.We receive input lines in format:
                 "{username} -> {contest} -> {points}"
                    string       string        int
            2.We need to track info for every contest and individual statics for every user!
              a) Check if contest alredy exist, if not, add it!
              b) Check if current user alredy participant in the contest!
                 -> if they exist take the higher score
                 -> if not, add it
            3.We need take and individual statics - total points of all contests.
            4.When we receive "no more time", the programm END.
                a) We print contests in input order.
                     -> for each contest we print the participants by descending order (points) and by ascending number (names)
                b) After all, we should print individual statistics for every participant, ordered by total points in descending order, and then by alphabetical order
             */

            string command;
            Dictionary<string, Dictionary<string, int>> info = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> users = new Dictionary<string, int>();

            while ((command = Console.ReadLine()) != "no more time")
            {
                string[] argument = command.Split(" -> ").ToArray();
                string username = argument[0];
                string contestName = argument[1];
                int points = int.Parse(argument[2]);
                if (!info.ContainsKey(contestName))
                {
                    info.Add(contestName, new Dictionary<string, int> { });
                }
                
                if (!info[contestName].ContainsKey(username))
                {
                    info[contestName][username] = 0;
                }
                if (!users.ContainsKey(username))
                {
                    users[username] = 0;
                }
                if (info[contestName][username] < points)
                {
                    info[contestName][username] = points;
                }

                if (!users.ContainsKey(username))
                {
                    users[username] = 0;
                }
            }

            foreach (var contest in info)
            {
                foreach (var participant in contest.Value)
                {
                    users[participant.Key] += participant.Value;
                }
            }

            foreach (var contest in info)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");
                int position = 1;
                foreach (var participant in contest.Value.OrderByDescending(x => x.Value).ThenBy(p => p.Key))
                {
                    Console.WriteLine($"{position}. {participant.Key} <::> {participant.Value}");
                    position++;
                }
            }
            Console.WriteLine("Individual standings:");
            int pos = 1;
            int userPosition = 1;
            foreach (var user in users.OrderByDescending(u => u.Value).ThenBy(u => u.Key))
            {
                Console.WriteLine($"{userPosition}. {user.Key} -> {user.Value}");
                userPosition++;
            }

        }
    }
}
