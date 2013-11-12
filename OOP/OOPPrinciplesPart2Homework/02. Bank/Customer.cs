using System;
using System.Linq;

namespace Bank
{
    public class Customer
    {
        public string Type { get; set; }

        public Customer()
        {

        }
        public Customer(string type)
        {
            this.Type = type;
        }
    }
}