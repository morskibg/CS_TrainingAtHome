using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> logsDatabase = new Dictionary<string, List<double>>();
            string input = Console.ReadLine();
            while(input != "chop chop")
            {
                char[] delim = " ->".ToCharArray();
                string[] rawData = input.Split(delim, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (!logsDatabase.ContainsKey(rawData[0]))
                {
                    logsDatabase[rawData[0]] = new List<double>();
                }
                logsDatabase[rawData[0]].Add(double.Parse(rawData[1]));
                input = Console.ReadLine();
            }
            string treeType = Console.ReadLine();
            double minTreeLength = double.Parse(Console.ReadLine());
            List<double> selectedTrees = new List<double>();
            

            foreach ( var log in logsDatabase.Where(kvp => kvp.Key == treeType))
            {
                foreach(double length in log.Value.Where(x => x >= minTreeLength))
                {
                    selectedTrees.Add(length);
                }
                
            }
            double totalLength = 0;
            long treeCount = 0;
            foreach(var log in logsDatabase)
            {
                treeCount += logsDatabase[log.Key].Count;
                totalLength += logsDatabase[log.Key].Sum();
                
            }
            double pricePerMeter = Math.Round(totalLength / treeCount, 2);
            double usedLogsPrice = Math.Round(pricePerMeter * selectedTrees.Sum(), 2);
            double unusedLogsPrice = Math.Round(pricePerMeter * 0.25 * (totalLength - selectedTrees.Sum()), 2);
            Console.WriteLine($"Price per meter: ${pricePerMeter.ToString("F2")}");
            Console.WriteLine($"Used logs price: ${usedLogsPrice.ToString("F2")}");
            Console.WriteLine($"Unused logs price: ${unusedLogsPrice.ToString("F2")}");
            Console.WriteLine($"CottageScraper subtotal: ${(usedLogsPrice + unusedLogsPrice).ToString("F2")}");
            int t = 0;

        }
    }
}
