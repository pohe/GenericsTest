using System;

namespace Sandbox
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            // Generics Test 1
            Dog self = new Dog("King");
            Dog mom = new Dog("Spot");
            Dog dad = new Dog("Rufus");

            FamilyRelation relations = new FamilyRelation(self, mom, dad);
            relations.AddChild(new Dog("Lajka"));
            relations.AddChild(new Dog("Luop"));
            Console.WriteLine(relations.ToString());



            //Console.WriteLine("Hello world!");

            // The LAST line of code should be ABOVE this line
        }
    }
}