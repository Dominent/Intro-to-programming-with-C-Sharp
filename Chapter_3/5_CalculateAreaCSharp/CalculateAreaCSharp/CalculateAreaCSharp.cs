using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAreaCSharp
{
    class CalculateAreaCSharp
    {
        static void Main(string[] args)
        {
            int valA, valB, valH;
            valA = valB = valH = 0;
            int area;


            Console.WriteLine("Enter A:");
            valA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter B:");
            valB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter H:");
            valH = Convert.ToInt32(Console.ReadLine());

            area = ((valA + valB) / 2) * valH;

            Console.WriteLine("The area is: " + area);

            
        }
    }
}
