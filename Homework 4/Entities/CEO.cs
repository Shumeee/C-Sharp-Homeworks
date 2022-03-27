using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class CEO : Employee
    {
        //    public Employee[] Employees = {
        //    new Employee("David", "Shumanski", Role.Manager, 10000),
        //    new Employee("Chris", "Evans", Role.Other, 8000),
        //    new Employee("Ryan", "Reynolds", Role.Sales, 6000)
        //};
        public Employee[] Employees { get; set; }
        public int Shares { get; set; }
        private double SharesPrice { get; set; }
        public CEO(string FirstName, string LastName, Role Role, double Salary, Employee[] employees, int shares, double sharesPrice) : base(FirstName, LastName, Role, Salary)
        {
            Employees = employees;
            Shares = shares;
            SharesPrice = sharesPrice;
        }
        public void AddSharesPrice(double number)
        {
            SharesPrice = number;
        }
        public void PrintEmployees()
        {
            Console.WriteLine("Employees:");
            foreach (Employee employee in Employees) Console.WriteLine($"{employee.FirstName} {employee.LastName}");
        }
        public override double GetSalary()
        {
            Console.WriteLine($"CEO Salary: {Salary + Shares * SharesPrice}");
            return Salary += Shares * SharesPrice;
        }
    }
}
