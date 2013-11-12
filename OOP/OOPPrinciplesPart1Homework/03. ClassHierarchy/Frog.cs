using System;
using System.Linq;

namespace ClassHierarchy
{
    class Frog : Animal, ISound 
    {
        public Frog(int age, string name, string sex)
            : base(age, name, sex)
        {

        }
        public string ProduceSound()
        {
            return "Kwak kwak";
        }
    }
}