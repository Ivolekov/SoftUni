using _03.CompanyHierarchy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CompanyHierarchy.Interfaces
{
    interface IManager
    {
        ISet<Employee> Employees { get; set; }

        void AddEmployees(ISet<Employee> employees);

        string ToString();
    }
}
