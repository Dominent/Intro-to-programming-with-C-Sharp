using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWriteRCircleCSharp
{
    class ReadWriteRCircleCSharp
    {
        static void Main(string[] args)
        {
            int r ,s ,p;
            Console.WriteLine("Enter R: ");
            r = Convert.ToInt32(Console.ReadLine());
            s = (int)(3.14 * (r * r));
            p = (int)(2 * 3.14 * r);

            Console.WriteLine("Area: {0}, Perimeter: {1}", s, p);
        }
    }
}
