using System;
using System.Linq;

namespace ClassHierarchy
{
    class Kitten : Cat
    {
        private string sex;

        public Kitten(int age, string name, string sex)
            : base(age, name, sex)
        {

        }

        public string Sex
        {
            get
            {
                return this.sex;
            }
            set
            {
                this.sex = value;
                if (value.ToLower() != "female")
                {
                    throw new ArgumentException("Kittens can be only \"Female\"");
                }
            }
        }
    }
}