using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cardNumbers = new string[4];
            for(int i = 0; i < 4; ++i)
            {
                int inputNum = int.Parse(Console.ReadLine());               
                int digit1 = (inputNum / 1) % 10;
                int digit2 = (inputNum / 10) % 10;
                int digit3 = (inputNum / 100) % 10;
                int digit4 = (inputNum / 1000) % 10;
                string cardNum = digit4.ToString() + digit3.ToString() + digit2.ToString() + digit1.ToString();
                cardNumbers[i] = cardNum;
            }
            for(int i = 0; i < 4; ++i)
            {
                Console.Write("{0} ", cardNumbers[i]);
            }
        }
    }
}
