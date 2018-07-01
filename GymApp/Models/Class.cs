using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymApp.Models
{
    public class User
    {
        public int id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public float Weight { get; set; }
        public float Height { get; set; }
    }

    public class NewUser: User
    {
        public string ConfirmPassword { get; set; }
    }
}
