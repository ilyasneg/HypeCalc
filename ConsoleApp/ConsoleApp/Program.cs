using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        //operation x y
        static void Main(string[] args)
        {
            Console.WriteLine("Hype Calc");

            if (args.Count() == 3)
            {
                var operation = args[0];
                var x = args[1];
                var y = args[2];
                double result;

                if (operation == "sum")
                {
                    result = double.Parse(x) + double.Parse(y);
                }
            }

            Console.ReadKey();
        }
    }
}
