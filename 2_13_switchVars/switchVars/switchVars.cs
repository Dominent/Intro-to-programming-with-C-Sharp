using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchVars
{
    class switchVars
    {
        static void Main(string[] args)
        {
            int val1 = 5;
            int val2 = 10;

            Console.WriteLine();
            Console.WriteLine(val1 + "\t Val1");
            Console.WriteLine(val2 + "\t Val2");

            val2 = val1 + val2; //15
            val1 = val2 - val1; //10
            val2 = val2 - val1; //5

            Console.WriteLine();
            Console.WriteLine(val1 + "\t Val1");
            Console.WriteLine(val2 + "\t Val2");
        }
    }
}
