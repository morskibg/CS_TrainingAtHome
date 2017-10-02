using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, long> inventory = new Dictionary<string, long>();
            while (input != "exam time")
            {
                string[] words = input.Split(' ').ToArray();
                string command = words.First();
                if (command == "shopping")
                {
                    input = Console.ReadLine();
                    continue;
                }
                string item = words[1];
                long qty = long.Parse(words[2]);
                if (command == "stock")
                {
                    if (inventory.ContainsKey(item))
                    {
                        inventory[item] += qty;
                    }
                    else
                    {
                        inventory[item] = qty;
                    }
                }
                else if (command == "buy")
                {
                    if (inventory.ContainsKey(item))
                    {
                        if (inventory[item] == 0)
                        {
                            Console.WriteLine($"{item} out of stock");
                        }
                        else if (inventory[item] > qty)
                        {
                            inventory[item] -= qty;
                        }
                        else
                        {
                            inventory[item] = 0;
                        }

                    }
                    else
                    {
                        Console.WriteLine($"{item} doesn't exist");
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var item in inventory.Where(kvp => kvp.Value != 0))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
