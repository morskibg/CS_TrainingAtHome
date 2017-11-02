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
                field[index] = 1;
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
                string command = query[1].Trim();
                long flyLength = long.Parse(query[2]);
                while (true)
                {
                    if (ladybugIndex >= 0 && ladybugIndex < fieldSize)
                    {
                        if (field[ladybugIndex] == 1)
                        {
                            long resultIdx = 0;
                            if (command == "right")
                            {
                                resultIdx = ladybugIndex + flyLength;
                                if (resultIdx < fieldSize)
                                {
                                    if (field[resultIdx] == 0)
                                    {
                                        field[resultIdx] = 1;
                                        break;
                                    }
                                    else
                                    {
                                        flyLength += flyLength;
                                    }
                                }
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
