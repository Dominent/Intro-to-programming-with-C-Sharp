using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPointInCircle
{
    class CheckPointInCircle
    {
        static void Main(string[] args)
        {
            double valX;
            double valY;
            valX = valY = 0;
            double check;


            Console.WriteLine("Enter X:");
            valX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Y:");
            valY = Convert.ToInt32(Console.ReadLine());


            check = (valX * valX) + (valY * valY);

            if (check <= 25)
                Console.WriteLine("The Point is in the circle ((0,0), 5)");
            else
                Console.WriteLine("The Point is NOT in the circle ((0,0), 5)");



        }
    }
}
