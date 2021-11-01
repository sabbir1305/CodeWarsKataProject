using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKata.Solutions
{
    public class Triangle
    {
        public static bool IsTriangle(int a, int b, int c)
        {
            bool sideA = (b + c) > a;
            bool sideB = (a + c) > b;
            bool sideC = (a + b) > c;
            return sideA && sideB && sideC;
        }
    }

}
