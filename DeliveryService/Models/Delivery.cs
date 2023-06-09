﻿using System.ComponentModel.DataAnnotations;

namespace DeliveryService.Models
{
    public class Delivery
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
