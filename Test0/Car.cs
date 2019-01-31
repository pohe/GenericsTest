using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test0
{
    public class Car
    {
        public string LicensePlate { get; set; }

        public Car(string licensePlate)
        {
            LicensePlate = licensePlate;
        }

        public override string ToString()
        {
            return $"Car licensPlate {LicensePlate}";
        }
    }
}
