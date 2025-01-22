using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public static class MathHelperStatic
    {
        public static int Shuma(int a, int b)
        {
            return a + b;
        }

        //extension method
        public static int Reverse(this int a, int b)
        {
            return a ^ b;
        }
    }
}
