using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test5
{
    public class C<T>
    {
        private T _t;
        public T Get()
        {
            return _t;
        }

        public void Set(T t)
        {
            _t = t;
        }
    }

}
