using System;
using System.Linq;

namespace Bank
{
    public class Company : Customer
    {
        public string Name { get; set; }

        public Company()
        {

        }
        public Company(string name)
        {
            this.Name = name;
        }
    }
}