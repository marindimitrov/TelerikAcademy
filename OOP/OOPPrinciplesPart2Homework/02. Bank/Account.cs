using System;
using System.Linq;

namespace Bank
{
    public abstract class Account
    {
        public Customer Customer { get; set; }
        public decimal Balance { get; set; }
        public int InterestRate { get; set; }
        public int Period { get; set; }

        public abstract int CalculateInterest();

    }
}