using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo1
{
    class Program
    {
        static int RemainingEnergy(int currEnergy, int currDamage)
        {
            return currEnergy - currDamage > 0 ? currEnergy - currDamage : -1;
        }

        static string[] ProceedBombCommand(string[] obsticales, int idx)
        {
            int oldSize = obsticales.Length;
            int newSize = oldSize - 1;
            string[] resizedObstacles = new string[newSize];
            for (int i = 0, j = 0; i < newSize; ++i, ++j)
            {
                if (i == idx)
                {
                    ++j;
                }
                resizedObstacles[i] = obsticales[j];
            }
            return resizedObstacles;
        }

        static int ProceedMovement(string command, int idx, int movement, int obstaclesSize)
        {
            bool isReachedZero = false;
            //if (command == "Right")
            //{
            //    int newIdx = (idx + movement) % obstaclesSize;
            //    return newIdx;
            //}
            //else
            //{
            //    int newIdx = Math.Abs((idx - movement) % obstaclesSize);
            //    return newIdx;
            //}
            while (movement > 0)
            {
                if (command == "Right")
                {
                    if (idx < obstaclesSize - 1)
                    {
                        ++idx;
                    }
                    else
                    {
                        idx = 0;
                    }
                }
                else
                {
                    if (idx > 0 && !isReachedZero)
                    {
                        --idx;
                    }
                    else
                    {
                        if (!isReachedZero)
                        {
                            idx = 0;
                            isReachedZero = true;
                        }
                        if (idx < obstaclesSize - 1)
                        {
                            ++idx;
                        }
                        else
                        {
                            idx = 0;
                        }
                    }
                }
                --movement;
            }
            return idx;
        }

        static string[] PlaceBombAtTheEnd(string[] obst, int damage)
        {
            int lastIndex = obst.Length - 1;
            string newBomb = "Bomb" + "|" + damage.ToString();
            string[] lastWords = obst[lastIndex].Split('|').ToArray();
            if (lastWords.First() != "RabbitHole")
            {

                obst[lastIndex] = newBomb;
                return obst;
            }
            else
            {
                string[] resizedObst = new string[obst.Length + 1];
                for (int i = 0; i < obst.Length; ++i)
                {
                    resizedObst[i] = obst[i];
                }
                resizedObst[obst.Length] = newBomb;
                return resizedObst;
            }
        }
        static void Main(string[] args)
        {
            string[] obstacles = Console.ReadLine().Split(' ').ToArray();
            int energy = int.Parse(Console.ReadLine());
            int currIndex = 0;

            while (currIndex <= obstacles.Length - 1)
            {

                if (obstacles[currIndex] == "RabbitHole")
                {
                    Console.WriteLine("You have 5 years to save Kennedy!");
                    return;
                }
                else
                {
                    string[] commandAndDistance = obstacles[currIndex].Split('|');
                    string command = commandAndDistance.First();
                    int distanceOrDamage = int.Parse(commandAndDistance.Last());
                    energy = RemainingEnergy(energy, distanceOrDamage);
                    if (energy == -1)
                    {
                        if (command == "Bomb")
                        {
                            Console.WriteLine("You are dead due to bomb explosion!");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("You are tired. You can't continue the mission.");
                            return;
                        }
                    }
                    else
                    {
                        if (command == "Bomb")
                        {
                            currIndex = 0;
                            obstacles = ProceedBombCommand(obstacles, currIndex);

                        }
                        else
                        {
                            currIndex = ProceedMovement(command, currIndex, distanceOrDamage, obstacles.Length);

                        }
                    }
                }

                obstacles = PlaceBombAtTheEnd(obstacles, energy);
            }
        }
    }
}
