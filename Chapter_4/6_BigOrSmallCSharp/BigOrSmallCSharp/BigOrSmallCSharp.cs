using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigOrSmallCSharp
{
    class BigOrSmallCSharp
    {
        static void Main(string[] args)
        {
            int val1, val2;
            val1 = val2 = 0;
            Console.WriteLine("Enter Val1 : ");
            val1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Val1 : ");
            val2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Greater: {0}", (val1 + val2 + Math.Abs(val1 - val2)) / 2);
            Console.WriteLine("Smaller: {0}", (val1 + val2 - Math.Abs(val1 - val2)) / 2);
        }
    }
}
