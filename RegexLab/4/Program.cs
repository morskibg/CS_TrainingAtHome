using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(?<day>\d{2})(?<separator>[\/\-.])(?<month>[A-Z][a-z]{2})\k<separator>(?<year>\d{4})";
            MatchCollection matches = Regex.Matches(input, pattern);
            foreach(Match m in matches)
            {
                Console.WriteLine($"Day: {m.Groups["day"]}, Month: {m.Groups["month"]}, Year: {m.Groups["year"]}");
               
            }
        }
    }
}
