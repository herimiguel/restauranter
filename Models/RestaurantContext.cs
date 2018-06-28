using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
 
namespace restauranter.Models
{
    public class RestaurantContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public RestaurantContext(DbContextOptions<RestaurantContext>options) : base(options) { }
   
        public DbSet<Review> reviews { get; set; }

    }
}
