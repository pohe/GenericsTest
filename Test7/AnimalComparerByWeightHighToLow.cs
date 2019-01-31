using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test7
{
    class AnimalComparerByWeightLowToHigh : IComparer<Animal>
    {
        public int Compare(Animal x, Animal y)
        {
            if (y.Weight < x.Weight) { return -1; }

            if (y.Weight > x.Weight) { return 1; }

            return 0;
        }
    }
}
