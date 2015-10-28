using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjToStringCSharp
{
    class ObjToStringCSharp
    {
        static void Main(string[] args)
        {
            string text1 = "Hello";
            string text2 = "World";
            string objToString;

            object addStrings = text1 + " " + text2;

            objToString = (string)addStrings;

            System.Console.WriteLine(addStrings);

            System.Console.WriteLine("Result: {0}", objToString);
        }
    }
}
