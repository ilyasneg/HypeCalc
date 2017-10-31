using System;
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

                do
                {
                    try
                    {
                        switch (operation)
                        {
                            case "sum":
                                Console.WriteLine(calc.Sum(args[1], args[2]));
                                break;
                            case "sub":
                                Console.WriteLine(calc.Sub(args[1], args[2]));
                                break;
                            case "mult":
                                Console.WriteLine(calc.Mult(args[1], args[2]));
                                break;
                            case "div":
                                Console.WriteLine(calc.Div(args[1], args[2]));
                                break;
                            case "pow":
                                Console.WriteLine(calc.Pow(args[1], args[2]));
                                break;
                            case "mod":
                                Console.WriteLine(calc.Mod(args[1], args[2]));
                                break;
                            case "exit":
                                return;
                            default:
                                Console.WriteLine("Нет такой операции");
                                break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    operation = Console.ReadLine();
                } while (true);
            }

            Console.ReadKey();
        }
    }
}
