using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace duaaOffer.Models
{
    public partial class About
    {
        public About()
        {
            Home = new HashSet<Home>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        [NotMapped]
        public virtual IFormFile ImageFile { get; set; }
        public string Image { get; set; }
        public string Text { get; set; }

        public virtual ICollection<Home> Home { get; set; }
    }
}
