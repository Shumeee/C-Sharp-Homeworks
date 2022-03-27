using System;

namespace Entities
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; } // To use Enumerations in classes we use (public) [ENUM-NAME] [VAR]
        protected double Salary { get; set; } // This will be visible for this class and EVERY inheritance ( protected )

        public Employee(string firstName, string lastName, Role role, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            Salary = salary;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"First Name: {FirstName}\nLast Name: {LastName}\nSalary: {Salary}");
        }
        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}
