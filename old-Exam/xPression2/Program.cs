using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xPression2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            double totalNum = 0;
            double bracketNum = 0;
            double firstNum = 0;
            double secondNum = 0;
            string numString = "";
            while (true)
            {
                foreach(char currSymbol in inputLine)
                {
                    while (char.IsDigit(currSymbol))
                    {
                        numString += currSymbol;
                        
                    }
                }
            }
        }
    }
}
