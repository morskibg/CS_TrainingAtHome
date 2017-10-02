using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, long> database = new Dictionary<string, long>();
            while(input != "Over")
            {
                long number = 0;
                char[] delimiters = " :".ToCharArray();
                string[] nameAndNumber = input.Split(delimiters).ToArray();
                string name = "";
                if (long.TryParse(nameAndNumber.First(),out number))
                {
                    number = long.Parse(nameAndNumber.First());
                    database[nameAndNumber.Last()] = number;
                }
                else
                {
                    number = long.Parse(nameAndNumber.Last());
                    database[nameAndNumber.First()] = number;
                }
                input = Console.ReadLine();
            }
            foreach(var item in database.OrderBy(kvp => kvp.Key))
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
        }
    }
}
