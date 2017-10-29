using BankOfKurtovoKonare.Models;

namespace BankOfKurtovoKonare.Interfaces
{
    internal interface IAccount
    {
        Customer Customer { get; set; }
        decimal Balance { get; set; }
        decimal InterestRate { get; set; }
        void DepositMoney(decimal money);
        decimal CalculateInterest(int mounth);
    }
}