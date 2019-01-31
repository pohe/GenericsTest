using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            // Generics Test 3
            Dog self = new Dog("Luop", 55,40);
            Dog mom = new Dog("Mapsy", 45, 30);
            Dog dad = new Dog("Fathsy", 75, 95);
            FamilyRelation<Dog> relations = new FamilyRelation<Dog>(self, dad, mom );
            relations.AddChild(new Dog("Lajka", 45, 20));
            relations.AddChild(new Dog("Specy", 45, 20));
            Console.WriteLine("Dog relations: ");
            Console.WriteLine(relations.ToString());

            Cat a = new Cat("Stripe");
            Cat b = new Cat("Socks");
            Cat c = new Cat("Abby");

            FamilyRelation<Cat> catRelations = new FamilyRelation<Cat>(a, b, c);
            Console.WriteLine("Cat relations: ");
            Console.WriteLine(catRelations.ToString());
            

            // The LAST line of code should be ABOVE this line
        }
    }
}
