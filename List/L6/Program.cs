using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> grapes = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int rounds = int.Parse(Console.ReadLine());
            List<int> biggerThanRoundsGrapes = new List<int>();
            bool isComplete = false;

            while (!isComplete)
            {
                for (int i = 0; i < rounds; ++i)
                {
                    for (int j = 0; j < grapes.Count; ++j)
                    {
                        if (grapes[j] > 0)
                        {
                            ++grapes[j];
                        }
                    }
                    for (int j = 1; j < grapes.Count - 1; ++j)
                    {
                        if (grapes[j] > grapes[j - 1] && grapes[j] > grapes[j + 1])
                        {
                            if (grapes[j - 1] > 0)
                            {
                                ++grapes[j];
                                grapes[j - 1] -= 2;                                
                            }
                            if (grapes[j + 1] > 0)
                            {
                                ++grapes[j];
                                grapes[j + 1] -= 2;                                
                            }
                        }
                    }                    
                }
               for(int i = 0; i < grapes.Count; ++i)
                {
                    if(grapes[i] < rounds)
                    {
                        grapes[i] = 0;
                    }
                }                
                biggerThanRoundsGrapes = grapes.FindAll(x => x > rounds);
                isComplete = biggerThanRoundsGrapes.Count < rounds;
            }            
            Console.WriteLine(string.Join(" ", biggerThanRoundsGrapes));
        }
    }
}
