using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchValsCSharp
{
    class SwitchValsCSharp
    {
        static void Main(string[] args)
        {
            int val1, val2;
            val1 = val2 = 0;


            Console.WriteLine("Enter Val1: ");
            val1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Val2: ");
            val2 = Convert.ToInt32(Console.ReadLine());

            if(val1 > val2)
            {
                val1 += val2;
                val2 = val1 - val2;
                val1 = val1 - val2;
            }
            Console.WriteLine("Val1: {0} : Val2: {1}", val1, val2);
        }
    }
}
