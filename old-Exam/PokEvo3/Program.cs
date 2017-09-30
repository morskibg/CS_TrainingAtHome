using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokEvo3
{
    class Pokemon
    {
        public string name;
        public List<KeyValuePair<string, int>> UnsortedProperties;
        public List<KeyValuePair<string, int>> SortedProperties;

        public Pokemon(string Name, string Type, string Index)
        {
            this.name = Name;
            this.UnsortedProperties = new List<KeyValuePair<string, int>>();
            this.UnsortedProperties.Add(new KeyValuePair<string, int>(Type, int.Parse(Index)));
            this.SortedProperties = new List<KeyValuePair<string, int>>();
        }
        public void addProperties(string Type, string Index)
        {
            this.UnsortedProperties.Add(new KeyValuePair<string, int>(Type, int.Parse(Index)));
        }
         public void sortingProperties()        {
            
            foreach(var currType in UnsortedProperties)
            {
                this.SortedProperties.Add(new KeyValuePair<string, int>(currType.Key, currType.Value));
            }
            this.SortedProperties.Sort((x, y) => -x.Value.CompareTo(y.Value));
        }


    }
    class Program
    {
        static void Main(string[] args)
        {

            string Line = Console.ReadLine();
            List<Pokemon> PoKDataBase = new List<Pokemon>();
            List<string> UniquePokemons = new List<string>();

            while (Line != "wubbalubbadubdub")
            {
                char[] delimiters = { ' ', '-', '>' };
                string[] words = Line.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                if (words.Length == 1)
                {
                    UniquePokemons.Add(words[0]);
                }
                else
                {
                    var checkExPok = PoKDataBase.Find(p => p.name == words[0]);
                    
                    if (checkExPok != null)
                    {
                        checkExPok.addProperties(words[1], words[2]);
                    }
                    else
                    {
                        Pokemon currentPok = new Pokemon(words[0], words[1], (words[2]));
                        PoKDataBase.Add(currentPok);
                    }
                }

                Line = Console.ReadLine();               
            }
            if(UniquePokemons.Count > 0)
            {
                foreach(var name in UniquePokemons)
                {
                    var currentPok = PoKDataBase.Find(x => x.name == name);
                    if(currentPok != null)
                    {                       
                        Console.WriteLine("# {0}", name);
                        foreach (var type in currentPok.UnsortedProperties)
                        {
                            Console.WriteLine("{0} <-> {1}", type.Key, type.Value);
                        }

                    }
                }
                
            }
            foreach(var currentPok in PoKDataBase)
            {
                Console.WriteLine("# {0}", currentPok.name);
                currentPok.sortingProperties();
                foreach(var currType in currentPok.SortedProperties)
                {
                    Console.WriteLine("{0} <-> {1}", currType.Key, currType.Value);
                }
            }

        }
    }
}
