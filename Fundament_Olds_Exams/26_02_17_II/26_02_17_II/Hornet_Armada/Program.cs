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
                //MatchCollection matchInput = Regex.Matches(Console.ReadLine(), pattern);
                Regex matchInput = new Regex(pattern);
                Match currInput = matchInput.Match(Console.ReadLine());

                long lastActivity = long.Parse(currInput.Groups["lastActivity"].ToString());
                string legionName = currInput.Groups["legionName"].ToString();
                string soldierType = currInput.Groups["soldierType"].ToString();
                long soldierCount = long.Parse(currInput.Groups["soldierCount"].ToString());
                
                if(!legions.Any(x => x.Name == legionName))
                {
                    Legion newLegion = new Legion();
                    newLegion.LastActivity = lastActivity;
                    newLegion.Army.Add()
                }
                int t = 0;
            }
            
        }

        class Legion
        {
            public string Name { get; set; }
            public Dictionary<string, long> Army { get; set; }
            public long LastActivity { get; set; }
            public Legion()
            {
                Army = new Dictionary<string, long>();
            }
        }
    }
}
