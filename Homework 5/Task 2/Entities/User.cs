using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime CreatedOn { get; set; }

        public User(int id, string firstName, string lastName, DateTime createdOn)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            CreatedOn = createdOn;
        }
    }
}
