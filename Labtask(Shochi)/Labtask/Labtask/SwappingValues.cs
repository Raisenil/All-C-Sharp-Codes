using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labtask
{
    class SwappingValues
    {
        public void SwapValues1(ref int a, ref int b)
        {
            Console.WriteLine("Before SwapValues1 using Ref a=" + a + " b=" + b);
            int T;
            T = a;
            a = b;
            b = T;
            Console.WriteLine("After SwapValues1 using Ref a=" + a + " b=" + b);
        }
        public void SwapValues2(out int a, out int b)
        {
            a = 30;
            b = 60;
            Console.WriteLine("Before SwapValues1 using Out a=" + a + " b=" + b);
            int T;
            T = a;
            a = b;
            b = T;
            Console.WriteLine("After SwapValues1 using Out a=" + a + " b=" + b);
        }
    }
}
