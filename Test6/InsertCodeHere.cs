using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test6
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            // Generics Test 6


            
            ICGet<Animal> icsa = new C<Dog>();
            Animal a = icsa.Get();  //OK 

            ICSet<Dog> icgd = new C<Animal>();
            icgd.Set(new Dog("Luoop", "shepherd")); //OK 


            // The LAST line of code should be ABOVE this line
        }
    }
}
