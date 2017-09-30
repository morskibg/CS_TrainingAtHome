using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int controlNum = int.Parse(Console.ReadLine());
            int sum = 0;
            int moves = 0;
          
            for (int i = 1; i <= N; ++i)
            {
               
                    for (int j = M; j >= 1; --j)
                    {

                        ++moves;                        
                        sum += i * 2 + j * 3;
                        if (sum >= controlNum)
                        {
                            Console.WriteLine("{0} moves", moves);
                            Console.WriteLine("Score: {0} >= {1}", sum, controlNum);
                           
                            return;
                        }

                    }
                

            }
            if (sum < controlNum)
            {
                Console.WriteLine("{0} moves", moves);
            }
        }
    }
}
