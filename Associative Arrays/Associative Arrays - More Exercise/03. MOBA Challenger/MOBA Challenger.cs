using System.Reflection;

namespace _03._MOBA_Challenger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> info = new Dictionary<string, Dictionary<string, int>>();

            string command;
            while ((command = Console.ReadLine()) != "Season end")
            {
                string[] arguments = command.Split(" -> ").ToArray();
                if (arguments.Length == 3 )
                {
                    string player = arguments[0];
                    string position = arguments[1];
                    int skill = int.Parse(arguments[2]);

                    if (!info.ContainsKey(player))
                    {
                        info.Add(player, new Dictionary<string, int>());
                    }

                    if (!info[player].ContainsKey(position))
                    {
                        info[player][position] = 0;
                    }

                    if (info[player][position] < skill)
                    {
                        info[(player)][position] = skill;
                    }
                }
                else if (arguments.Length == 3 && arguments[1] == "vs")
                {
                    string player1 = arguments[0];
                    string player2 = arguments[2];

                    if (info.ContainsKey(player1) && info.ContainsKey(player2))
                    {
                        bool haveCommonElement = player1.Intersect(player2).Any();
                        if (haveCommonElement) 
                        {
                            int players1TotalSkill = info[player1].Values.Sum();
                            int players2TotalSkill = info[player1].Values.Sum();
                            if (players1TotalSkill > players2TotalSkill)
                            {
                                info.Remove(player2);
                            }
                            else if (players2TotalSkill > players1TotalSkill)
                            {
                                info.Remove(player1);
                            }
                        }
                    }
                }
            }
            var orderedPlayers = info.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(y => y.Key);
            foreach (var player in orderedPlayers)
            {
                var totalSkill = player.Value.Values.Sum();
                Console.WriteLine($"{player.Key}: {totalSkill} skill");
                foreach (var item in player.Value.OrderByDescending(x => x.Value).ThenBy(y => y.Key))
                {
                    Console.WriteLine($"- {item.Key} <::> {item.Value}");
                }
                totalSkill = 0;
            }

        }
    }
}
