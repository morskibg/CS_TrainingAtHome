using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] field = new int[fieldSize];
            List<long> initaialIndices = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();
            for(int index = 0; index < initaialIndices.Count;++index)
            {
                if(initaialIndices[index] >= 0 && initaialIndices[index] < fieldSize)
                {
                    field[initaialIndices[index]] = 1;                   
                }
                
            }
            //Console.WriteLine(string.Join(" ", field));
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                string[] query = input.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                long ladybugIndex = long.Parse(query[0]);
                if (ladybugIndex < 0 || ladybugIndex >= fieldSize || field[ladybugIndex] == 0)
                {
                    continue;
                }
                field[ladybugIndex] = 0;
                string command = query[1].Trim();
                long flyLength = long.Parse(query[2]);
                long startFlyLength = flyLength;
                while (true)
                {

                    long landingIdx = command == "right" ?
                        ladybugIndex + flyLength :
                        ladybugIndex - flyLength;
                    if (landingIdx < 0 || landingIdx >= fieldSize)
                    {
                        break;
                    }
                    if (field[landingIdx] == 0)
                    {
                        field[landingIdx] = 1;
                        break;
                    }
                    flyLength += startFlyLength;
                }
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}
