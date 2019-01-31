namespace Test3
{
    public class Dog
    {
        private string _name;
        private int _height;
        private int _weight;

        public string Name
        {
            get { return _name; }
        }

        public Dog(string name, int height, int weight)
        {
            this._name = name;
            this._height = height;
            this._weight = weight;
        }

        public override string ToString()
        {
            return $"Name {_name} height {_height} weight {_weight}";
        }
    }
}