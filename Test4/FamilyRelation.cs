using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4
{
    public class FamilyRelation<T> where T : Animal
    {
        private T _self;
        private T _father;
        private T _mother;
        private List<T> _children;

        public FamilyRelation(T self, T father, T mother)
        {
            _self = self;
            _father = father;
            _mother = mother;
            _children = new List<T>();
        }

        public FamilyRelation(T self)
        {
            _self = self;
            _father = null;
            _mother = null;
        }

        public T Self { get { return _self; } }

        public T Father { get { return _father; } }

        public T Mother { get { return _mother; } }

        public List<T> Children { get { return _children; } }

        public void AddChild(T child)
        {
            _children.Add(child);
        }

        public void PrintNamesOfParents()
        {
            Console.WriteLine(_father.Name + " and " + _mother.Name);
        }

        public override string ToString()
        {
            string children = "";
            foreach (T c in Children)
            {
                children += c.Name + ", ";
            }
            return $"Self {Self.Name} mother {Mother.Name} father {Father.Name} chrildren {children} ";
        }
    }
}
