using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> database =
                new Dictionary<string, Dictionary<string, string>>();
            List<string> flatten = new List<string>();
            string flattenStr = "";
            string line = Console.ReadLine();
            while (line != "end")
            {
                string[] rawData = line.Split(' ').ToArray();
                if (rawData[0] != "flatten")
                {
                    if (!database.ContainsKey(rawData[0]))
                    {
                        database[rawData[0]] = new Dictionary<string, string> { { rawData[1], rawData[2] } };
                    }
                    else
                    {
                        database[rawData[0]][rawData[1]] = rawData[2];
                    }
                }
                else
                {
                    flattenStr = rawData[1];
                    foreach (var item in database[rawData[1]])
                    {
                        string innerKey = item.Key;
                        string innerValue = item.Value;
                        flatten.Add(innerKey + innerValue);
                    }
                    database[rawData[1]].Clear();

                }
                line = Console.ReadLine();
            }
           
            foreach (var item in database
                .OrderByDescending(x => x.Key.Length))
            {
                Console.WriteLine(item.Key);
                int innerCoun = 1;
                foreach (var innerKey in item.Value
                   .OrderBy(x => x.Key.Length))
                {
                    Console.WriteLine($"{innerCoun}. {innerKey.Key} - {innerKey.Value}");
                    ++innerCoun;
                }
                if (item.Key == flattenStr)
                {
                    for (int i = 0; i < flatten.Count; ++i)
                    {
                        Console.WriteLine($"{innerCoun}. {flatten[i]}");
                        ++innerCoun;
                    }
                }
            }
        }
    }
}
