using System;
using System.Linq;

namespace ClassHierarchy
{
    class Cat : Animal, ISound
    {
        public Cat(int age, string name, string sex)
            : base(age, name, sex)
        {

        }
        public string ProduceSound()
        {
            return "Myauuu";
        }
    }
}