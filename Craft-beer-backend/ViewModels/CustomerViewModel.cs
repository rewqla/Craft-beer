using System.ComponentModel.DataAnnotations;

namespace Craft_beer_backend.ViewModels
{
    public class CustomerViewModel
    {
        [Required(ErrorMessage = "Ім'я має бути не пустим")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Прізвище має бути не пустим")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Телефон має бути не пустим")]
        [RegularExpression(@"^([+]?(38))?(0[0-9]{9})$", ErrorMessage = "Не правильний формат телефону")]
        public string Phone { get; set; }
    }
}
