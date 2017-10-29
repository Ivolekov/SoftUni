using _03.CompanyHierarchy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CompanyHierarchy.Interfaces
{
    interface ISalesEmployee
    {
        ISet<Sale> Sales { get; set; }

        void AddSales(ISet<Sale> sales);

        string ToString();
    }
}
