using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrecisionCalc
{
    class PrecisionCalc
    {
        static void Main(string[] args)
        {
            int i = 0;
            double sum = 0;
            double sumOld = 0;
            while(true)
            {
                ++i;
                sumOld = sum;
                sum += (1.0 / i);
                if (sum - sumOld < 0.001)
                    break;
                                        
            }
            Console.WriteLine("The sum is: {0}", sum);
        }
    }
}
