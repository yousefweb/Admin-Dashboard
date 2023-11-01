using JEIFinalPro.Models.SharedProp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JEIFinalPro.Models
{
    public class User : CommonProp
    {
        public int UserId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public Genders Gender { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
    public enum Genders
    { 
    Male,Female
    }
}
