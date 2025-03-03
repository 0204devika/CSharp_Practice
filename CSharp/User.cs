using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_C__
{
    class User
    {
        public string? UserName { get; set; }
        public string? Role { get; set; }
        public User(string? userName, string? role)
        {
            UserName = userName;
            Role = role;
        }
        public virtual void AccessControl()
        {

        }
    }
    class Admin : User
    {
        public Admin(string username) : base(username, "Admin") { }

        public override void AccessControl()
        {
            Console.WriteLine($"Admin {UserName} has access to all features.");
        }
    }
    class Customer : User
    {
        public Customer(string username) : base(username, "Customer") { }

        public override void AccessControl()
        {
            Console.WriteLine($"Customer {UserName} has limited access.");
        }
    }
}
