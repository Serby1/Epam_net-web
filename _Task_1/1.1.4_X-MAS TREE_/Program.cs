﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1._4_X_MAS_TREE_
{
    class Program
    {
        static void Main(string[] args)
        {
            uint N;
            Console.WriteLine("Enter N:");
            string input = Console.ReadLine();
            bool result = uint.TryParse(input, out N);
            if (result)
            { }
            else
            {
                Console.WriteLine("Invalid value entered");
            }
            string str = "*";
            for (int k = 1; k <= N; ++k)
            {
                for (int i = 1; i <= k; ++i)
                {
                    for (int j = 1; j <= N - i; ++j)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(str);
                    str = str + "**";
                    Console.WriteLine();
                }
                str = "*";
            }
            Console.ReadLine();
        }
    }
}
