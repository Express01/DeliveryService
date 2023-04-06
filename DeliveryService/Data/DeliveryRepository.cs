using DeliveryService.Models;

namespace DeliveryService.Data
{
    public class DeliveryRepository : IDeliveryRepository
    {
       private readonly AppDbContext _context;
        public DeliveryRepository(AppDbContext context)
        {
            _context = context;
        }
        public void CreateDelivery(Delivery delivery)
        {
            if (delivery==null)
            {
                throw new ArgumentNullException(nameof(delivery));
            }
            _context.Deliveries.Add(delivery); 
        }

        public IEnumerable<Delivery> GetAllDeliveries()
        {
           return _context.Deliveries.ToList();
        }

        public Delivery GetDeliveryById(int id)
        {
            return _context.Deliveries.FirstOrDefault(p=>p.Id==id);  
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
