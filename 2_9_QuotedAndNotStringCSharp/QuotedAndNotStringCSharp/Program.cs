// quoted strings 
// @ ("" "") || \" \"

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuotedAndNotStringCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string var1 = "The \"use\" of quotations causes difficulties.";
            string var2 = @"The "" use "" of quotations causes difficulties.";
        }
    }
}
