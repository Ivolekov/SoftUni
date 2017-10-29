using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CompanyHierarchy.Models
{
    class RegularEmployee : Employee
    {
        public RegularEmployee(string id, string firstName, string lastName, Department department, decimal salary)
            : base(id, firstName, lastName, department, salary)
        {
        }
    }
}
