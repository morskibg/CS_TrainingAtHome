using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbersGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            bool isReached = false;
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            string digit = "";
            
            int special = int.Parse(Console.ReadLine());
            int control = int.Parse(Console.ReadLine());
            for(int i = a; i >= 1; --i)
            {
                for(int j = b; j >= 1; --j)
                {

                    for(int k = c; k >= 1; --k)
                    {
                        num = i * 100 + j * 10 + k;
                        if (special < control)
                        {
                            if (num % 3 == 0)
                            {
                                special += 5;
                            }
                            else if (num % 5 == 0 && num % 10 != 0)
                            {
                                special -= 2;
                            }
                            else if (num % 2 == 0)
                            {
                                special *= 2;
                            }
                            
                        }
                        else
                        {
                            isReached = true;
                            break;
                        }


                    }

                }

               
            }
            if (isReached)
            {
                Console.WriteLine("Yes! Control number was reached! Current special number is {0}.", special);
            }
            else
            {
                Console.WriteLine("No! {0} is the last reached special number.", special);
            }
        }
        
    }
}
