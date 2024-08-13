using Microsoft.AspNetCore.Mvc;

namespace Villa.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
