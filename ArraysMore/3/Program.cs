using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ');
            string[] names = Console.ReadLine().Split(' ');
            string inputLine = Console.ReadLine();
            while(inputLine != "done")
            {
                
                for(int i = 0; i < names.Length; ++i)
                {
                    if(names[i] == inputLine)
                    {
                        Console.WriteLine("{0} -> {1}", names[i], phoneNumbers[i]);
                        break;
                    }
                }
                inputLine = Console.ReadLine();
            }
        }
    }
}
