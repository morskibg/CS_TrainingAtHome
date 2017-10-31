using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hornet_Armada
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            string pattern = @"^(?<lastActivity>\d+)[\s\=]+(?<legionName>.+?)[\s\-\>]+(?<soldierType>.+)\:(?<soldierCount>\d+)$";
            List<Legion> legions = new List<Legion>();
            for (int i = 0; i < numberOfLines; ++i)
            {

                Regex matchInput = new Regex(pattern);
                Match currInput = matchInput.Match(Console.ReadLine());

                long lastActivity = long.Parse(currInput.Groups["lastActivity"].ToString());
                string legionName = currInput.Groups["legionName"].ToString();
                string soldierType = currInput.Groups["soldierType"].ToString();
                long soldierCount = long.Parse(currInput.Groups["soldierCount"].ToString());

                if (!legions.Any(x => x.Name == legionName))
                {
                    Legion newLegion = new Legion();
                    newLegion.Name = legionName;
                    newLegion.Army.Add(soldierType, soldierCount);
                    newLegion.LegionActivity = lastActivity;
                    legions.Add(newLegion);
                }
                else
                {
                    int idx = legions.FindIndex(x => x.Name == legionName);
                    if (!legions[idx].Army.ContainsKey(soldierType))
                    {
                        legions[idx].Army.Add(soldierType, soldierCount);
                    }
                    else
                    {
                        legions[idx].Army[soldierType] += soldierCount;
                    }
                    if (legions[idx].LegionActivity < lastActivity)
                    {
                        legions[idx].LegionActivity = lastActivity;
                    }
                }

            }
            string[] tokens = Console.ReadLine().Split("\\".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            if (tokens.Length > 1)
            {
                long baseActivity = long.Parse(tokens[0]);
                string baseSoldierType = tokens[1];
                foreach (var legion in legions
                    .Where(x => x.LegionActivity < baseActivity)
                    .Where(x => x.Army.ContainsKey(baseSoldierType))
                    .OrderByDescending(x => x.Army[baseSoldierType]))
                {
                    Console.WriteLine($"{legion.Name} -> {legion.Army[baseSoldierType]}");
                }
            }
            else
            {
                string baseSolderType = tokens[0];
                foreach (var legion in legions
                    .Where(x => x.Army.ContainsKey(baseSolderType))
                    .OrderByDescending(x => x.LegionActivity))
                {
                    Console.WriteLine($"{legion.LegionActivity} : {legion.Name}");
                }
            }

        }

        class Legion
        {
            public string Name { get; set; }
            public Dictionary<string, long> Army { get; set; } //
            public long LegionActivity { get; set; }
            public Legion()
            {
                Army = new Dictionary<string, long>();
            }

            
        }
    }
}
