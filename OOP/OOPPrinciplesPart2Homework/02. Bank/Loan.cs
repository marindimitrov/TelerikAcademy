using System;
using System.Linq;

namespace Bank
{
    public class Loan : Account, IDepositable
    {
        public void DepositMoney()
        {
        }

        public override int CalculateInterest()
        {
            int interest = this.Period * this.InterestRate;
            return interest;
        }
    }
}