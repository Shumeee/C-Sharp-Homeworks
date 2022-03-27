using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Manager : Employee
    {
        private double Bonus { get; set; }
        public Manager(string FirstName, string LastName, Role Role, double Salary, double Bonus) : base(FirstName, LastName, Role, Salary)
        {

        }
        public double AddBonus()
        {
            return Bonus += Bonus;
        }
        public override double GetSalary()
        {
            return Salary + AddBonus();
        }
    }
}
