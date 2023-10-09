using System.ComponentModel.DataAnnotations;

namespace Craft_beer_backend.ViewModels
{
    public class CardViewModel
    {
        [Required(ErrorMessage = "Поле має бути заповненим")]
        [RegularExpression(@"^\d{16}$", ErrorMessage = "Номер картки повинен містити 16 цифр")]
        public string Number { get; set; }
        [Required(ErrorMessage = "Поле має бути заповненим")]
        [RegularExpression(@"^(0[1-9]|1[0-2])\/\d{2}$", ErrorMessage = "Неправильний формат дати (MM/YY)")]
        public string Date { get; set; }
        [Required(ErrorMessage = "Поле має бути заповненим")]
        [RegularExpression(@"^\d{3}$", ErrorMessage = "CVV повинен містити 3 цифри")]
        public string CVV { get; set; }
    }
}
