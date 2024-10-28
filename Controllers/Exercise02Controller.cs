using Microsoft.AspNetCore.Mvc;
using StartUp_CORE.Models;

namespace StartUp_CORE.Controllers
{
    public class Exercise02Controller : Controller
    {
        public IActionResult Index()
        {
            // Opretter to Person-objekter
            Person person1 = new Person("Mikkel", "Bang", "Gangstervej 12", "8210", "Aarhus");
            Person person2 = new Person("Benjamin", "Gregersen", "Gangstervej 34", "8210", "Aarhus");

            person1.AddPhoneNumber("20323232");
            person2.AddPhoneNumber( "3332323232");

            // Sender objekterne til viewet via ViewData
            ViewData["Person1"] = person1;
            ViewData["Person2"] = person2;

            return View("PersonView");
        }
    }
}
