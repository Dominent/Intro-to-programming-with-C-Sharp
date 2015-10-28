using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarEvenOrOdd
{
    class VarEvenOrOdd
    {
        static void Main(string[] args)
        {
            int val1;
            
            

            val1 = Convert.ToInt32(Console.ReadLine());
            if (val1 % 2 == 1)
                Console.WriteLine("Odd");
            else if(val1 % 2 == 0)
                Console.WriteLine("Even");
           
        }
    }
}
