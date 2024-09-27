using FlipCart.WebAPI.Model;
using FlipCart.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FlipCart.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class CatagoriesController : ControllerBase
    {
        private readonly ICatagoryService _catagoryService;
        private readonly ILogger<CatagoriesController> _logger;

        public CatagoriesController(ICatagoryService catagoryService, ILogger<CatagoriesController> logger)
        {
            _catagoryService = catagoryService;
            _logger = logger;
        }



        //// GET: api/<CatagoriesController>
        // [HttpGet]
        // [Route("/GetAll}")]
        // public IEnumerable<Catagory> GetAll()
        // {
        //     return _catagoryService.GetAll();
        // }

        [HttpGet]
        public Wrapper<ApiResult<IEnumerable<Catagory>>> Get()
        {
            //_logger.LogInformation("Fachine All Catagories");
            Log.Information("Fachine All Catagories");
            var result = new Wrapper<ApiResult<IEnumerable<Catagory>>>();
            ApiResult<IEnumerable<Catagory>> apiResult = new ApiResult<IEnumerable<Catagory>>();
            try
            {
                //  _logger.LogInformation("Inside Try");
                Log.Information("Inside Try");
                apiResult.Success = true;
                apiResult.Message = " The Catagory list Generated Successfully";
                apiResult.Resource = _catagoryService.GetAll();
                // _logger.LogInformation("Retrived All Catagories");
                Log.Information("Retrived All Catagories");
            }
            catch (Exception ex)
            {
                apiResult.Success = false;
                apiResult.Message = ex.Message;
                // _logger.LogError(ex, "An error occurred while faching Catagories");
                Log.Error(ex, "An error occurred while faching Catagories");
            }
            result.Data.Add(apiResult);
            return result;
        }

        // GET api/<CatagoriesController>/5
        [HttpGet("{id}")]
        public Catagory Get(int id)
        {
            return _catagoryService.GetById(id);
        }

        // POST api/<CatagoriesController>
        [HttpPost]
        public int Post([FromBody] Catagory catagory)
        {
            try
            {
                Log.Information($"Post Catagory {catagory}");
                if (!ModelState.IsValid)
                {
                    Log.Warning("Validation Error");
                    throw new InvalidOperationException();
                }
                else
                {
                    Log.Information($"Catagory Created Successfully {DateTime.Now.ToString("dd-MM-yyyy")}");
                    return _catagoryService.Create(catagory);

                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "An error occurred while Creating Catagories");
                throw;
            }
        }

        // PUT api/<CatagoriesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CatagoriesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
