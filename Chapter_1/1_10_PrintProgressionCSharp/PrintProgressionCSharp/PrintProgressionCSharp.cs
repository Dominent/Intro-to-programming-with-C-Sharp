// Prints out the first 100 numbers of the progression 2,-3, 4,-5 ...

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintProgressionCSharp
{
    class PrintProgressionCSharp
    {
        static void Main(string[] args)
        {

            for (int val = 2; val <= 100; ++val)
            {
                if (val % 2 != 0)
                {
                    val = val * -1;
                    System.Console.WriteLine(val);
                    val = val * -1;
                }
                else System.Console.WriteLine(val);
            }
        }
    }
}
