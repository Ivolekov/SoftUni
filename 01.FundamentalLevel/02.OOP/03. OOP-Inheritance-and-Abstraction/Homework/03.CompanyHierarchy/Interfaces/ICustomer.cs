using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CompanyHierarchy.Interfaces
{
    interface ICustomer
    {
        decimal PurchasesAmmount { get; set; }

        void AddPurchasePrice(decimal purchasePrice);

        string ToString();
    }
}
