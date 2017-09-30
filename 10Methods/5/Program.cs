using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static double RaseOnPwer(double baseNum, int powerNum)
        {
            double res = 1;
            for(int i = 1; i <= powerNum; ++i)
            {
                res *= baseNum;  
            }
            return res;
        }
        static void Main(string[] args)
        {
            double baseNum = double.Parse(Console.ReadLine());
            int powerNum = int.Parse(Console.ReadLine());
            double result = RaseOnPwer(baseNum, powerNum);
            Console.WriteLine(result);
           
        }
    }
}
