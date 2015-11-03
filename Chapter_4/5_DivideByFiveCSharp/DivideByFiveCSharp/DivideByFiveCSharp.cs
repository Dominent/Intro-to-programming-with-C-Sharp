using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideByFiveCSharp
{
    class DivideByFiveCSharp
    {
        static void Main(string[] args)
        {
            int val1, val2, count;
            val1 = val2 = count = 0;

            Console.WriteLine("Enter val1: ");
            val1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter val2: ");
            val2 = Convert.ToInt32(Console.ReadLine());

            
            for(int temp = val1;temp <= val2; ++temp)
            {
                if (temp % 5 == 0)
                    count++;
                else
                    continue;
            }
            GC.Collect();

            Console.WriteLine("Between {0} And {1} There Are {2} Numbers (Val%5 == 0)", val1, val2, count);
        }
    }
}
