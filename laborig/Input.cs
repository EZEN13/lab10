using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLab10
{
    public class Input
    {
        [ExcludeFromCodeCoverage]
        public static int ReadInt()
        {
            int temp;
            while (!int.TryParse(Console.ReadLine(), out temp)) ;
            return temp;
        }

        [ExcludeFromCodeCoverage]
        public static double ReadDouble()
        {
            double temp;
            while (!double.TryParse(Console.ReadLine(), out temp)) ;
            return temp;
        }
    }
}

