using FlipCart.WebAPI.CustomError;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlipCart.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class ErrorController : ControllerBase
    {
        [Route("Error")]
        public IActionResult HandleError()
        {
            var context = HttpContext.Features.Get<IExceptionHandlerFeature>();
            var exception = context?.Error; // The Exception that was caught
            var statusCode = 500; //Default Status Code

            if(exception is SomeCustomException) {
                statusCode = 400; //Bad Request

            }
            else if(exception is UnauthorizedAccessException)
            {
                statusCode = 401; //Unauthorized
            }
            else if(exception is ArgumentException)
            {
                statusCode = 400; ////Bad Request
            }

            //Log the Exception {will discuss logging next}
            //Log.Error(exception,"An error occurred")

            return Problem(detail: exception?.Message, statusCode: statusCode);
        }
    }
}
