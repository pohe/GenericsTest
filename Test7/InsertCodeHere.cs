using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Test7
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            //// The FIRST line of code should be BELOW this line
            //// Generics Test 7
            //List<int> integers = new List<int>();
            //integers.Add(12);
            //integers.Add(13);
            //integers.Add(10);
            //foreach (int x in integers)
            //{
            //    Console.WriteLine(x);
            //}
            //integers.Sort();
            //foreach (int x in integers)
            //{
            //    Console.WriteLine(x);
            //}

            Dog d1 = new Dog("King", 70);
            Dog d2 = new Dog("Spot", 30);
            Dog d3 = new Dog("Coco", 70);
            List<Animal> animals = new List<Animal>();
            animals.Add(d1);
            animals.Add(d2);
            animals.Add(d3);
            animals.Add(new Dog("Rufus", 80));
            Console.WriteLine("Before sorting");
            printOutAnimals(animals);

            animals.Sort();
            Console.WriteLine("Efter sortering");
            printOutAnimals(animals);
            //if (d1.CompareTo(d2) < 0)
            //    Console.WriteLine($"d1 {d1.Weight} er mindre end d2 {d2.Weight}");
            //else
            //{
            //    Console.WriteLine($"d1 {d1.Weight}er større end eller lig d2 {d2.Weight}");
            //}
            //Console.WriteLine("Sortering ved vægt");
            //animals.Sort();
            //printOutAnimals(animals);
            //if (d1.CompareTo(d2) > 0)
            //    Console.WriteLine("Default sammenligning");
            //IComparer<Animal> comparer = new AnimalComparerByName();
            //if (comparer.Compare(d1, d2) > 0)
            //    Console.WriteLine($"d1s navn er alfabetisk før d2s navn");
            //else
            //    Console.WriteLine($"d2s navn er alfabetisk før d1s navn");
            //animals.Sort(comparer);
            //IComparer<Animal> comparer = new AnimalComparerByWeightLowToHigh();
            //animals.Sort(comparer);
            //Console.WriteLine("Sortering ved navn");
            //IComparer<Animal> comparer1 = new AnimalComparerByName();
            //animals.Sort(comparer1);
            //Console.WriteLine("After sorting");
            //printOutAnimals(animals);


            //Console.ReadKey();
            //// The LAST line of code should be ABOVE this line
        }

        private void printOutAnimals(List<Animal> animals)
        {
            foreach (Animal anAnimal in animals)
            {
                Console.WriteLine(anAnimal.ToString());
            }
        }
    }
}
