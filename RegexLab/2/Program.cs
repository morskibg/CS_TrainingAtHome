using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(^| )\+359(?<del>-| )[2]\k<del>\d{3}\k<del>\d{4}\b";
            MatchCollection numbers = Regex.Matches(input, pattern);
            var matchedPhones = numbers.Cast<Match>().Select(x => x.Value.Trim()).ToArray();
            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
