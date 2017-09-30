using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        enum DigitPosition
        {
            ones = 1,
            tens = 2,
            hundrets = 3
        }
        static bool ValidateInputNum(int inputNum)
        {
            if (inputNum > 999)
            {
                Console.WriteLine("too large");
                return false;
            }
            else if (inputNum < -999)
            {
                Console.WriteLine("too small");
                return false; ;
            }
            else if (!IsThreeDigitsNum(inputNum))
            {
                return false;
            }
            return true;
        }
        static bool IsThreeDigitsNum(int num)
        {
            int counter = 0;
            while(num != 0)
            {
                ++counter;
                num /= 10;
            }
            return (counter == 3) ? true : false;
        }
        static string GetSign(int num)
        {
            return (num > 0) ? "" : "minus ";
        }
        static string BasicDigitToWord(int digit)
        {
            switch (digit)
            {
                case 0:
                    return "null";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                default:
                    return "default";
            }
        }
        static string TensDigitToWord(int digit)
        {
            switch (digit)
            {
                
                case 1:
                    return "ten";
                case 2:
                    return "twenty";
                case 3:
                    return "thirty";
                case 4:
                    return "forty";
                case 5:
                    return "fifty";
                case 6:
                    return "sixty";
                case 7:
                    return "seventy";
                case 8:
                    return "eighty";
                case 9:
                    return "ninety";
                default:
                    return "default";
            }
        }
        static string TeenDigitToWord(int digit)
        {
            switch (digit)
            {

                case 1:
                    return "eleven";
                case 2:
                    return "twelve";
                case 3:
                    return "thirteen";
                case 4:
                    return "fourteen";
                case 5:
                    return "fifteen";
                case 6:
                    return "sixteen";
                case 7:
                    return "seventeen";
                case 8:
                    return "eighteen";
                case 9:
                    return "nineteen";
                default:
                    return "default";
            }
        }
        
        static string Hundrets(int digit)
        {
            string result = "";
            switch (digit)
            {

            }

            return result;

        }
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                --n;
                int inputNum = int.Parse(Console.ReadLine());

                if (!ValidateInputNum(inputNum))
                {
                    continue;
                }
                
                string sign = GetSign(inputNum);
                if(sign == "minus ")
                {
                    inputNum *= -1;
                }

                int digit1 = inputNum % 10;
                int digit2 = (inputNum / 10) % 10;
                int digit3 = (inputNum / 100) % 10;

                string ones = BasicDigitToWord(digit1);
                string tens = BasicDigitToWord(digit2);
                string hundrets = BasicDigitToWord(digit3);

                if(ones == "null" && tens == "null")
                {
                    
                    Console.WriteLine("{0}{1}-hundred", sign, hundrets);
                    continue;
                }
                else if(ones == "null" && tens != "null")
                {
                    Console.WriteLine("{2}{0}-hundred and {1}", hundrets, TensDigitToWord(digit2), sign);
                    continue;
                }
                else if(ones != "null" && tens == "one")
                {
                    Console.WriteLine("{2}{0}-hundred and {1}", hundrets, TeenDigitToWord(digit1), sign);
                    continue;
                }
                else if(ones != "null" && tens == "null")
                {
                    Console.WriteLine("{0}{1}-hundred and {2}", sign, hundrets, ones);
                    continue;
                }
               else
                {
                    Console.WriteLine("{0}{1}-hundred and {2} {3}", sign, hundrets, TensDigitToWord(digit2), ones);
                }
                
            }
        }
    }
}
