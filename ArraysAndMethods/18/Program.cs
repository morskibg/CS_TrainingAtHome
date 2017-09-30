using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] targetCoordinates = Console.ReadLine().Split(' ').ToArray();
            string[] commands = Console.ReadLine().Split(' ').ToArray();
            decimal currX = 0;
            decimal currY = 0;
            for(int i = 0, j = 1; i < commands.Count() ; i += 2, j += 2)

            {   switch (commands[i])
                {

                    case "up":
                        currY += decimal.Parse(commands[j]);
                        break;
                    case "down":
                        currY -= decimal.Parse(commands[j]);
                        break;
                    case "left":
                        currX -= decimal.Parse(commands[j]);
                        break;
                    case "right":
                        currX += decimal.Parse(commands[j]);
                        break;
                }
            }
            Console.WriteLine("firing at [{0}, {1}]", currX, currY);
            if(currX == decimal.Parse(targetCoordinates[0] ) && currY == decimal.Parse(targetCoordinates[1]))
            {
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine("better luck next time...");
            }
            
        }
    }
}
