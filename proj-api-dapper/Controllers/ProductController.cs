using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using proj_api_dapper.Models;
using proj_api_dapper.Services;

namespace proj_api_dapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private ProductService _productService;
        public ProductController(ProductService productService)
        {
            _productService = new ProductService();
        }

        [HttpGet]
        public ActionResult<List<Product>> Get() => _productService.ToList();

        [HttpGet]
        public ActionResult<Product> ConsultId(int id) => _productService.ConsultId(id);

        [HttpPost]
        public int Insert(Product product) => _productService.Insert(product);

        [HttpPut]
        public bool Update(Product product) => _productService.Update(product);

        [HttpDelete]
        public bool Delete(int id) => _productService.Delete(id);
    }
}
