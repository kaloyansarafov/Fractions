using System;
using System.Linq;

namespace Fractions
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while(input != "END")
            {
                string[] fracts = input.Split(' ');
                if (fracts.Length != 3)
                {
                    Console.WriteLine("Invalid Expression");
                }
                else
                {
                    Fraction fr1 = Fraction.Parse(fracts[0]);
                    Fraction fr2 = Fraction.Parse(fracts[2]);
                    string op = fracts[1];


                    switch (op)
                    {
                        case "+":
                            Console.WriteLine(fr1 + fr2);
                            break;
                        case "-":
                            Console.WriteLine(fr1 - fr2);
                            break;
                        case "*":
                            Console.WriteLine(fr1 * fr2);
                            break;
                        case "/":
                            Console.WriteLine(fr1 / fr2);
                            break;
                        case "==":
                            Console.WriteLine(fr1 == fr2);
                            break;
                        case "!=":
                            Console.WriteLine(fr1 != fr2);
                            break;
                        case ">":
                            Console.WriteLine(fr1 > fr2);
                            break;
                        case "<":
                            Console.WriteLine(fr1 < fr2);
                            break;
                        case ">=":
                            Console.WriteLine(fr1 >= fr2);
                            break;
                        case "<=":
                            Console.WriteLine(fr1 <= fr2);
                            break;
                        default:
                            break;
                    }
                }
                input = Console.ReadLine();
            }
        }
    }
}
