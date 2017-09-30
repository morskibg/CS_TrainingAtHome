using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int col = 0;
            int current = 1;
            int n = int.Parse(Console.ReadLine());
            bool isContinue = true;
            while (isContinue)
            {
                for(int i = 1; i <= col + 1; ++i)
                {
                    if(current == n + 1)
                    {
                        isContinue = false;
                        break;
                    }
                    else
                    {
                        Console.Write("{0} ", current);
                        ++current;                      
                    }
                }
                ++col;
                Console.WriteLine();
            }
            
            
        }
    }
}
