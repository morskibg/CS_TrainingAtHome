using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> pilots = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim()).ToList();
            List<double> trackLayoutZones = Console.ReadLine()
                .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();
            List<long> checkPointInduces = Console.ReadLine()
                .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();
            for (int i = 0; i < pilots.Count; i++)
            {
                
                string currPilot = pilots[i];
                double fuel = (double) currPilot[0];
                for (int j = 0; j < trackLayoutZones.Count; j++)
                {
                    bool isCheckpoint = checkPointInduces.Contains(j);
                    if (isCheckpoint && j < trackLayoutZones.Count)
                    {
                        fuel += trackLayoutZones[j];
                    }
                    else if (j < trackLayoutZones.Count)
                    {
                        fuel -= trackLayoutZones[j];
                    }
                    if (fuel <= 0)
                    {
                        Console.WriteLine($"{currPilot} - reached {j}");
                       
                        break;
                    }
                }
                if (fuel > 0)
                {
                    Console.WriteLine($"{currPilot} - fuel left {fuel:f2}");
                }

            }
        }
    }
}
