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
            Dictionary<string, decimal> database = new Dictionary<string, decimal>();
            while(input != "Over")
            {
                decimal number = 0;
                char[] delimiters = " :".ToCharArray();
                string[] nameAndNumber = input.Split(delimiters).ToArray();
                if (decimal.TryParse(nameAndNumber.First(),out number))
                {
                    number = decimal.Parse(nameAndNumber.First());
                    database[nameAndNumber.Last()] = number;
                }
                else
                {
                    number = decimal.Parse(nameAndNumber.Last());
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
