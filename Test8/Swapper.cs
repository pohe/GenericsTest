using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test8
{
    class Swapper
    {
        public void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public void Swap2<T>( T a,  T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

    }
}
