﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 };
            int count = Count(numbers,5);
            Console.WriteLine($"5の個数は{count}です");
        }

        public static int Count(int[] numbers,int num)
        {
            int count = 0;
            foreach(var n in numbers)
            {
                if (n == num)
                    count++;
            }
            return count;
        }
    }
}
