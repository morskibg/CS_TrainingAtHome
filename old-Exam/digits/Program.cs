using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            int temp = inputNum;
            
            int[] digits = new int[4];
            for(int i = 3; i >= 1; --i)
            {
                digits[i] = temp % 10;
                temp /= 10;
            }
            int row = digits[1] + digits[2];
            int col = digits[1] + digits[3];
            
            int currNum = inputNum; 
            for(int i = 0; i < row; ++i)
            {
                for(int j = 0; j < col; ++j)
                {
                    
                    if(currNum % 5 == 0)
                    {
                        currNum -= digits[1];
                    }
                    else if(currNum % 3 == 0)
                    {
                        currNum -= digits[2];
                    }
                    else
                    {
                        currNum += digits[3];
                    }
                    
                    Console.Write("{0} ",currNum);
                }
                Console.WriteLine();
            }
            
        }
    }
}
