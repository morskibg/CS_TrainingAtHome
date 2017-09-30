using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int tempNum = num;
            int oddSum = 0;
            int evenSum = 0;
            while(tempNum != 0)
            {
                int currDigit = tempNum % 10;
                if(currDigit % 2 == 0)
                {
                    evenSum += currDigit;
                }
                else
                {
                    oddSum += currDigit;
                }
                tempNum /= 10;
            }
            Console.WriteLine(evenSum * oddSum);
        }
    }
}
