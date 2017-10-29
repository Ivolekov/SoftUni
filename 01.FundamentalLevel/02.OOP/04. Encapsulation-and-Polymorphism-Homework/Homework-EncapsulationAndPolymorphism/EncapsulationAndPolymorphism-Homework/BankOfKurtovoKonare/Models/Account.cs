using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using BankOfKurtovoKonare.Interfaces;

namespace BankOfKurtovoKonare.Models
{
    abstract class Account : IAccount
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer Customer { get; set; }

        public decimal Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("interestRate", "interest rate can not be negative!");
                }
                this.interestRate = value;
            }
        }

        public void DepositMoney(decimal money)
        {
            this.balance += money;
        }

        public abstract decimal CalculateInterest(int months);

        public override string ToString()
        {
            return string.Format("Account: {0}, Balance: {1:F2}, Interest Rate: {2}", this.GetType().Name, this.balance, this.interestRate);
        }
    }
}
