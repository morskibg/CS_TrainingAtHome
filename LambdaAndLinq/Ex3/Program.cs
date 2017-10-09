using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            Dictionary<string, decimal> database = new Dictionary<string, decimal>();
            while(line != "end")
            {

                string[] rawData = line.Split(' ').ToArray();
                decimal currPrice = decimal.Parse(rawData[1]);
                if (!database.ContainsKey(rawData[0]))
                {
                    database[rawData[0]] = currPrice;
                }
                else
                {
                    if (database[rawData[0]] > currPrice)
                    {
                        database[rawData[0]] = currPrice;
                    }
                }              
                line = Console.ReadLine();
            }
            decimal purchasedSum = database.Values.Sum();
            if(purchasedSum > budget)
            {
                Console.WriteLine("Need more money... Just buy banichka");
                return;
            }
            else
            {
                foreach(KeyValuePair<string, decimal> currProduct in database
                    .OrderByDescending(kvp => kvp.Value)
                    .ThenBy(kvp => kvp.Key.Length))
                {
                    Console.WriteLine($"{currProduct.Key} costs {decimal.Round(currProduct.Value, 2).ToString("N2")}");
                }

            }
        }
    }
}
