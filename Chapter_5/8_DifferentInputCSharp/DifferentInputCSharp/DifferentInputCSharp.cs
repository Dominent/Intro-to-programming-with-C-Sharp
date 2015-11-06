using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentInputCSharp
{
    class DifferentInputCSharp
    {
        static void Main(string[] args)
        {
            string valString1;

            int valInt1 = 0;
            byte valByte1 = 0;
            double valDouble1 = 0;

            Console.WriteLine("Enter a String, Double or Int: ");
            valString1 = Console.ReadLine();
            
             if( int.TryParse(valString1, out valInt1))
             {
                 valInt1 = int.Parse(valString1);
                 valByte1 = 1;
                 
             }
             else if (double.TryParse(valString1, out valDouble1))
             {
                 valDouble1 = double.Parse(valString1);
                 valByte1 = 2;
             }
             else
             {
                 valByte1 = 3;
             }
            switch(valByte1)
            {
                case 1:
                    {
                        valInt1++;
                        Console.WriteLine("{0}", valInt1);
                    }
                    break;
                case 2:
                    {
                        valDouble1++;
                        Console.WriteLine("{0}", valDouble1);
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine(valString1 + "*");
                    }
                    break;
                default :
                    {
                        Console.WriteLine("I guess something went wrong.");
                    }
                    break;
            }
        }
    }
}
