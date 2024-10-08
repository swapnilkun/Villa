using FlipCart.Areas.Admin.Models;
using FlipCart.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FlipCart.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CatagoriesController : Controller
    {
        
        public async Task<IActionResult> Index()
        {
            IEnumerable<CategoryVM> categories = new List<CategoryVM>();
            ApiResult<List<CategoryVM>> apiResult = new ApiResult<List<CategoryVM>>();
            var result = new Wrapper<ApiResult<IEnumerable<CategoryVM>>>();
            HttpClient _client = new HttpClient();

            HttpResponseMessage response = await _client.GetAsync("https://localhost:7122/api/Catagories");
            response.EnsureSuccessStatusCode(); //Throws an exception if the code is not success

            result = await response.Content.ReadFromJsonAsync<Wrapper<ApiResult<IEnumerable<CategoryVM>>>>();

            categories = (IEnumerable<CategoryVM>)result.Data[0].Resource;
            return View(categories);
        }
    }
}
