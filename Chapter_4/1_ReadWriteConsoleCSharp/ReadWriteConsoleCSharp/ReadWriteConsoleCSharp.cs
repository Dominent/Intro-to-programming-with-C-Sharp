using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWriteConsoleCSharp
{
    class ReadWriteConsoleCSharp
    {
        static void Main(string[] args)
        {
            int val1, val2, val3;

            Console.WriteLine("Enter first number: ");
            val1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            val2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter third number: ");
            val3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("First {0} , Second {1} , Third {2} ", val1, val2, val3);
        }
    }
}
