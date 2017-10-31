using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<int, int>> prob = new Dictionary<string, Dictionary<int, int>>();
            Dictionary<int, int> innerDict = new Dictionary<int, int>();
            innerDict.Add(1, 10);
            innerDict.Add(2, 20);
            innerDict.Add(3, 30);
            innerDict.Add(4, 40);
            innerDict.Add(5, 50);
            prob.Add("first",innerDict);
            string key = prob.Keys.First();
            Console.WriteLine(key);
            foreach (var item in prob)
            {
                Console.WriteLine(item.Value.Keys.First());
                item.Value.Keys.First();
            }
            prob.Keys.First();
            int t = 0;
        }
    }
}
