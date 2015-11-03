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
            int valA, valB, valC;
            int d, x1, x2;

            Console.WriteLine("Enter A: ");
            valA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter B: ");
            valB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter C: ");
            valC = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}x^2 + {1}x + {2}", valA, valB, valC);

            d = (valB * valB) - (4 * valA * valC);

            if (d == 0)
            {
                x1 = -(valB / (2 * valA));
                Console.WriteLine("X = {0}", x1);
            }
            else if (d > 0)
            {
                x1 = (int)((-valB) + Math.Sqrt(d)) / 2 * valA;
                x2 = (int)((-valB) - Math.Sqrt(d)) / 2 * valA;
                Console.WriteLine("X1 = {0}, X2 = {1}", x1, x2);
            }
            else
                Console.WriteLine("The Quadratic Equation has no roots!");


            //int[] values;
            //values = new int[5];
            //int temp = 0;

            //for (int i = 0; i <= 4; ++i)
            //{
            //    Console.WriteLine("Enter {0} Number : ", i + 1);
            //    try
            //    {
            //        values[i] = Convert.ToInt32(Console.ReadLine());
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Invalid input. Please enter a Whole Number!");
            //        --i; // HackFix :D 
            //        continue;

            //    }
            //    if (temp < values[i])
            //        temp = values[i];
            //}
            //Console.WriteLine("The biggest Number is: {0}", temp);
        }
    }
}
