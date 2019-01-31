namespace Test6
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