using Microsoft.AspNetCore.Mvc;

namespace AmazonApp.Controllers
{
    public class OrdersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Process()
        {
            return View();
        }

        public IActionResult Deliver()
        {
            return View();
        }

        public IActionResult Complete()
        {
            return View();
        }
    }
}
