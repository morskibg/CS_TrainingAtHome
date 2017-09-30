using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mall
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal moneyLeft = decimal.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int purchaseCounter = 0;
            while (command != "mall.Enter")
            {
                command = Console.ReadLine();
            }
            command = Console.ReadLine();
            while (command != "mall.Exit")
            {
                foreach (char symbol in command)
                {
                    bool isLetter = char.IsLetter(symbol);
                    bool isUpper = char.IsUpper(symbol);
                    decimal price = 0;
                    if (isLetter && isUpper)
                    {
                        price = (int)symbol * (decimal)0.5;                       
                    }
                    else if (isLetter && !isUpper)
                    {
                        price = (int)symbol * (decimal)0.3;                        
                    }
                    if (isLetter)
                    {
                        if (moneyLeft < price)
                        {
                            continue;
                        }
                        else
                        {
                            moneyLeft -= price;
                            purchaseCounter++;
                        }
                    }
                    else
                    {
                        if(symbol == '*')
                        {
                            moneyLeft += 10;
                        }
                        else if(symbol == '%')
                        {
                            if (moneyLeft > 0)
                            {
                                moneyLeft /= 2;
                                ++purchaseCounter;
                            }
                        }
                        else
                        {
                            if (moneyLeft < (int)symbol)
                            {
                                continue;
                            }
                            else
                            {
                                moneyLeft -= (int)symbol;
                                ++purchaseCounter;
                            }
                        }
                    }
                }
                command = Console.ReadLine();
            }
            if (purchaseCounter > 0)
            {
                Console.WriteLine("{0} purchases. Money left: {1:f2} lv.", purchaseCounter, moneyLeft);
            }
            else
            {
                Console.WriteLine("No purchases. Money left: {0:f2} lv.", moneyLeft);
            }
        }
    }
}
