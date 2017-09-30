using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AL5
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] inputNums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            List<char> word = new List<char>();
            for (int i = 0; i < inputNums.Length; ++i)
            {
                int wholePart = (int)inputNums[i];
                double fraction = Math.Round((inputNums[i] - wholePart), 3);
                while (fraction - (int) fraction > 0)
                {
                    fraction *= 10;
                }
                if (wholePart != 0)
                {
                    word.Insert(i, (char)wholePart);
                }
                if (fraction != 0)
                {
                    word.Add((char)fraction);
                }
                
            }
            Console.WriteLine(string.Join("",word));
            
        }
    }
}
