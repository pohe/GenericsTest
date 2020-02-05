using System.CodeDom;

namespace Test5
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            // Generics Test 5

            // Asumption 1
            //Is this valid ?
            //C<Animal> ca = new C<Dog>();

            //ca.Get();
            // This should be ok!

            // Only an object of type Dog can be returnes, and since Dog is a sub¬class of 
            // Animal, this is a perfectly valid object to return in response 
            // to calling the Get method on ca, since this method has the return type Animal
            // the Get method, the above statement would be safe

            // If we call:  
            //ca.Set(…); 

            // what type of objects will then be valid parameters ?
            // the Set method will accept any object of type Animal, 
            //including – but not limited to – Dog
            // This is not OK !!

            //Assumption 2
            // Is this valid?
            //C<Dog> cd = new C<Animal>();

            //cd.Get(); //This method can only return objects of type Dog, 
            // but we may easily have an object of a different type (e.g. Cat) 
            // in the referred-to object

            //cd.Set(); // ok
            // The Set method only accepts objects of type Dog, 
            // which we can safely insert into an object of type C<Animal>, 
            // since Dog inherits from Animal


            // The conclusion so far is thus: Given our current implementation 
            // of the class C<T>, it makes perfect sense that the two assigment 
            // statements from above are invalid.
            // Methods that return a value of type T induce one kind of “breakage”, 
            // while methods taking a para¬meter of type T induce a different kind.



            // The LAST line of code should be ABOVE this line
        }
    }
}