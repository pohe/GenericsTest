using System;

namespace Test4
{
    public class InsertCodeHere
    {
        public InsertCodeHere()
        {

        }
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            // Generics Test 4
            Dog self = new Dog("Luop");
            Dog mom = new Dog("Mapsy");
            Dog dad = new Dog("Fathsy");
            FamilyRelation<Dog> relations = new FamilyRelation<Dog>(self, dad, mom);
            relations.AddChild(new Dog("Lajka"));
            relations.AddChild(new Dog("Specy"));

            relations.PrintNamesOfParents();

            Console.WriteLine(relations.ToString());


            // The LAST line of code should be ABOVE this line
        }
    }
}