using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLab10
{
    public class SortByWheels : IComparer
    {
        [ExcludeFromCodeCoverage]
        public int Compare(object x, object y)
        {
            Transport p1 = x as Transport;
            Transport p2 = y as Transport;

            if (p1.Wheels < p2.Wheels)
            {
                return -1;
            }
            else if (p1 == p2)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
