﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1._1_RECTANGLE
{
    class Program
    {
        static int Area(int a, int b)
        {
            return a* b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a:");
            int a = 0, b = 0;
            string input = Console.ReadLine();
            bool result = int.TryParse(input, out a);
            while (a == 0)
            {
                if (result)
                {
                }
                else
                {
                    Console.WriteLine("Invalid value entered");
                    Console.WriteLine("Enter a:");
                    input = Console.ReadLine();
                    result = int.TryParse(input, out a);
                }
            }
            Console.WriteLine("Enter b:\t");
            input = Console.ReadLine();
            result = int.TryParse(input, out b);
            while (b == 0)
            {
                if (result)
                {
                }
                else
                {
                    Console.WriteLine("Invalid value entered");
                    Console.WriteLine("Enter a:");
                    input = Console.ReadLine();
                    result = int.TryParse(input, out b);
                }
            }
            if (a < 0 || b < 0)
            {
                Console.WriteLine("Invalid value entered");
            }
            else
            {
                Console.WriteLine("Area: {0}", Area(a, b));
            }
            Console.ReadLine();

        }
    }
}
