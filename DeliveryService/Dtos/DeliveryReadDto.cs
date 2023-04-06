using System.ComponentModel.DataAnnotations;

namespace DeliveryService.Dtos
{
    public class DeliveryReadDto
    {
       
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string Description { get; set; }
    }
}
