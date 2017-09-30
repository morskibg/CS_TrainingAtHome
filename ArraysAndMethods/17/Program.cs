using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            char delimiter = ' ';
            string[] words = inputLine.Split(delimiter);
            decimal altitude = decimal.Parse(words[0]);            
            int size = words.Count() - 1;
            decimal[] distanceManeuver = new decimal[size / 2];
            string[] directionManeuver = new string[size / 2];
            int j = 0;
            int k = 0;
            for(int i = 1; i <= size ; ++i)
            {
                if(i % 2 == 0)
                {
                    distanceManeuver[k++] = decimal.Parse(words[i]);
                }
                else
                {
                    directionManeuver[j++] = words[i];                    
                }
            }
            
            for(int i = 0; i < size / 2; ++i)
            {
                switch (directionManeuver[i])
                {
                    case "up":
                        altitude += distanceManeuver[i];
                        break;
                    case "down":
                        altitude -= distanceManeuver[i];
                        if(altitude <= 0)
                        {
                            Console.WriteLine("crashed");
                            return;
                        }
                        break;
                }

            }
            Console.WriteLine("got through safely. current altitude: {0}m", altitude);
        }
    }
}
