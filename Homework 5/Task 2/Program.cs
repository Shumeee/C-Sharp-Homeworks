using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, User> Users = new Dictionary<int, User> ();
            Users.Add(1, new User(1, "David", "Shumanski", DateTime.Now.AddDays(-15)));
            Users.Add(2, new User(2, "Mitre", "Mitreski", DateTime.Now.AddMonths(-10)));
            Users.Add(3, new User(3, "Trajko", "Trajkovski", DateTime.Now.AddYears(-2)));
            bool found = false;
            Console.WriteLine("Would you like to (R)egister or (S)earch ?");
            int lastUser = Users.Values.Last().Id;
            string input = Console.ReadLine();
            if(CheckInput(input.ToLower()) == "r")
            {
                AddUser(Users, lastUser);
            }
            else if(CheckInput(input.ToLower()) == "s")
            {
                Console.WriteLine("Search for user by\n1. ID \n2. First and Last Name"); 
                string searchUser = Console.ReadLine();
                if(CheckSearch(searchUser) == 1)
                {
                    Console.WriteLine("Enter the ID:");
                    bool checkId = int.TryParse(Console.ReadLine(), out int id);
                    if (checkId) FindUserById(Users, id, found);
                    else Console.Write("Input must be a number!");
                }
                else if(CheckSearch(searchUser) == 2)
                {
                    Console.WriteLine("First name:");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Last name:");
                    string lastName = Console.ReadLine();
                    FindUserByFullName(Users, firstName.ToLower(), lastName.ToLower(), found);
                }
            }
        }
        // Checks if the user entered (R)egister or (S)earch
        static string CheckInput(string input)
        {
            
            if (input == "r") return "r";
            else if (input == "s") return "s";
            else
            {
                Console.WriteLine("Invalid Input!");
                return "x";
            }
        }
        // Checks if the user is searching by ID or Full name
        static int CheckSearch(string input)
        {
            if(input == "1")
            {
                return 1;
            }
            else if (input == "2")
            {
                return 2;
            }else
            {
                Console.WriteLine("Invalid input! Please choose 1 or 2");
                return 0;
            }
        }
        // Checks if the first or last name are null
        static bool CheckCredentials(string input)
        {
            if (String.IsNullOrEmpty(input))
            {
                Console.WriteLine("Invalid input! Field cannot be Empty!");
                return false;
            }
            else return true;
        }
        // Finds the user by ID
        static void FindUserById(Dictionary<int, User> Users, int id, bool found)
        {
            foreach (var user in Users)
            {
                if (user.Key == id)
                {
                    Console.WriteLine($"The user {user.Value.FirstName} {user.Value.LastName} is in our database!");
                    found = true;
                }
            }
            if (!found) Console.WriteLine("No users were found with that ID");
        }
        // Finds the user by First and Lsat Name
        static void FindUserByFullName(Dictionary<int, User> Users, string firstName, string lastName, bool found)
        {
            foreach (var user in Users)
            {
                if (user.Value.FirstName.ToLower() == firstName && user.Value.LastName.ToLower() == lastName)
                {
                    Console.WriteLine($"The user {user.Value.FirstName} {user.Value.LastName} is in our database!");
                    found = true;
                }
            }
            if (!found) Console.WriteLine("No users were found with those credentials");
        }
        // Adds the user
        static void AddUser(Dictionary<int, User> Users, int lastUser)
        {
            Console.WriteLine("Enter First Name: ");
            string firstName = Console.ReadLine();
            if (!CheckCredentials(firstName)) return;
            Console.WriteLine("Enter Last Name: ");
            string lastName = Console.ReadLine();
            if (!CheckCredentials(lastName)) return;
            Users.Add(lastUser + 1, new User(lastUser + 1, firstName, lastName, DateTime.Now));
            Console.WriteLine("Successfuly added user!");
        }
    }
}
