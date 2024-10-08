using FlipCart.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FlipCart.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class UsersController : Controller
    {
        public async Task<IActionResult> Index()
        {
            RUserApiRes apiRes = new RUserApiRes();
            HttpClient _client = new HttpClient();

            HttpResponseMessage response = await _client.GetAsync("https://randomuser.me/api/");
            response.EnsureSuccessStatusCode(); //Throws an exception if the code is not success

            apiRes = await response.Content.ReadFromJsonAsync<RUserApiRes>();
            return View(apiRes);
        }
    }
}
