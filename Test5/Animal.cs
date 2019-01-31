using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test5
{
    public class Animal
    {
        public string Name { get; set; }
        private string _type;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public Animal(string name, string type)
        {
            Name = name;
            Type = type;
        }


    }
}
