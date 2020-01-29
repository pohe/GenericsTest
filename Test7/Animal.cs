using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test7
{
    public class Animal: IComparable<Animal>
    {
        public string Name { get; set; }
        private int _weight;

        public int Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public Animal(string name, int weight)
        {
            Name = name;
            _weight = weight;
        }

        public int CompareTo(Animal other)
        {
            if (Weight < other.Weight) { return -1; }

            if (Weight > other.Weight) { return 1; }

            return 0;

            ////if (Name.CompareTo(other.Name) == 0)
            ////{
            ////    if (Weight < other.Weight) { return -1; }

            ////    if (Weight > other.Weight) { return 1; }

            ////    return 0;
            ////}

            //if (Name.CompareTo(other.Name)<0 ) { return -1; }

            //if (Name.CompareTo(other.Name) > 0) { return 1; }

            //return 0;


        }

        public override string ToString()
        {
            return $"Name {Name} Weight {Weight}";
        }

      
    }
}
