using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Roli_The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> RoliData =
                new Dictionary<string, Dictionary<string, List<string>>>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input.Equals("Time for Code"))
                {
                    break;
                }
                string ID = Regex.Match(input, @"^\d+")
                    .Value;
                string eventName = Regex.Match(input, @"(?<=\#)(\w+(?=\s|$))")
                    .Value
                    .Trim();
                if (eventName.Length == 0)
                {
                    continue;
                }
                var participants = Regex.Matches(input, @"(?:@[\dA-Za-z'\-]+(?=\s|$|\@))")
                    .Cast<Match>()
                    .Select(x => x.Value.Trim())
                    .Distinct()
                    .ToList();

                if (!RoliData.ContainsKey(ID))
                {
                    RoliData[ID] = new Dictionary<string, List<string>>();
                    RoliData[ID].Add(eventName, participants);
                }
                else
                {
                    if (RoliData[ID].Keys.Contains(eventName))
                    {
                        RoliData[ID][eventName].AddRange(participants);
                        RoliData[ID][eventName] = RoliData[ID][eventName].Distinct().ToList();
                    }
                }
                int t = 0;

            }
            foreach (var id in RoliData.OrderByDescending(x => x.Value.Values.First().Count))
            {

                foreach (var currEvent in id.Value)
                {
                    Console.WriteLine($"{currEvent.Key} - {currEvent.Value.Count}");
                    foreach (var participant in currEvent.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"{participant}");
                    }
                }
            }
           
        }
    }
}
