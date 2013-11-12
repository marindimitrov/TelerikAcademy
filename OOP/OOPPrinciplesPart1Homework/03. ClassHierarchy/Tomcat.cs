using System;
using System.Linq;

namespace ClassHierarchy
{
    class Tomcat : Cat
    {
        private string sex;

        public Tomcat(int age, string name, string sex)
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
                if (value.ToLower() != "male")
                {
                    throw new ArgumentException("Tomcats can be only \"Male\"");
                }
            }
        }
    }
}