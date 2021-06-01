using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labtask
{
    class Program
    {
        static void Main(string[] args)
        {
            SwappingValues s1 = new SwappingValues();
            int a = 10;
            int b = 20;

            s1.SwapValues1(ref a, ref b);

            s1.SwapValues2(out a, out b);
        }
    }
}
