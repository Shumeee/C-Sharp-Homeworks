using Entities; // To use the Class Library we use using [NAME];
using System;

namespace Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee Manager = new Employee("David", "Shumanski", Role.Manager, 10000); // To use enumerations we use [ENUM-NAME].[ENUM-PROPERTY]
            SalesPerson SalesMan = new SalesPerson("Mark", "Roberts", Role.Sales, 8000, 500);
            Employee[] Company =
            {
                new Contractor("Bob", "Bobson", Role.Other, 15000, 40, 20),
                new Contractor("Rob", "Roberts", Role.Other, 12000, 37, 15),
                new Manager("Tom", "Holand", Role.Manager, 20000, 1000),
                new Manager("Chris", "Evans", Role.Manager, 18000, 800),
                new SalesPerson("Calvin", "Sales", Role.Sales, 15000, 300),
            };
            CEO Boss = new CEO("Henry", "Cavil", Role.Other, 15000, Company, 100, 100);
            Boss.PrintInfo();
            Boss.GetSalary();
            Boss.PrintEmployees();
        }
    }
}
