using AutoMapper;
using DeliveryService.Data;
using DeliveryService.Dtos;
using DeliveryService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DeliveryService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Deliveries : ControllerBase
    {
        private readonly IDeliveryRepository _repository;
        private readonly IMapper _mapper;
        public Deliveries(IDeliveryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult<IEnumerable<DeliveryReadDto>> GetDeliveries()
        {
            var deliveryitem = _repository.GetAllDeliveries();
            return Ok(_mapper.Map<IEnumerable<DeliveryReadDto>>(deliveryitem));
        }
        [HttpGet("{id}", Name = "GetDeliveryById")]
        public ActionResult<DeliveryReadDto> GetDeliveryById(int id)
        {
            var deliveryItem = _repository.GetDeliveryById(id);
            if (deliveryItem != null)
            {
                return Ok(_mapper.Map<DeliveryReadDto>(deliveryItem));
            }
            return NotFound();
        }
        [HttpPost]
        public ActionResult<DeliveryReadDto>CreateDelivery(DeliveryCreateDto delivery) 
        {
            var deliveryModel=_mapper.Map<Delivery>(delivery);
            _repository.CreateDelivery(deliveryModel);
            _repository.SaveChanges();
            var deliveryReadDto=_mapper.Map<DeliveryReadDto>(deliveryModel);
            return CreatedAtRoute(nameof(GetDeliveryById),new {Id=deliveryReadDto.Id},deliveryReadDto);
        }

    }
}
