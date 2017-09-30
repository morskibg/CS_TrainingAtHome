using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currHelth = int.Parse(Console.ReadLine());
            int maxHelth = int.Parse(Console.ReadLine());
            int currEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Health: |{0}{1}|", new String('|',currHelth), new String('.', maxHelth - currHelth));
            Console.WriteLine("Energy: |{0}{1}|", new String('|', currEnergy), new String('.', maxEnergy - currEnergy));
        }
    }
}
