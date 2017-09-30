using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> cityBuildings = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int citySize = cityBuildings.Count;
            
            Console.WriteLine(string.Join(" ", cityBuildings));
        }
    }
}
