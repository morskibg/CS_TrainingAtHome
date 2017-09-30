using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeLength = int.Parse(Console.ReadLine());
            int cakeWidth = int.Parse(Console.ReadLine());
            int availablePieces = cakeLength * cakeWidth;
            int neededPieces = 0;
            
            string input = Console.ReadLine();

            while( input != "STOP")
            {
                int requestedPieces = int.Parse(input);
                if(availablePieces - requestedPieces < 0)
                {
                    neededPieces = requestedPieces - availablePieces;
                    break;
                }
                availablePieces -= requestedPieces;
                input = Console.ReadLine();
            }
            if(neededPieces != 0)
            {
                Console.WriteLine("No more cake left! You need {0} pieces more.", neededPieces);
            }
            else
            {
                Console.WriteLine("{0} pieces are left.", availablePieces);
            }
        }
    }
}
