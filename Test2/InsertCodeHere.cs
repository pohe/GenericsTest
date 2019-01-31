using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            // Generics Test 2
            Cat self = new Cat("King", "Cat");
            Dog mom = new Dog("Spot", "Dog");
            Dog dad = new Dog("Rufus", "Dog");

            FamilyRelation relations = new FamilyRelation(self, mom, dad);
            relations.AddChild(new Dog("Lajka", "Dog"));
            relations.AddChild(new Dog("Luop", "Cat"));
            Console.WriteLine(relations.ToString());


            Cat mySelf = (Cat) relations.Self;
            Console.WriteLine($"Name of Self {mySelf.Name} I am a {mySelf.Type}");
            //Assignment: Write the Name and type of the Father and Mother
            Dog father = (Dog)relations.Father;
            Console.WriteLine($"Name of father {father.Name} I am a {father.Type}");
            Dog mother = (Dog)relations.Mother;
            Console.WriteLine($"Name of mother {mother.Name} I am a {mother.Type}");


            // The LAST line of code should be ABOVE this line
        }
    }
}
