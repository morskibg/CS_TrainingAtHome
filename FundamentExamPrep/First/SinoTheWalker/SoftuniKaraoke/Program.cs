using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftuniKaraoke
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> participats = Console.ReadLine()
                .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();
            List<string> songs = Console.ReadLine().Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToList();
            Dictionary<string, List<string>> awards = new Dictionary<string, List<string>>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "dawn")
                {
                    break;
                }
                string[] query = input.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string wolfSinger = query[0].Trim();
                string song = query[1].Trim();
                string award = query[2].Trim();

                if (!awards.ContainsKey(wolfSinger))
                {
                    if (participats.Contains(wolfSinger) && songs.Contains(song))
                    {
                        awards[wolfSinger] = new List<string> {award};
                    }
                }
                else if (participats.Contains(wolfSinger) && songs.Contains(song) && !awards.Values.Any(x => x.Contains(award)))
                {
                    awards[wolfSinger].Add(award);
                }
            }
            if (awards.Count == 0)
            {
                Console.WriteLine("No awards");
                return;
            }
            foreach (var wolfSinger in awards.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{wolfSinger.Key}: {wolfSinger.Value.Count} awards");
                foreach (var award in wolfSinger.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"--{award}");
                }
            }
        }
    }
}
