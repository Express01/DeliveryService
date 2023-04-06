using DeliveryService.Models;

namespace DeliveryService.Data
{
    public class PreDb
    {
        public static void PrePopulation(IApplicationBuilder app)
        {
            using(var serviceScope=app.ApplicationServices.CreateScope()) 
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
            }
        }
        private static void SeedData(AppDbContext context) 
        {
            if (!context.Deliveries.Any()) 
            {
                context.Deliveries.AddRange(
                    new Delivery() { Name = "Wildberries", Description = "Маркетплейс" },
                    new Delivery() { Name = "Ozon", Description = "Маркетплейс" },
                    new Delivery() { Name = "DODO PIZZA", Description = "Ресторан быстрого питания" });
                context.SaveChanges();
            };
        }
    }
}
