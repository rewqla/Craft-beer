﻿using System.ComponentModel.DataAnnotations;

namespace Craft_beer_backend.ViewModels
{
    public class DeliveryViewModel
    {
        [Required(ErrorMessage = "Місто має бути не пустим")]
        public string City { get; set; }
        [Required(ErrorMessage = "Адреса має бути не пустим")]
        public string Address { get; set; }
        public string Company { get; set; }
    }
}
