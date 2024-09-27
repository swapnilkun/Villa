using FlipCart.Areas.Admin.Models;
using FlipCart.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FlipCart.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CatagoriesController : Controller
    {
        
        public async Task<IActionResult> IndexAsync()
        {
            IEnumerable<CategoryVM> categories = new List<CategoryVM>();
            HttpClient _client = new HttpClient();

            HttpResponseMessage response = await _client.GetAsync("https://localhost:7122/api/Catagories");
            response.EnsureSuccessStatusCode(); //Throws an exception if the code is not success

            categories = await response.Content.ReadFromJsonAsync<IEnumerable<CategoryVM>>();

            return View(categories);
        }
    }
}
