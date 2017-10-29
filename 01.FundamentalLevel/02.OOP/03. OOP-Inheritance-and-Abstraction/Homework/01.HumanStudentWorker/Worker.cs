using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HumanStudentWorker
{
    class Worker:Human
    {
        private double weekSalary;
        private double workHoursPerDay;
        public Worker(string firstName,string lastName,double weekSalary,double workHoursPerDay):base(firstName,lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double WeekSalary
        {
            get { return this.weekSalary; }
            set { this.weekSalary = value; }
        }

        public double WorkHoursPerDay 
        {
            get { return this.workHoursPerDay; }
            set { this.workHoursPerDay = value; }
        }
        internal double MoneyPerHours()
        {
            double moneyPerHours = this.WeekSalary / (this.WorkHoursPerDay * 5);
            return moneyPerHours;
        }
        public override string ToString()
        {
            return string.Format("0, week salary:{1}, work hour per day:{2}, money per hour:{3}", base.ToString(), WeekSalary, WorkHoursPerDay, this.MoneyPerHours());
        }
    }
}
