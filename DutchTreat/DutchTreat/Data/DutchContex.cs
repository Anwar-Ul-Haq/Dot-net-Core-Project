using DutchTreat.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace DutchTreat.Data
{
    public class DutchContex :DbContext
    {

        public DutchContex(DbContextOptions<DutchContex> options) :base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
