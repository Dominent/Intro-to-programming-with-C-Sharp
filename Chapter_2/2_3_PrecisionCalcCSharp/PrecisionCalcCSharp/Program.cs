/* Write a program that calculates numbers with min precision of 0.000001 .*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrecisionCalcCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal val1 = 23.123456m;
            decimal val2 = 73.123456m;

            decimal addResult = val1 + val2;
            decimal subResult = val1 - val2;
            decimal mulResult = val1 * val2;
            decimal divResult = val1 / val2;

            System.Console.WriteLine("addition: " + (addResult) +
                "   substraction: " + (subResult) + "   multiplication: "
                        + (mulResult) + "    division: " + (divResult)); 

        }
    }
}
