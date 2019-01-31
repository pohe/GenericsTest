using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test0
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            // Generics Test 0
            CarCatalog carCatalog = new CarCatalog();
            Car c1 = new Car("CD 122334");
            Car c2 = new Car("DC 434343");
            carCatalog.Create(c1);
            carCatalog.Create(c2);
            Console.WriteLine("List all cars in Carcatalog");
            foreach (Car aCar in carCatalog.All)
            {
                Console.WriteLine(aCar.ToString());    
            }
            carCatalog.Delete(c1.LicensePlate);
            Console.WriteLine("List all cars in Carcatalog after 1 car har been deleted");
            foreach (Car aCar in carCatalog.All)
            {
                Console.WriteLine(aCar.ToString());
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Catalog<Car> catalog = new Catalog<Car>();
            catalog.Add(c1);
            catalog.Add(c2);
            Console.WriteLine("List all cars in Generic Catalog");
            foreach (Car aCar in catalog.All){
                Console.WriteLine(aCar.ToString());
            }
            catalog.Delete(1);
            Console.WriteLine("List all cars in Generic Catalog after 1 car har been deleted");

            foreach (Car aCar in catalog.All)
            {
                Console.WriteLine(aCar.ToString());
            }


            Catalog<BiCycle> catalogBiCycle = new Catalog<BiCycle>();
            BiCycle b1 = new BiCycle("SCO");
            BiCycle b2 = new BiCycle("BMX");
            catalogBiCycle.Add(b1);
            catalogBiCycle.Add(b2);
            List<BiCycle> bicycles= catalogBiCycle.All;
            foreach (BiCycle aBicycle in catalogBiCycle.All)
            {
                Console.WriteLine(aBicycle.ToString());
            }
        }
    }
}
