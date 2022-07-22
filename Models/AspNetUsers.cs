using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace duaaOffer.Models
{
    public partial class AspNetUsers : IdentityUser<int>
    {
        public AspNetUsers()
        {
            Login = new HashSet<Login>();
        }

        public int UserId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Phone { get; set; }
        //public string Email { get; set; }
     //   public string Password { get; set; }
        public int? Roleid { get; set; }
        public string Type { get; set; }

        public virtual Role Role { get; set; }
        public virtual ICollection<Login> Login { get; set; }
    }
}
