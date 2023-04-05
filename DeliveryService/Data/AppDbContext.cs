using DeliveryService.Models;
using Microsoft.EntityFrameworkCore;

namespace DeliveryService.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<Delivery>Deliveries { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options) 
        {
            
        }
    }
}
