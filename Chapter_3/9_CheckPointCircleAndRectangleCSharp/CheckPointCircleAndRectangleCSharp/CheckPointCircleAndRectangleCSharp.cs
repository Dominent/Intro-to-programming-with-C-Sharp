using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPointCircleAndRectangleCSharp
{
    class CheckPointCircleAndRectangleCSharp
    {
        static void Main(string[] args)
        {
            double valX;
            double valY;
            valX = valY = 0.0;
            double check;


            Console.WriteLine("Enter X:");
            valX = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Y:");
            valY = Convert.ToDouble(Console.ReadLine());


            check = (valX * valX) + (valY * valY);

            if (check <= 25)
                Console.WriteLine("The Point is in the circle ((0,0), 5)");
            else
                Console.WriteLine("The Point is NOT in the circle ((0,0), 5)");

            if (valY >= -1 && valY <= 5)
            {
                if (valX >= 1 && valX <= 5)
                    Console.WriteLine("The Point is in the rectangle ((1,-1), (5,5))");
                else if (valX < 1)
                    Console.WriteLine("The Point is Not in the rectangle ((1,-1), (5,5))");
            }
            else
                Console.WriteLine("The Point is Not in the rectangle ((1,-1), (5,5))");

        }
    }
}
