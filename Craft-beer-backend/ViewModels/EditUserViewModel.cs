using Craft_beer_backend.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Craft_beer_backend.ViewModels
{
    public class EditUserViewModel
    {
        public long Id { get; set; }
        [Required(ErrorMessage = "Необхідний нікнейм")]
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string PhoneNumber { get; set; }
        public string LastName { get; set; }
        [Required(ErrorMessage = "Необхідно бути старше 18 років")]
        public string Birthday { get; set; }
        public List<AllRoleViewModel> AllRoles { get; set; }
    }
}
