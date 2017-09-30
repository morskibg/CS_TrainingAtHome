using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drawDiamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if(n == 1)
            {
                Console.WriteLine("*");
            }
            else if(n == 2)
            {
                Console.WriteLine("**");
            }
            else
            {
                int sideDash = 0;
                int middleDash = 0;
                if (n % 2 == 0)
                {
                    sideDash = (n - 2) / 2;
                }
                else
                {
                    sideDash = (n - 1) / 2;
                    middleDash = 1;
                }                 
               
                for(int i = 0; i < n/2; ++i)
                {
                    if(n % 2 == 0)
                    {
                        Console.WriteLine("{0}*{1}*{0}", new String('-', sideDash), new String('-', middleDash));
                        --sideDash;
                        middleDash += 2;
                    }
                    else
                    {
                        
                        if(i == 0)
                        {
                            Console.WriteLine("{0}*{0}", new String('-', sideDash));
                            --sideDash;
                        }
                        else
                        {
                            Console.WriteLine("{0}*{1}*{0}", new String('-', sideDash), new String('-', middleDash));
                            --sideDash;
                            middleDash += 2;
                        }
                       
                    }

                }
                for(int i = n /2 ; i < n; ++i)
                {
                    if(n % 2 == 0)
                    {
                        ++sideDash;
                        middleDash -= 2;
                        if(sideDash == 0)
                        {
                            continue;
                        }
                        Console.WriteLine("{0}*{1}*{0}", new String('-', sideDash), new String('-', middleDash));
                    }
                    else
                    {   
                        if(middleDash < 0)
                        {
                            Console.WriteLine("{0}*{0}", new String('-', sideDash));
                        }
                        else
                        {
                            Console.WriteLine("{0}*{1}*{0}", new String('-', sideDash), new String('-', middleDash));
                            ++sideDash;
                            middleDash -= 2;
                        }                     
                       
                    }                    
                    
                }
            }
        }
    }
}
