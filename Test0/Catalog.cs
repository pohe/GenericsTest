using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test0
{
    public class Catalog<T>
    {
        private static int _keyCount = 1;
        private Dictionary<int, T> _objects;

        public Catalog()
        {
            _objects = new Dictionary<int, T>();
        }

        public List<T> All
        {
            get { return _objects.Values.ToList(); }
        }

        public void Add(T obj)
        {
             _keyCount++;
            _objects.Add(_keyCount, obj);
        }

        public bool Delete(int key)
        {
            return _objects.Remove(key);
        }
    }

}
