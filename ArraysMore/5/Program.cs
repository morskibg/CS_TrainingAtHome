using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int size = input.Length;
            int[] plants = new int[size];
            for (int i = 0; i < size; ++i)
            {
                plants[i] = int.Parse(input[i]);
            }
            int currDay = -1;
            int survivedDay = 0;
            int season = 0;
            
            bool isNewSeason = false;
            while (true)
            {
                ++survivedDay;
                ++currDay;
                for (int i = 0; i < size; ++i)
                {
                                       
                    if (isNewSeason)
                    {
                        isNewSeason = false;
                        ++survivedDay;                        
                        continue;
                    }
                   
                    if(plants[i] != 0 && i == currDay || plants[i] == 0)
                    {
                        continue;
                    }
                    --(plants[i]);                    

                }

                if (plants.Sum() == 0)
                {                   
                    break;
                }                
               
                if(currDay >= size - 1)
                {
                    currDay = 0;
                    ++season;
                    isNewSeason = true;
                }
            }
            Console.WriteLine("survived {0} days ({1} {2})", survivedDay, season, season == 1 ? "season" : "seasons");
        }
    }
}
