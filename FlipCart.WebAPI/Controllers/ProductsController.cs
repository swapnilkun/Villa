using FlipCart.WebAPI.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FlipCart.WebAPI.Controllers
{
    [Route("api/v{version:apiversion}/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class ProductsController : ControllerBase
    {
        List<Products> products = new List<Products>();

        public ProductsController()
        {
            for (int i = 1; i < 6; i++)
            {
                Products p = new Products
                {
                    Id= i,
                    Name= $"Product{i}",
                    Description="Test Description",
                    Price=500+i
                };

                products.Add(p);
            }
        }

        // GET: api/<ProductsController>
        [HttpGet]
        public IEnumerable<Products> Get()
        {
            return products;
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

    [Route("api/v{version:apiversion}/[controller]")]
    [ApiController]
    [ApiVersion("2.0")]
    public class ProductsV2Controller : ControllerBase
    {
        List<Products> products = new List<Products>();
        public ProductsV2Controller()
        {
            for (int i = 1; i < 6; i++)
            {
                Products p = new Products
                {
                    Id = i,
                    Name = $"Product{i}",
                    Description = "Test Description",
                    Price = 500 + i,
                    Category=$"Category{i}"
                };

                products.Add(p);
            }
        }

        [HttpGet]
        public IEnumerable<Products> Get()
        {
            return products;
        }

        [HttpPost]
        public Products Post(Products product)
        {
            products.Add(product);
            return product;
        }
    }
}
