using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
           
            HashSet<char> uniqueSym = new HashSet<char>();
            StringBuilder resultString = new StringBuilder();
            List<string> rawStrings = Regex.Matches(Console.ReadLine(), @"(.+?(?=\d)\d+)")
                .Cast<Match>()
                .Select(x => x.Value)
                .ToList();
            foreach (var currString in rawStrings)
            {
                int repeater = int.Parse(Regex.Match(currString, @"\d+").Value);
                string str = Regex.Match(currString, @"[^\d]+").Value.ToUpper();
                for (int i = 0; i < repeater; ++i)
                {
                    resultString.Append(str);
                }
                if (repeater > 0)
                {
                    uniqueSym.UnionWith(str);
                }
                
            }
            Console.WriteLine($"Unique symbols used: {uniqueSym.Count}");
            Console.WriteLine(resultString);
            int t = 0;
        }
    }
}
