using System.ComponentModel.DataAnnotations;

namespace lab3_29102023.Models
{
    public class Dane
    {
        [Required(ErrorMessage = "Prosze podaj Imie")]
        public string imie { get; set; }
        [Required(ErrorMessage = "Prosze podaj Email")]
        [RegularExpression(".+\\@.+\\.[a-z]{2,3}")]
        public string email { get; set; }
        [Required(ErrorMessage = "Prosze podaj Temat")]
        public string temat { get; set; }
        [Required(ErrorMessage = "Prosze podaj Tresc wiadomosci")]
        [MinLength(10), MaxLength(50)]
        public string tresc { get; set; }
    }
}
