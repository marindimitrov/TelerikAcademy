using System;
using System.Linq;

namespace Bank
{
    public class Individual : Customer
    {
        public string Name { get; set; }

        public Individual()
        {

        }
        public Individual(string name)
        {
            this.Name = name;
        }
    }
}