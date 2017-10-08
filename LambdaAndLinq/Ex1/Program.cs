using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            Dictionary<string, DateTime> database = new Dictionary<string, DateTime>();

            while (line != "end")
            {
                char[] delimiter = " ->".ToCharArray();
                string[] rawData = line.Split(delimiter, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string format = "dd/MM/yyyy";
                DateTime currDate = DateTime.ParseExact(rawData[1], format, CultureInfo.InvariantCulture);

                string name = rawData[0];
                database[name] = currDate;
                line = Console.ReadLine();
            }
            
            foreach (var user in database
                .Reverse()
                .OrderBy(x => x.Value)
                .Take(5)
                .OrderByDescending(x => x.Value))
            {
                Console.WriteLine(user.Key);
            }

            
        }
    }
}
