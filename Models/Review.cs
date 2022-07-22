using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace duaaOffer.Models
{
    public partial class Review
    {
        public Review()
        {
            Home = new HashSet<Home>();
        }

        public int Id { get; set; }
        public string Image { get; set; }
        public decimal Rate { get; set; }
        public string Note { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Home> Home { get; set; }
    }
}
