using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarDivideModulus
{
    class VarDivideModulus
    {
        static void Main(string[] args)
        {
            int var1;
            

            var1 = Convert.ToInt32(Console.ReadLine());


            if (var1 % 5 == 0 || var1 % 7 == 0)
                Console.WriteLine("Divides without remainder");
            else
                Console.WriteLine("Divides with remainder");

            
        }
    }
}
