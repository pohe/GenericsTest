using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test6
{
    //The keywords in and out in make our intention explicit
    public interface ICGet <out T>
    {
        T Get();
    }

    public interface ICSet<in T>
    {
        void Set(T t);
    }

    public class C<T>: ICGet<T>, ICSet<T>
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
