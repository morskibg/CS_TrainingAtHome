using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonEvolution
{
    class Pokemon
    {
        private string name;
        public Dictionary<string, List<int>> properties;
        public List<KeyValuePair<string, int>> UnsortedList;

        public Pokemon(string Name, string Type, int Index)
        {
            this.name = Name;
            this.properties = new Dictionary<string, List<int>>();
            this.properties.Add(Type, new List<int> { Index });
            this.UnsortedList = new List<KeyValuePair<string, int>>();
        }
        public string Name
        {
            get
            {
                return this.name;
            }
        }
        public void addProperties(string Type, int Index)
        {
            if (!this.properties.ContainsKey(Type))
            {
                this.properties.Add(Type, new List<int> { Index });
            }
            else
            {
                this.properties[Type].Add(Index);
            }
        }
        public void SortAndArange()
        {
            //Console.WriteLine("#{0}", this.Name);
            foreach (string type in this.properties.Keys)
            {
                foreach (int index in this.properties[type])
                {
                    this.UnsortedList.Add(new KeyValuePair<string, int>(type, index));
                    //Console.WriteLine("{0} <-> {1}", type, index);                    
                }               
                UnsortedList.Sort((x, y) => -x.Value.CompareTo(y.Value));
                //UnsortedList.Sort(delegate (KeyValuePair<string, int> x, KeyValuePair<string, int> y) { return -x.Value.CompareTo(y.Value); });
                //UnsortedList.Reverse();
               
            }
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
                    var checkExPok = PoKDataBase.Find(p => p.Name == words[0]);
                    if (checkExPok != null)
                    {
                        checkExPok.addProperties(words[1], int.Parse(words[2]));
                    }
                    else
                    {
                        Pokemon currentPok = new Pokemon(words[0], words[1], int.Parse(words[2]));
                        PoKDataBase.Add(currentPok);
                    }
                }

                Line = Console.ReadLine();
                int y = 0;
            }
            if (UniquePokemons.Count != 0)
            {
                foreach (var s in UniquePokemons)
                {
                    Console.WriteLine("# {0}", s);
                    var currentPok = PoKDataBase.Find(x => x.Name == s);
                    foreach (var type in currentPok.properties)
                    {
                        foreach (var i in type.Value)
                        {
                            Console.WriteLine("{0} <-> {1}", type.Key, i);

                        }
                    }
                }
            }
            foreach (var iter in PoKDataBase)
            {
                iter.SortAndArange();
                
            }
            foreach (var c in PoKDataBase)
            {
                Console.WriteLine("# {0}", c.Name);
                foreach (var s in c.UnsortedList)
                {
                    Console.WriteLine("{0} <-> {1}", s.Key, s.Value);
                }
            }
            int t = 0;
        }
    }
}
