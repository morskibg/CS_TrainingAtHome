﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());
            nums.Sort();
            for(int i = nums.Count - 1; i > nums.Count - 1 - n; --i)
            {
                Console.Write(nums[i] + " ");
            }
        }
    }
}
