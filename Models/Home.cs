using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace duaaOffer.Models
{
    public partial class Home
    {
        public int Homeid { get; set; }
        public int? Aboutid { get; set; }
        public int? Contactid { get; set; }
       

        public virtual About About { get; set; }
        public virtual Contact Contact { get; set; }
        
    }
}
