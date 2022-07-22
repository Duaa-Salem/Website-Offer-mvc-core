using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace duaaOffer.Models
{
    public partial class Category
    {
        public Category()
        {
            Offer = new HashSet<Offer>();
        }

        public int Id { get; set; }
        public string Categoryname { get; set; }

        public virtual ICollection<Offer> Offer { get; set; }
    }
}
