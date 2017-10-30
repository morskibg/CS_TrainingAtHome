using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int tiredFactor = int.Parse(Console.ReadLine());
            double halfPokePower = pokePower / 2.0;
            int pokedCounter = 0;
            while (pokePower >= distance)
            {
                ++pokedCounter;
                pokePower -= distance;
                if (pokePower == halfPokePower && tiredFactor > 0)
                {
                    pokePower /= tiredFactor;
                }
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(pokedCounter);
        }
    }
}
