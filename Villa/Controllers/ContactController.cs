using Microsoft.AspNetCore.Mvc;

namespace Villa.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
