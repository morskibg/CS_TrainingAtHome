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
            var rootAndfileName = new Dictionary<string, List<string>>();
            var fileNamesAndSize = new Dictionary<string, int>();
            for (int i = 0; i < numberOfFiles; i++)
            {
                MatchCollection currentMatches = Regex
                    .Matches(Console.ReadLine(), @"^(?<root>\w+).+?(?<fileName>\w+\.\w+)\;(?<size>\d+)");
                string root = currentMatches.Cast<Match>().Select(x => x.Groups["root"]).ToString();
                string fileName = currentMatches.Cast<Match>().Select(x => x.Groups["fileName"]).ToString();
                string sizeStr = currentMatches.Cast<Match>().Select(x => x.Groups["size"]).ToString();
                int size = int.Parse(sizeStr);
                if (!rootAndfileName.ContainsKey(root))
                {
                    rootAndfileName[root] = new List<string>() {fileName};
                }
                else
                {
                    if (rootAndfileName[root].Contains(fileName))
                    {
                        rootAndfileName[root].Remove(fileName);
                        rootAndfileName[root].Add(fileName);
                    }
                }


            }
        }
    }
}
