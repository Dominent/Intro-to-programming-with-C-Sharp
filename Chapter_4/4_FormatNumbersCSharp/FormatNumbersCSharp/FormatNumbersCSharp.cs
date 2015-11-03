using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatNumbersCSharp
{
    class FormatNumbersCSharp
    {
        static void Main(string[] args)
        {
            int wholeNumber = 32;  //0x20
            float realPosNumber = 3.14f;
            float realNegNumber = -3.14f;
            
            string WholeNumber = string.Format("{0:X8}", wholeNumber);
            string RealPosNumber = string.Format("{0:F2}", realPosNumber);
            string RealNegNumber = string.Format("{0:F2}", realNegNumber);

            

            Console.WriteLine("{0, -10} {1, -10} {2, -10}", WholeNumber, RealPosNumber, RealNegNumber);
            
        }
    }
}
