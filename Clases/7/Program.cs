using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, double> inventory = new Dictionary<string, double>();
            List<Client> clients = new List<Client>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split('-').ToArray();
                inventory[tokens[0]] = double.Parse(tokens[1]);
            }
            string input = Console.ReadLine();
            while(input != "end of clients")
            {
                char[] delims = "-,".ToCharArray();
                string[] tokens = input.Split(delims,StringSplitOptions.RemoveEmptyEntries).ToArray();
                
                Client currClient = new Client(tokens[0], tokens[1], int.Parse(tokens[2]));

                clients.Add(currClient);
                input = Console.ReadLine();
            }
            foreach(var client in clients)
            {
                Console.WriteLine($"{client.Name}");
                foreach(var currClient in clients.Where(x => x.Name == client.Name))
                {
                    
                }
            }
           
        }
        class Client
        {
            public string Name { get; set; }
            public Dictionary<string, int> ShoppingBasket { get; set; }
            public Client(string name, string itemToBuy, int qty)
            {
                Name = name;
                ShoppingBasket = new Dictionary<string, int>() { { itemToBuy, qty } };
            }
            public double PricePerItem(string item)
            {
                if (ShoppingBasket.ContainsKey(item))
                {
                    return ShoppingBasket[item];
                }
                return -1;
            }
        }
    }
}
