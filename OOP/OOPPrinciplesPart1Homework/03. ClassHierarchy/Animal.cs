using System;
using System.Linq;

namespace ClassHierarchy
{
    class Animal
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }

        public Animal(int age, string name, string sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }
    }
}