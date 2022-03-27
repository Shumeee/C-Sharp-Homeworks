using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class SalesPerson : Employee
    {
        private double SuccessSaleRevenue;
        public SalesPerson(string FirstName, string LastName, Role Role, double Salary, double SuccessSaleRevenue) : base(FirstName, LastName, Role, Salary)
        {
            Salary = 500;
        }
        public override double GetSalary()
        {
            return Salary + SuccessSaleRevenue;
        }
        public double AddSuccessRevenue(double number)
        {
            SuccessSaleRevenue = number;
            if (SuccessSaleRevenue <= 2000) return Salary + 500;
            if (SuccessSaleRevenue > 2000 && SuccessSaleRevenue <= 5000) return Salary + 1000;
            if (SuccessSaleRevenue > 5000) return Salary + 1500;
            return SuccessSaleRevenue;
        }
    }
}
