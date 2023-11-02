using System.ComponentModel.DataAnnotations;

namespace lab3_29102023.Models
{
    public class Dane
    {
        [Required(ErrorMessage = "Proszę podać imię")]
        [MinLength(2, ErrorMessage = "Imię powinno mieć co najmniej 2 znaki")]
        public string Imie { get; set; }

        [Required(ErrorMessage = "Proszę podać nazwisko")]
        [MinLength(2, ErrorMessage = "Nazwisko powinno mieć co najmniej 2 znaki")]
        public string Nazwisko { get; set; }

        [Required(ErrorMessage = "Proszę podać adres e-mail")]
        [EmailAddress(ErrorMessage = "Nieprawidłowy format adresu e-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Proszę podać hasło")]
        [DataType(DataType.Password)]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d).{8,}$", ErrorMessage = "Hasło musi zawierać co najmniej 8 znaków, w tym jedną cyfrę, jedną dużą i małą literę")]
        public string Haslo { get; set; }

        [Required(ErrorMessage = "Proszę potwierdzić hasło")]
        [DataType(DataType.Password)]
        [Compare("Haslo", ErrorMessage = "Hasła nie są identyczne")]
        public string PotwierdzenieHasla { get; set; }

        [Phone(ErrorMessage = "Nieprawidłowy numer telefonu")]
        public string Telefon { get; set; }

        [Range(10, 80, ErrorMessage = "Wiek powinien być pomiędzy 10 a 80 lat")]
        public int Wiek { get; set; }

        [Required(ErrorMessage = "Proszę wybrać miasto")]
        public Miasta Miasto { get; set; }

        public enum Miasta
        {
            Warszawa,
            Krakow,
            Wroclaw,
            Poznan,
            Gdansk
        }
    }
}
