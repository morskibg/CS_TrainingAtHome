using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcellentResult
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            string ones = "";
            string tens = "";
            string hundrets = "";
            int[] digits = new int[3];
            int counter = 0;
            for(int i = 0; i < 3; ++i)
            {
                if(num > 0 || (num == 0 && i == 0))
                {
                    digits[i] = num % 10;
                    num /= 10;
                    ++counter;
                    continue;
                }
            }
            //int t = 0;
            switch (digits[0])
            {
                case 0:
                    ones = "zero";
                    break;
                case 1:
                    ones = "one";
                    break;
                case 2:
                    ones = "two";
                    break;
                case 3:
                    ones = "three";
                    break;
                case 4:
                    ones = "four";
                    break;
                case 5:
                    ones = "five";
                    break;
                case 6:
                    ones = "six";
                    break;
                case 7:
                    ones = "seven";
                    break;
                case 8:
                    ones = "eight";
                    break;
                case 9:
                    ones = "nine";
                    break;
                

            }
            switch (digits[1])
            {
                
                case 1:
                    switch (digits[0])
                    {
                        case 0:
                            tens = "ten";
                            break;
                        case 1:
                            tens = "eleven";
                            break;
                        case 2:
                            tens = "twelve";
                            break;
                        case 3:
                            tens = "thirteen";
                            break;
                        case 4:
                            tens = "fourteen";
                            break;
                        case 5:
                            tens = "fifteen";
                            break;
                        case 6:
                            tens = "sixteen";
                            break;
                        case 7:
                            tens = "seventeen";
                            break;
                        case 8:
                            tens = "eightteen";
                            break;
                        case 9:
                            tens = "nineteen";
                            break;
                    }
                    break;
                case 2:
                    tens = "twenty";
                    break;
                case 3:
                    tens = "thirty";
                    break;
                case 4:
                    tens = "forty";
                    break;
                case 5:
                    tens = "fifty";
                    break;
                case 6:
                    tens = "sixty";
                    break;
                case 7:
                    tens = "seventy";
                    break;
                case 8:
                    tens = "eighty";
                    break;
                case 9:
                    tens = "ninety";
                    break;
                
            }
            switch (counter)
            {
                case 1:
                    Console.WriteLine("{0}", ones);
                    break;
                case 2:
                    if(digits[1] == 1 || digits[0] == 0)
                    {
                        Console.WriteLine("{0}", tens);
                    }
                    else
                    {
                        Console.WriteLine("{0} {1}", tens, ones);
                    }
                    
                    break;
                case 3:
                    if(digits[0] == 0 && digits[1] == 0)
                    {
                        Console.WriteLine("one hundred");
                    }
                    else
                    {
                        Console.WriteLine("invalid number");
                    }                   
                    break;
                default:
                    Console.WriteLine("invalid number");
                    break;
            }
            
        }
    }
}