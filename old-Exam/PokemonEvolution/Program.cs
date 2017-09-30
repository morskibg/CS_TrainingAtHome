using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonEvolution
{
    class Pokemon
    {
        public string name;
        public List<string> type;
        public List<int> index;
      
        public Pokemon(string Name, string Type, int Index)
        {
            this.name = Name;
            this.type = new List<string>();
            this.type.Add(Type);
            this.index = new List<int>();
            this.index.Add(Index);
        }
        public string getName()
        {
            return this.name;
        }
        public void setType(string inputType)
        {
            this.type.Add(inputType);
        }
        public void setIndex(int inputIdx)
        {
            this.index.Add(inputIdx);
        }
        //public string Name
        //{
        //    get
        //    {
        //        return this.name;
        //    }
        //    set
        //    {
        //        this.name = value;
        //    }
        //}
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Pokemon> PokemonDatabase = new List<Pokemon>();           
            List<string> SpecialPokemon = new List<string>();
            string InputLine = Console.ReadLine();
            int idx = 0;

            while(InputLine != "wubbalubbadubdub")
            {               
                if (InputLine.IndexOf("->") == -1){                   
                    //var PokemonToPrint = PokemonDatabase.Find(s => s.getName() == InputLine.Trim());
                    //if(PokemonToPrint != null)
                    //{
                    //    Console.WriteLine("#{0}",PokemonToPrint.getName());
                    //    for(int i = 0; i < PokemonToPrint.type.Count; ++i)
                    //    {
                    //        Console.WriteLine("{0} <-> {1}", PokemonToPrint.type[i], PokemonToPrint.index[i]);
                    //    }
                    //}
                    SpecialPokemon.Add(InputLine.Trim()); // may need trim()
                }
                else
                {
                    char[] delimiters = { ' ', '-', '>' };
                    string[] words = InputLine.Split(delimiters, System.StringSplitOptions.RemoveEmptyEntries);
                    var FindPokemon = PokemonDatabase.Find(x => x.getName() == words[0]);
                    if(FindPokemon == null)
                    {                       
                        Pokemon CurrentPok = new Pokemon(words[0], words[1], int.Parse(words[2]));
                        PokemonDatabase.Add(CurrentPok);
                    }
                    else
                    {
                        FindPokemon.setType(words[1]);
                        FindPokemon.setIndex(int.Parse(words[2]));
                    }                    
                }                
                InputLine = Console.ReadLine();
            }
            if(SpecialPokemon.Count != 0)
            {
                //int count = SpecialPokemon.Count();
                foreach(var s in SpecialPokemon)
                {
                   
                    var FindPokemon = PokemonDatabase.Find(x => x.getName() == s);
                    if(FindPokemon != null)
                    {
                        Console.WriteLine("#{0}", s);
                        for(int i = 0; i < FindPokemon.type.Count; ++i)
                        {
                            Console.WriteLine("{0} <-> {1}", FindPokemon.type[i], FindPokemon.index[i]);
                        }
                    }
                }
            }
            foreach(var currPok in PokemonDatabase)
            {
                Console.WriteLine("#{0}", currPok.getName());
                
                foreach(var id in currPok.index)
                {

                }
            }
            int t = 0;
        }
    }
}
