using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> tickets = Console.ReadLine().Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim()).ToList();
            for (int i = 0; i < tickets.Count; i++)
            {
                string currTicket = tickets[i];
                if (currTicket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

            }

        }
    }
}
