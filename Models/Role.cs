using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace duaaOffer.Models
{
    public partial class Role : IdentityRole<int>
    {
        public Role()
        {
            AspNetUsers = new HashSet<AspNetUsers>();
            Login = new HashSet<Login>();
        }

        public int RoleId { get; set; }
        public string Rolename { get; set; }

        public virtual ICollection<AspNetUsers> AspNetUsers { get; set; }
        public virtual ICollection<Login> Login { get; set; }
    }
}
