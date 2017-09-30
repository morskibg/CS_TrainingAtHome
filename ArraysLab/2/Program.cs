using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstLine = Console.ReadLine();
            double multiplier = double.Parse(Console.ReadLine());
            char[] delimiterChars = { ' ' };
            string[] words = firstLine.Split(delimiterChars);
            int size = words.Count();
            double[] parsedDoubles = new double[size];
            for(int i = 0; i < size; ++i)
            {
                parsedDoubles[i] = multiplier * double.Parse(words[i]);
            }
            foreach(var i in parsedDoubles)
            {
                Console.Write(i + " ");
            }
          
        }
    }
}
