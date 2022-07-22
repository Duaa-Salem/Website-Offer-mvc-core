using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace duaaOffer.Models
{
    public class IdentityAppContext: IdentityDbContext<AspNetUsers,Role,int>
    {
        public IdentityAppContext(DbContextOptions<IdentityAppContext> options) : base(options)
        {

        }
    }
}
