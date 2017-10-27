﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\b(?:0x)?[0-9A-F]+\b";
            MatchCollection matchedHexCollection = Regex.Matches(input, pattern);
            var matchedHex = matchedHexCollection.Cast<Match>().Select(x => x.Value.Trim()).ToArray();
            Console.WriteLine(string.Join(" ", matchedHex));
        }
    }
}
