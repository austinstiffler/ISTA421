using Microsoft.AspNetCore.Mvc;
using Core3Ex07.Models;

namespace Core3Ex07.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            MyFamily austin = new MyFamily()
            {
                Wife = "Katherine",
                Dog = "Remi",
                Mom = "Jessica",
                Dad = "Steven"
            };
            return View(austin);
        }
    }
}
