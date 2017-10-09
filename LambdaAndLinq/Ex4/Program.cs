using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> playersDatabase = new Dictionary<string, Dictionary<string, int>>();
            string line = Console.ReadLine();
            while (line != "stop the game")
            {
                string[] rawData = line.Split('|').ToArray();
                if (!playersDatabase.ContainsKey(rawData[1]))
                {
                    playersDatabase[rawData[1]] =
                        new Dictionary<string, int> { { rawData[0], int.Parse(rawData[2]) } };
                }
                else if(playersDatabase[rawData[1]].Count <= 3){
                    playersDatabase[rawData[1]].Add(rawData[0], int.Parse(rawData[2]));
                }
                line = Console.ReadLine();
            }
            foreach( var currTeam in playersDatabase
                .Where(kvp => kvp.Value.Count >= 3)
                .OrderByDescending(kvp => kvp.Value.Values.Sum())
                .ThenByDescending(kvp => kvp.Value.Values))
            {
                Console.WriteLine($"{currTeam.Key} - {currTeam.Value.Values.Sum()}");
            }
        }
    }
}
