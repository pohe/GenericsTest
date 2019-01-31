using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test0
{
    class BiCycle
    {
        public string Model { get; set; }

        public BiCycle(string model)
        {
            Model = model;
        }

        public override string ToString()
        {
            return Model;
        }
    }
}
