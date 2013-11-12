using System;
using System.Linq;

namespace ClassHierarchy
{
    class Dog : Animal, ISound
    {
        public Dog(int age, string name, string sex)
            : base(age, name, sex)
        {

        }
        public string ProduceSound()
        {
            return "Bauuu";
        }
    }
}