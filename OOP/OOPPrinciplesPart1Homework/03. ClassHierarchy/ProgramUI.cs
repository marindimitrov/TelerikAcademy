using System;
using System.Linq;

namespace ClassHierarchy
{
    class ProgramUI
    {
        static void Main()
        {
            Kitten[] kittens = new Kitten[]
            {
                new Kitten(5, "Petia", "Female"),
                new Kitten(4, "Mara", "Female"),
                new Kitten(6, "Tasha", "Female")
            };
            Dog[] dogs = new Dog[]
            {
                new Dog(11, "Sharo", "Male"),
                new Dog(8, "Rex", "Male"),
                new Dog(3, "Bull", "Male"),
            };
            Frog[] frogs = new Frog[]
            {
                new Frog(11, "Kermit", "Male"),
                new Frog(8, "Krakit", "Female"),
                new Frog(3, "Djabit", "Female"),
            };

            Console.WriteLine("Average dogs age");
        }
    }
}