using Microsoft.AspNetCore.Mvc;

namespace Villa.Controllers
{
    public class HotelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
