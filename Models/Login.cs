using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace duaaOffer.Models
{
    public partial class Login
    {
        public Login()
        {
            Offer = new HashSet<Offer>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int? Roleid { get; set; }
        public int? Userid { get; set; }

        public virtual Role Role { get; set; }
        public virtual AspNetUsers User { get; set; }
        public virtual ICollection<Offer> Offer { get; set; }
    }
}
