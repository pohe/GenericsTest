namespace Test3
{
    public class Cat
    {
        private string _name;
        public string Name
        {
            get { return _name; }
        }

        public Cat(string name)
        {
            this._name = name;
        }
        public override string ToString()
        {
            return $"Name {_name} ";
        }
    }
}