using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            int valA;
            int valB;
            int valC;
            int valD;
            int valX1;
            int valX2;
            int valX; // When we have only 1 root !
            valA = valB = valC = 0;

            for (int i = 0; i < 1; ++i) // I Love my Try catch statement :D
            {
                try
                {
                    Console.WriteLine("Enter value for a: ");
                    valA = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter value for b: ");
                    valB = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter value for c: ");
                    valC = Convert.ToInt32(Console.ReadLine());
                }
                catch(FormatException)
                {
                    Console.WriteLine("Wrong Input.");
                    --i;
                }
            }

            valD = (int)(Math.Pow(valB, 2) - (4 * valA * valC));

            if(valD == 0)
            {
                valX = -(valB / (2 * valA));
                Console.WriteLine("The Quadratic Equation has only one root X = {0}", valX);
            }
            else if(valD > 0)
            {
                valX1 = (int)((-valB + Math.Sqrt(valD)) / (2 * valA));
                valX2 = (int)((-valB - Math.Sqrt(valD)) / (2 * valA));
                Console.WriteLine("The Quadratic Equation has two roots X1 = {0} : X2 = {1}", valX1, valX2);
            }
            else //valD <0
            {
                Console.WriteLine("The Quadratic Equation has No roots.");
            }


        }
    }
}
