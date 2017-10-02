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
            Dictionary<string, int> dataBase = new Dictionary<string, int>();
            while (input != "end")
            {
                char[] delimiters = " =".ToCharArray();
                string[] nameAndMoney = input.Split(delimiters).ToArray();
                string name = nameAndMoney.First();
                int money = 0;// int.Parse(nameAndMoney.Last());
                if (int.TryParse(nameAndMoney.Last(), out money))
                {
                    money = int.Parse(nameAndMoney.Last());
                    dataBase[name] = money;
                }
                else
                {
                    if (dataBase.ContainsKey(nameAndMoney.Last()))
                    {
                        dataBase[name] = dataBase[nameAndMoney.Last()];
                    }
                }
                input = Console.ReadLine();
            }
            foreach (KeyValuePair<string, int> kvp in dataBase)
            {
                Console.WriteLine(kvp.Key + " === " + kvp.Value);
            }
        }
    }
}
