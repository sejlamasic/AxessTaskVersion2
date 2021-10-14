using AxessTask2.Models;
using AxessTask2.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AxessTask2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IService<Product, int> _productService;

        public ProductsController(IService<Product, int> productService)
        {

            _productService = productService;
        }

        [HttpGet]
        public IEnumerable<Product> GetAll()
        {
            var products = _productService.GetAll();

            return products;
        }

        [HttpGet("{id}")]
        public Product GetById(int id)
        {
            return _productService.GetById(id);

        }

        [HttpPost]
        public Product Insert(Product product)
        {
            return _productService.Insert(product);
        }
        [HttpPut("{id}")]
        public Product Update(int id, Product product)
        {
            return _productService.Update(id, product);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
             _productService.Delete(id);
        }

    }
}
