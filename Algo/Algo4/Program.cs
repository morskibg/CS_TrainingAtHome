using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cylinder = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int cylinderLength = cylinder.Length;
            string[] players = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < players.Length; ++i)
            {
                string[] currPlayerData = players[i].Split(',').ToArray();
                int bulletPosition = Array.IndexOf(cylinder, 1);
                int strength = int.Parse(currPlayerData.First());
                string direction = currPlayerData.Last();
                if (direction == "Right")
                {
                   
                    int bulletPositionAfterRotation = (bulletPosition + strength) % cylinderLength;
                    if (bulletPositionAfterRotation == 2)
                    {
                        Console.WriteLine($"Game over! Player {i} is dead.");
                        return;
                    }
                    else
                    {
                        Array.Clear(cylinder, 0, cylinderLength);
                        if (bulletPositionAfterRotation == cylinderLength - 1)
                        {
                            cylinder[0] = 1;
                        }
                        else
                        {
                            cylinder[bulletPositionAfterRotation + 1] = 1;
                        }
                    }
                }
                else
                {

                    int bulletPositionAfterRotation = bulletPosition - strength;//cylinderLength -  Math.Abs((bulletPosition - strength) % cylinderLength);
                    if (bulletPosition - strength < 0)
                    {
                        bulletPositionAfterRotation = cylinderLength - Math.Abs((bulletPosition - strength) % cylinderLength);
                    }
                    if (bulletPositionAfterRotation == 2)
                    {
                        Console.WriteLine($"Game over! Player {i} is dead.");
                        return;
                    }
                    else
                    {
                        Array.Clear(cylinder, 0, cylinderLength);
                        if (bulletPositionAfterRotation == cylinderLength - 1)
                        {
                            cylinder[0] = 1;
                        }
                        else
                        {
                            cylinder[bulletPositionAfterRotation + 1] = 1;
                        }
                    }

                }

            }
            Console.WriteLine("Everybody got lucky!");

        }
    }
}
