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
            string pattern = @"^(?<lastActivity>\d+)[\s\=]+(?<legionName>\w+)[\s\-\>]+(?<soldierType>\w+)\:(?<soldierCount>\d+)$";
            List<Legion> legions = new List<Legion>();
            for (int i = 0; i < numberOfLines; ++i)
            {
                
                Regex matchInput = new Regex(pattern);
                Match currInput = matchInput.Match(Console.ReadLine());

                long lastActivity = long.Parse(currInput.Groups["lastActivity"].ToString());
                string legionName = currInput.Groups["legionName"].ToString();
                string soldierType = currInput.Groups["soldierType"].ToString();
                long soldierCount = long.Parse(currInput.Groups["soldierCount"].ToString());
                
                if(!legions.Any(x => x.Name == legionName))
                {
                    Legion newLegion = new Legion();
                    Dictionary<long, long> activityAndcount = new Dictionary<long, long> {{ lastActivity, soldierCount}}; 
                    newLegion.Army.Add(soldierType, activityAndcount);
                    newLegion.Name = legionName;
                    legions.Add(newLegion);
                }
                else
                {
                    int idxOfExistingLegion = legions.FindIndex(x => x.Name == legionName);
                    if (!legions[idxOfExistingLegion].Army.ContainsKey(soldierType))
                    {
                        legions[idxOfExistingLegion].Army[soldierType] =
                            new Dictionary<long, long> {{lastActivity, soldierCount}};
                    }
                    else
                    {
                        long currActivity = legions[idxOfExistingLegion].Army[soldierType].Keys.First();
                        long currSoldiersCount = legions[idxOfExistingLegion].Army[soldierType].Values.First();
                        Dictionary<long, long> newInnerDict = new Dictionary<long, long>();
                        currSoldiersCount += soldierCount;

                        if (currActivity < lastActivity)
                        {
                            newInnerDict[lastActivity] = currSoldiersCount;
                        }
                        else
                        {
                            newInnerDict[currActivity] = currSoldiersCount;
                        }
                    }
                }
            }
            string command = Console.ReadLine();
            
            if (command.Contains(@"\"))
            {
               
            }
            else
            {
                
            }

        }

        class Legion
        {
            public string Name { get; set; }
            public Dictionary<string, Dictionary<long, long>> Army { get; set; }
            
            public Legion()
            {
                Army = new Dictionary<string, Dictionary<long, long>>();
            }

            
        }
    }
}
