using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test0
{
    
    public class CarCatalog
    {
        private Dictionary<string, Car> _objects;

        public CarCatalog()
        {
            _objects = new Dictionary<string, Car>();
        }

        public List<Car> All
        {
            get { return _objects.Values.ToList(); }
        }

        public void Create(Car obj)
        {
            _objects.Add(obj.LicensePlate, obj);
        }

        public void Delete(string licensePlate)
        {
            _objects.Remove(licensePlate);
        }
    }

    
}
