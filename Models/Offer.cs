using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace duaaOffer.Models
{
    public partial class Offer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public virtual IFormFile ImageFile { get; set; }
        public string City { get; set; }
        public string Communication { get; set; }
        public string Color { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime Enddate { get; set; }
        public string Text { get; set; }
        public decimal Regular { get; set; }
        public decimal Sale { get; set; }
        public string Company { get; set; }
        public int? CategoryId { get; set; }
        public int? Userid { get; set; }

        public virtual Category Category { get; set; }
        public virtual Login User { get; set; }
    }
}
