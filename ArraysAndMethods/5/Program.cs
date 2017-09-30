using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static string IntegerToBase(int num, int toBase)
        {
            string result = "";
            while(num > 0)
            {
                string current = (num % toBase).ToString();
                result = current + result;
                num /= toBase;

            }
            return result;
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());
            Console.WriteLine(IntegerToBase(num, toBase));
        }
    }
}
