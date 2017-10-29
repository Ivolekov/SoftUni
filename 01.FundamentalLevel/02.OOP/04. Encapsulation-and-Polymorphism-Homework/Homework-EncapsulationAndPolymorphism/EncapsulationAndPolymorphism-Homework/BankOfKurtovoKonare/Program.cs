using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankOfKurtovoKonare.Models;

namespace BankOfKurtovoKonare
{
    class Program
    {
        static void Main(string[] args)
        {
            Deposit deposit = new Deposit(Customer.Companie, 22000m, 7.9m);
            deposit.WithdrawMoney(2200m);
            deposit.CalculateInterest(10);
            deposit.DepositMoney(5000m);
            Console.WriteLine("Deposit\n{0}", deposit);

            Loan loanCompanie = new Loan(Customer.Companie, 65000m, 9.6m);
            loanCompanie.DepositMoney(35000m);
            loanCompanie.CalculateInterest(22);
            Console.WriteLine("Loan Companie\n{0}", loanCompanie);

            Loan loanIndividual = new Loan(Customer.Individual, 5500m, 1.6m);
            loanCompanie.DepositMoney(5000m);
            loanCompanie.CalculateInterest(12);
            Console.WriteLine("Loan Individual\n{0}", loanIndividual);

            Mortgage mortgageCompanie = new Mortgage(Customer.Companie, 1200m, 3.2m);
            mortgageCompanie.DepositMoney(452m);
            mortgageCompanie.CalculateInterest(5);
            Console.WriteLine("Mortgage Companie\n{0}", mortgageCompanie);

            Mortgage mortgageIndividual = new Mortgage(Customer.Individual, 5600m, 0.2m);
            mortgageIndividual.DepositMoney(5632m);
            mortgageIndividual.CalculateInterest(10);
            Console.WriteLine("Mortgage Individual\n{0}", mortgageIndividual);
        }
    }
}
