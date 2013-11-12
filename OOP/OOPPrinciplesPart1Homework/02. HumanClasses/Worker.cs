using System;
using System.Linq;

namespace HumanClasses
{
    class Worker : Human
    {
        private decimal earnedMoneyPerHour;
        public decimal EarnedMoneyPerHour
        {
            get; //{ return this.earnedMoneyPerHour; }
            set;
        }
        public decimal WeekSalary { get; set; }
        public decimal WorkHoursPerDay { get; set; }

        public decimal MoneyPerHour(Worker worker)
        {
            earnedMoneyPerHour = (worker.WeekSalary / 5) / worker.WorkHoursPerDay;
            return earnedMoneyPerHour;
        }
        public Worker()
        {

        }
        public Worker(string firstName, string lastName, int earnedMoneyPerHour)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EarnedMoneyPerHour = earnedMoneyPerHour;
        }
    }
}