using System;
using System.Linq;

namespace Bank
{
    public class Deposit : Account, IWithdrawable, IDepositable
    {
        public void DepositMoney()
        {
        }
        public void WithdrawMoney()
        { 
        }
        public override int CalculateInterest()
        {
            int interest = this.Period * this.InterestRate;
            return interest;
        }
    }
}