using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> database = new Dictionary<string, string>();
            string line = Console.ReadLine();
            while (line != "end")
            {
                char[] delim = " ->".ToCharArray();
                string[] rawData = line.Split(delim, StringSplitOptions.RemoveEmptyEntries).ToArray();

                database[rawData[0]] = rawData[1];
                line = Console.ReadLine();
            }
            string defaultValue = Console.ReadLine();
      
            foreach (var kvp in database
                .Where(kvp => kvp.Value != "null")
                .OrderByDescending(kvp => kvp.Value.Length))
            {
                Console.WriteLine($"{kvp.Key} <-> {kvp.Value}");
            }
            foreach (var kvp in database
                .Where(kvp => kvp.Value == "null")
                .Select(kvp => new KeyValuePair<string, string>(kvp.Key, defaultValue)))
            {
                Console.WriteLine($"{kvp.Key} <-> {kvp.Value}");
            }
        }
    }
}
