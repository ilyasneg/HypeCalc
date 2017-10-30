﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcLibrary;

namespace ConsoleApp
{
    class Program
    {
        //operation x y
        static void Main(string[] args)
        {
            var calc = new Calculator();
            Console.WriteLine("Hype Calc");

            if (args.Count() == 3)
            {
                var operation = args[0];

                if (operation == "sum")
                {
                    Console.WriteLine(calc.Sum(args[1], args[2]));
                }
            }

            Console.ReadKey();
        }
    }
}
