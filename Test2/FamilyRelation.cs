﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    public class FamilyRelation
    {
        private Animal _self;
        private Animal _father;
        private Animal _mother;
        private List<Animal> _children;

        public FamilyRelation(Animal self, Animal father, Animal mother)
        {
            _self = self;
            _father = father;
            _mother = mother;
            _children = new List<Animal>();
        }

        public Animal Self { get { return _self; } }

        public Animal Father { get { return _father; } }

        public Animal Mother { get { return _mother; } }

        public List<Animal> Children { get { return _children; } }

        public void AddChild(Animal child)
        {
            _children.Add(child);
        }

        //Override the Tostring methods to printout the family relations
        public override string ToString()
        {
            string children = "";
            foreach (Animal dog in Children)
            {
                children += dog.Name + " ";
            }
            return $"Name of Animal {Self.Name} mother {Mother.Name} father {Father.Name} chrildren {children} ";
        }
    }
}
