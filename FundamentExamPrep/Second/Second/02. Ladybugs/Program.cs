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
            foreach (var index in initaialIndices)
            {
                if(index >= 0 && index < fieldSize)
                {
                    field[index] = 1;
                }
                
            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                string[] query = input.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                long ladybugIndex = long.Parse(query[0]);
                if (ladybugIndex < 0 || ladybugIndex >= fieldSize)
                {
                    continue;
                }
                field[ladybugIndex] = 0;
                string command = query[1].Trim();
                long flyLength = long.Parse(query[2]);
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
                    flyLength += flyLength;
                }
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}
