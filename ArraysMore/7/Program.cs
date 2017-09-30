using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string[] commandAndDigit = Console.ReadLine().Split(' ');
            int smartArraySize = 4;
            int filledIndex = 0; 
            int[] smartArray = new int[smartArraySize];
            
            while(commandAndDigit.First() != "end")
            {
                string command = commandAndDigit.First();
                int digit = 0;
                if (command != "pop" && command != "clear")
                {
                    digit = int.Parse(commandAndDigit.Last());
                }
                switch (command)
                {
                    case "push":
                        if(filledIndex < smartArraySize)
                        {
                            smartArray[filledIndex] = digit;
                            ++filledIndex;
                        }
                        else
                        {
                            smartArraySize *= 2;
                            int[] tempArray = new int[smartArraySize];
                            for(int i = 0; i <= smartArray.Length; ++i)
                            {
                                if(i == smartArray.Length)
                                {
                                    tempArray[i] = digit;
                                    filledIndex = i;
                                }
                                else
                                {
                                    tempArray[i] = smartArray[i];
                                }
                            }
                            smartArray = tempArray;
                        }
                                       
                        break;

                    case "pop":
                        
                        break;
                    case "removeAt":
                        
                        break;
                    case "clear":
                        
                        break;
                }
                commandAndDigit = Console.ReadLine().Split(' ');
            }
            if (smartArray.Length == 0)
            {
                Console.WriteLine("empty array");
            }
            else
            {
                for (int i = 0; i <= filledIndex; ++i)
                {
                    Console.Write(smartArray[i] + " ");
                }
                
            }
        }
    }
}
