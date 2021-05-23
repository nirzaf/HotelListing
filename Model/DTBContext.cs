using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Model
{
    public class DTBContext : DbContext
    {
        public DTBContext(DbContextOptions options) : base(options)
        { 
        
        }

        public DbSet<Country> Countries { get; set; }
    }
}
