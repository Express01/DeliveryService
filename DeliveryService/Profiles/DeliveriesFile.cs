using AutoMapper;
using DeliveryService.Dtos;
using DeliveryService.Models;

namespace DeliveryService.Profiles
{
    public class DeliveriesFile:Profile
    {
        public DeliveriesFile()
        {
            CreateMap<Delivery, DeliveryReadDto>();
            CreateMap<DeliveryCreateDto, Delivery>();   
        }
    }
}
