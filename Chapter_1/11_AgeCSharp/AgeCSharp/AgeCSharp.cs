//Calculate age after 10 years

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeCSharp
{
    class AgeCSharp
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter you current age: ");
            int age = int.Parse(Console.ReadLine());
            int birthYear = DateTime.Now.Year - age;
            DateTime futureDate = DateTime.Now.AddYears(10);
            int ageInTenYears = futureDate.Year - birthYear;

            Console.WriteLine();
            Console.WriteLine("You are {0} years old.", age);
            Console.WriteLine("In ten years you will be {0} years old.", ageInTenYears);
            Console.WriteLine();
        }
    }
}
