using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemonDontGo
{
    class Program
    {
        static void RearangeList(ref List<long>poks, long value)
        {
            poks = poks
                .Select(x => x <= value ? x += value : x -= value)
                .ToList();
        }
        static void Main(string[] args)
        {
            List<long> pokemons = Console.ReadLine().Split().Select(long.Parse).ToList();
            long sumOfRemoved = 0;
            while (pokemons.Count > 0)
            {
                long index = long.Parse(Console.ReadLine());
                long removedElementValue = 0;
                if (index < 0 || index >= pokemons.Count)
                {
                     removedElementValue = index < 0 ? pokemons.First() : pokemons.Last();
                    if (index < 0)
                    {
                        pokemons[0] = pokemons.Last();
                    }
                    else
                    {
                        pokemons[pokemons.Count - 1] = pokemons[0];
                    }
                }
                else
                {
                    removedElementValue = pokemons[(int)index];
                    pokemons.RemoveAt((int)index);
                }
                RearangeList(ref pokemons, removedElementValue);
                sumOfRemoved += removedElementValue;
            }
            Console.WriteLine(sumOfRemoved);
        }
    }
}
