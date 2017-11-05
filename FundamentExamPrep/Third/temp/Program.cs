using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Files
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfFiles = int.Parse(Console.ReadLine());
            var database = new Dictionary<string, Dictionary<string, decimal>>();
            for (int i = 0; i < numberOfFiles; i++)
            {
                Match currentMatches = Regex
                    .Match(Console.ReadLine(), @"^(?<root>[^\\]*)([\\].+[\\])(?<fileName>.+(?=\;))\;(?<size>\d+)");

                string root = currentMatches.Groups["root"].ToString();
                string fileName = currentMatches.Groups["fileName"].ToString();
                string sizeStr = currentMatches.Groups["size"].ToString();

                decimal size = decimal.Parse(sizeStr);
                if (!database.ContainsKey(root))
                {
                    database[root] = new Dictionary<string, decimal>();

                }
                database[root][fileName] = size;
                }
            string[] query = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();
            string lookedFileExtention = query[0];
            string lookedRoot = query[2];
            bool isPrinted = false;
            foreach (var root in database.Keys.Where(x => x == lookedRoot))
            {
               
                if (database[root].Count == 0)
                {
                    Console.WriteLine("No");
                    return;
                }

                foreach (var kvp in database[root]
                    .Where(x => x.Key.EndsWith(lookedFileExtention))
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{kvp.Key} - {kvp.Value} KB");
                    isPrinted = true;
                }

            }
            if (!isPrinted)
            {
                Console.WriteLine("No");
            }
        }
    }
}
