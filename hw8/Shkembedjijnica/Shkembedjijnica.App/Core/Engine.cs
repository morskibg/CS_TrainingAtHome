using System;
using System.Collections.Generic;
using System.Text;
using Shkembedjijnica.App.Core.Contracts;

namespace Shkembedjijnica.App.Core
{
    public class Engine : IEngine
    {
        public void Run()
        {
            while (true)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            }
        }
    }
}
