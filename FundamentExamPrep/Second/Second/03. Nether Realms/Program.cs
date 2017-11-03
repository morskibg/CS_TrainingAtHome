﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            var demons = Regex
                .Matches(Console.ReadLine(), @"([^ ,]+)")
                .Cast<Match>()
                .Select(x => x.Value.Trim())
                .OrderBy(x => x)
                .ToList();

            foreach (var demon in demons)
            {
                var health = Regex.Matches(demon, @"([^ +-.*/0-9])")
                    .Cast<Match>()
                    .Select(x => (int) x.Value[0])
                    .Sum();

                var damage = Regex.Matches(demon, @"-?\d+(?:\.\d+)?")
                    .Cast<Match>()
                    .Select(x => double.Parse(x.Value))
                    .Sum();

                var mult = Regex.Matches(demon, @"(\*)").Count;

                var div = Regex.Matches(demon, @"(\/)").Count;

                damage *= Math.Pow(2, mult);

                damage /= Math.Pow(2, div);

                Console.WriteLine($"{demon} - {health} health, {damage:F2} damage");

            }
        }
    }
}
