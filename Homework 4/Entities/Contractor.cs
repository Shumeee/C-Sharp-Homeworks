using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }

        Manager Responsible;
        public Contractor(string FirstName, string LastName, Role Role, double Salary, double WorkHours, int PayPerHour) : base(FirstName, LastName, Role, Salary)
        {

        }
        public override double GetSalary()
        {
            return Salary = WorkHours * PayPerHour;
        }
        public Manager CurrentPosition()
        {
            return Responsible;
        }
    }
}
