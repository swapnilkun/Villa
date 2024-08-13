using Microsoft.AspNetCore.Mvc;
using AmazonApp.Models;
using AmazonApp.Data;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using AmazonApp.Models.ViewModels;
using Microsoft.AspNetCore.Http;

namespace AmazonApp.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDBContext _dBContext;
        private readonly IWebHostEnvironment _appEnvironment;

        public ProductsController(AppDBContext dbContext, IWebHostEnvironment appEnvironment)
        {
            _dBContext = dbContext;
            _appEnvironment = appEnvironment;
        }

        public IActionResult Index()
        {
            return View(_dBContext.products.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(VMProducts products)
        {
            try
            {
                var fileFolder = _appEnvironment.WebRootPath + "\\ProductImages\\";
                var fileName = DateTime.Now.ToString("ddMMyyhhmmss") + "_" + products.ImageFile.FileName;

                var filePath = fileFolder + fileName;

                using (var stream = System.IO.File.Create(filePath))
                {
                    products.ImageFile.CopyTo(stream);
                }

                Products prod = new Products();

                prod.Name = products.Name;
                prod.Description = products.Description;
                prod.Price = products.Price;
                prod.Image = fileName;

                _dBContext.products.Add(prod);
                _dBContext.SaveChanges();

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public IActionResult Edit(int Id)
        {
            var product = _dBContext.products.FirstOrDefault(x => x.Id == Id);
            if (product == null)
            {
                return NotFound();
            }
            VMProducts vMProduct = new VMProducts
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
            };
            ViewBag.Image=product.Image;
            return View(vMProduct);
        }

        [HttpPost]
        public IActionResult Edit(VMProducts vMProduct)
        {
            try
            {
                var fileFolder = _appEnvironment.WebRootPath + "\\ProductImages\\";
                var fileName = DateTime.Now.ToString("ddMMyyhhmmss") + "_" + vMProduct.ImageFile.FileName;

                var filePath = fileFolder + fileName;

                using (var stream = System.IO.File.Create(filePath))
                {
                    vMProduct.ImageFile.CopyTo(stream);
                }

                Products prod = _dBContext.products.First(p => p.Id == vMProduct.Id);

                prod.Name = vMProduct.Name;
                prod.Description = vMProduct.Description;
                prod.Price = vMProduct.Price;
                prod.Image = fileName;

                _dBContext.products.Update(prod);
                _dBContext.SaveChanges();

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
