using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static string AddBigNums(string firstNum, string secondNum)
        {

        }
        static void Main(string[] args)
        {
            string firstNum = Console.ReadLine();
            string secondNum = Console.ReadLine();
            if(firstNum.Length >= secondNum.Length)
            {
                Console.WriteLine(AddBigNums(firstNum, secondNum));
            }
            else
            {
                Console.WriteLine(AddBigNums(secondNum, firstNum));
            }
        }
    }
}
