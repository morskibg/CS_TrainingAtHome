using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace footbalStadium
{
    class Program
    {
        static void Main(string[] args)
        {
            int stadiumCap = int.Parse(Console.ReadLine());
            int totalFans = int.Parse(Console.ReadLine());
            var sectorDispersion = new Dictionary<string, int>();
            sectorDispersion["A"] = 0;
            sectorDispersion["B"] = 0;
            sectorDispersion["V"] = 0;
            sectorDispersion["G"] = 0;
            for (int i = 0; i < totalFans; ++i)
            {
                string currentSector = Console.ReadLine();
                sectorDispersion[currentSector]++;
            }
            int[] sectorFans = new int[4];
            sectorFans[0] = sectorDispersion["A"];
            sectorFans[1] = sectorDispersion["B"];
            sectorFans[2] = sectorDispersion["V"];
            sectorFans[3] = sectorDispersion["G"];

            for(int i = 0; i < 4; ++i)
            {
                var temp = (sectorFans[i] / (double)totalFans) * 100;
                Console.WriteLine("{0:F2}%", temp);
            }
            Console.WriteLine("{0:F2}%", (totalFans / (double)stadiumCap) * 100);
        }
    }
}
