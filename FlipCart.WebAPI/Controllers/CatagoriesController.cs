using FlipCart.WebAPI.Model;
using FlipCart.WebAPI.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FlipCart.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatagoriesController : ControllerBase
    {
        private readonly ICatagoryService _catagoryService;

        public CatagoriesController(ICatagoryService catagoryService)
        {
            _catagoryService = catagoryService;
        }



        // GET: api/<CatagoriesController>
        [HttpGet]
        public IEnumerable<Catagory> Get()
        {
            return _catagoryService.GetAll();
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
                if(!ModelState.IsValid)
                {
                    throw new InvalidOperationException();
                }
                else
                {
                   return _catagoryService.Create(catagory);
                }
            }
            catch (Exception ex)
            {

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
