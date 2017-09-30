using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enterEven
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int parsedNum = 0;
                Console.WriteLine("Enter even number");
               
                try
                {
                    parsedNum = int.Parse(Console.ReadLine());
                    if (parsedNum % 2 == 0)
                    {
                        Console.WriteLine("Even number entered: {0}", parsedNum);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The number is not even");
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid number");
                }
            }
        }
    }
}
