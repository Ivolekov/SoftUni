using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfKurtovoKonare.Models
{
    class Mortgage : Account
    {
        public Mortgage(Customer customer, decimal balance, decimal interestRate) :
            base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            decimal interest = this.InterestRate = this.Balance * (1 + this.InterestRate * months);
            if (months <= 12 && this.Customer == Customer.Companie)
            {
                return this.InterestRate = interest / 2;
            }
            else if (months <= 6 && this.Customer == Customer.Individual)
            {
                return 0;
            }
            return interest;
        }
    }
}
