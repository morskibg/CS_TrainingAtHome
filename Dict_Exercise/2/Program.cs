using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<List<string>, int> dataBase= new Dictionary<List<string>, int>();
            char[] delimiters = " =".ToCharArray();
            while (input != "end")
            {
                string[] nameAndMoney = input.Split(delimiters).ToArray();
                string name = nameAndMoney.First();
                int money = int.Parse(nameAndMoney.Last());

            }
        }
    }
}
