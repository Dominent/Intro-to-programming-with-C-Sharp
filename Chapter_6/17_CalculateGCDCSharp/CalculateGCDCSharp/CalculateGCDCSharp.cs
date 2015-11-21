using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateGCDCSharp
{
    class CalculateGCDCSharp
    {
        static void Main(string[] args)
        {
            double valOne, valTwo;
            valOne = valTwo = 0.0d;
            int GCD = 0;

            Console.WriteLine("Enter Val1: ");
            valOne = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Val2: ");
            valTwo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The Greatest Common Divider of : {0} and {1} is : ", valOne, valTwo);

            if (valOne > valTwo)
            {
                while (true)
                {
                    valOne = valOne % valTwo;
                    GCD = (int)valTwo;
                    if (valOne == 0 || valTwo == 0)
                    {
                        break;
                    }
                    valTwo = valTwo % valOne;
                    GCD = (int)valOne;
                }
            }
            else if (valOne < valTwo)
            {
                while (true)
                {
                    valTwo = valTwo % valOne;
                    GCD = (int)valOne;
                    if (valOne == 0 || valTwo == 0)
                    {
                        break;
                    }
                    valOne = valOne % valTwo;
                    GCD = (int)valTwo;
                }
            }
            else
            {
                GCD = (int)valOne;
            }
            Console.WriteLine(GCD);
            Console.ReadLine();
        }
    }
}
