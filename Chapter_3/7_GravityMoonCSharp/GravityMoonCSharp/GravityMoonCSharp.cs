using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GravityMoonCSharp
{
    class GravityMoonCSharp
    {
        static void Main(string[] args)
        {
            double valA;
            valA = 0;
            double weightOnMoon;
            
            Console.WriteLine("Enter Weight of Human on Earth:");
            valA = Convert.ToInt32(Console.ReadLine());
            
            //weightOnMoon = (valA /9.8) * (9.8 * 0.17);
            weightOnMoon = (valA * 0.17);

            
            Console.WriteLine("The Wight of The Human on the Moon is:  " + weightOnMoon);
        }
    }
}
