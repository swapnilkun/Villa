using Microsoft.AspNetCore.Mvc;

namespace Villa.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult UploadImage(string filePath)
        {
            return View();
        }
    }
}
