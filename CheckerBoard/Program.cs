using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckerBoard
{
    public class Program
    {
        static void Main(string[] args)
        {
            ConsoleStart();
            int patternSelection = Convert.ToInt16(Console.ReadLine());
            ResolveRequestedPatternOnConsole(patternSelection);

            Console.ReadKey();
        }

        private static void ConsoleStart()
        {
            Console.Title = "Checker Board";
            Console.WriteLine("Hello, Please make a Selection of a Checker Board Design Pattern:");
            Console.WriteLine("  1. CrissCross\n  2. CrissCross Inverted\n  3. Zebra\n  4. Zebra Inverted");
        }

        private static void ResolveRequestedPatternOnConsole(int patternNumber)
        {
            int i = 0;
            PrintInitialColumnNumbering(i);
            if (patternNumber == 1)
            {
                while (i < 10)
                {
                    RowColorAlternator(i);
                    Console.WriteLine(i + "   " + CheckeredPatterns.GetCrissCrossPatternForRow(i));
                    i++;
                }
            }
            else if (patternNumber == 2)
            {
                while (i < 10)
                {
                    RowColorAlternator(i);
                    Console.WriteLine(i + "   " + CheckeredPatterns.GetCrissCrossInvertedPatternForRow(i));
                    i++;
                }
            }
            else if (patternNumber == 3)
            {
                while (i < 10)
                {
                    RowColorAlternator(i);
                    Console.WriteLine(i + "   " + CheckeredPatterns.GetZebraPatternForRow(i));
                    i++;
                }
            }
            else if (patternNumber == 4)
            {
                while (i < 10)
                {
                    RowColorAlternator(i);
                    Console.WriteLine(i + "   " + CheckeredPatterns.GetZebraInvertedPatternForRow(i));
                    i++;
                }
            }

        }

        private static void RowColorAlternator(int i)
        {
            if (CheckeredPatterns.IsEven(i))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
        }

        private static void PrintInitialColumnNumbering(int startingNumber)
        {
            Console.Clear();
            Console.Write("    ");
            while (startingNumber < 10)
            {
                Console.Write(startingNumber+ " ");
                startingNumber++;
            }
            Console.Write("\n\n");
        }

    }
}
