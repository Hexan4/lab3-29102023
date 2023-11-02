using lab3_29102023.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab3_29102023.Controllers
{
    public class DaneController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form(Dane dane)
        {
            if (ModelState.IsValid)
            {
                ViewBag.SuccessMessage = "Rejestracja zakończona pomyślnie";
                return View("Wynik", dane);
            }
            else
            {
                // Jeśli chcesz, możesz również przekazać komunikat o błędzie
                ViewBag.ErrorMessage = "Wystąpiły błędy, proszę poprawić formularz.";
                return View(dane); // Zwróć ten sam widok z błędami walidacji
            }
        }

        public IActionResult Wynik(Dane dane)
        {
            return View(dane);
        }
    }
}
