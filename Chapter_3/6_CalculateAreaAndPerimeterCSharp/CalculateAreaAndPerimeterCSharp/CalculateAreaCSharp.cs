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
            int valA, valB;
            valA = valB = 0;
            int area, perimeter;
            area = perimeter = 0;


            Console.WriteLine("Enter Length:");
            valA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Height:");
            valB = Convert.ToInt32(Console.ReadLine());


            area = valA * valB;
            perimeter = 2 * (valA + valB);

            Console.WriteLine("The area is: " + area);
            Console.WriteLine("The perimeter is: " + perimeter);


        }
    }
}