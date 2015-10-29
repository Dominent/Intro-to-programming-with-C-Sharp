using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input4DigitNumberAndCalcCSharp
{
    class Input4DigitNumberAndCalcCSharp
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            a = b = c = d = 0;
            int sum;

            Console.WriteLine("Enter a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter c: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter d: ");
            d = Convert.ToInt32(Console.ReadLine());

            sum = a + b + c + d;

            Console.WriteLine("a+b+c+d = : " + sum);

            Console.WriteLine("D+C+B+A = : " + d + " " + c + " " + b + " " + a);
            Console.WriteLine("D+A+B+C = : " + d + " " + a + " " + b + " " + c);
            Console.WriteLine("A+C+B+D = : " + a + " " + c + " " + b + " " + d);





            
        }
    }
}
