using System;
using System.Linq;
using System.Text;

namespace ClassStudent
{
    // 4. Create a class Person with two fields – name and age. Age can be left unspecified 
    // (may contain null value. Override ToString() to display the information of a person 
    // and if age is not specified – to say so. Write a program to test this functionality.

    class Person
    {
        private string name;
        private int? age;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get
            {
                if (age == null)
                {
                    return 0;
                }
                else
                {
                    return Age;
                }
            }
            set { this.age = value; }
        }

        public override string ToString()
        {
            if (this.age == null)
            {
                throw new Exception("Age is not specified");
            }
            else
            {
                StringBuilder info = new StringBuilder();
                info.Append("Age: " + this.age + "\n");
                info.Append("Name: " + this.name + "\n");
                return info.ToString();
            }
        }
    }
}