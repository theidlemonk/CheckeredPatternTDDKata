using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckerBoard
{
   public class CheckeredPatterns
    {
        public static bool IsEven(int number)
        {
            if ((number % 2) == 0)
            {
                return true;
            }
            return false;
        }
        public static string GetCrissCrossPatternForRow(int rowNumber)
        {
            if (IsEven(rowNumber))
            {
                return "x - x - x - x - x -";
            }
            return "- x - x - x - x - x";
        }

        public static string GetCrissCrossInvertedPatternForRow(int rowNumber)
        {
            return GetCrissCrossPatternForRow(rowNumber + 1);
        }

        public static string GetZebraPatternForRow(int rowNumber)
        {
            if (IsEven(rowNumber))
            {
                return "x x x x x x x x x x";
            }
            return "- - - - - - - - - -";
        }

        public static string GetZebraInvertedPatternForRow(int rowNumber)
        {
            return GetZebraPatternForRow(rowNumber + 1);
        }
    }
}
