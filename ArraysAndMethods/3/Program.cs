using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static string StringRepeater(string input, int repiter)
        {
            string result = "";
            for(int i = 0; i < repiter; ++i)
            {
                result += input;
            }
            return result; 
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int repiter = int.Parse(Console.ReadLine());
            Console.WriteLine(StringRepeater(input, repiter));
        }
    }
}
