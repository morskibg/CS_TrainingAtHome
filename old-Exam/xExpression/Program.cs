using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xExpression
{
    class Program
    {
        static decimal mathCalc(decimal firstNum, decimal secondNum, char mathSymbol)
        {
            switch (mathSymbol)
            {
                case '*':
                    return firstNum * secondNum;
                case '+':
                    return firstNum + secondNum;
                case '/':                    
                    return firstNum / secondNum;
                case '-':
                    return firstNum - secondNum;
                default:
                    return 0;
            }
        }
        static void Main(string[] args)
        {
            //ring inputLine = Console.ReadLine();
            Queue<int> nums = new Queue<int>();
            Queue<char> symbols = new Queue<char>();
            decimal totalCalcNum = 0;
            decimal bracketCalcNum = 0;
            char currSymbol =(char)Console.Read();
            while(currSymbol != '=')
            {
                if (char.IsDigit(currSymbol))
                {
                    nums.Enqueue((int)char.GetNumericValue(currSymbol));
                }
                else
                {
                    symbols.Enqueue(currSymbol);
                         
                }
                currSymbol = (char)Console.Read();

            }
            symbols.Enqueue('=');
            if(nums.Count == 0)
            {
                return;
            }
            totalCalcNum = nums.Dequeue();
            bool isInBrackets = false;
            char symbolBefore = ' ';
            while (true)
            {
                char currSym = symbols.Dequeue();
                
                if(currSym == '=')
                {
                    break;
                }
                char nextSym = symbols.Peek();
                if (nextSym == '(')
                {
                    isInBrackets = true;
                    symbolBefore = currSym;
                    char trash = symbols.Dequeue();
                    bracketCalcNum = nums.Dequeue();
                    
                }
                else if(nextSym == ')')
                {
                    isInBrackets = false;
                    bracketCalcNum = mathCalc(bracketCalcNum, nums.Dequeue(), currSym);
                    char trash = symbols.Dequeue();
                    totalCalcNum = mathCalc(totalCalcNum, bracketCalcNum, symbolBefore);
                   
                }
                else if(isInBrackets)
                {
                    bracketCalcNum = mathCalc(bracketCalcNum, nums.Dequeue(), currSym);
                }               
                else
                {
                    totalCalcNum = mathCalc(totalCalcNum, nums.Dequeue(), currSym);
                    
                }                        
                   
            }          
            
            Console.WriteLine("{0:f2}", totalCalcNum);
        }
    }
}
