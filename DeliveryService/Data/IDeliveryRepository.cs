using DeliveryService.Models;

namespace DeliveryService.Data
{
    public interface IDeliveryRepository
    {
        bool SaveChanges();
        IEnumerable<Delivery> GetAllDeliveries();
        Delivery GetDeliveryById(int id);
        void CreateDelivery(Delivery delivery);
    }
}
