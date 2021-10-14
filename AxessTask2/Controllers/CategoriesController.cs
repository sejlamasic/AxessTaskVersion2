using AxessTask2.Models;
using AxessTask2.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AxessTask2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IService<Category, int> _categoryService;

        public CategoriesController(IService<Category, int> categoryService)
        {
            _categoryService = categoryService;
        }
        
        [HttpGet]
        public IEnumerable<Category> GetAllCategories()
        {
            var categories = _categoryService.GetAll();

            return categories;
        }

        [HttpGet("{id}")]
        public Category GetById(int id)
        {
            return _categoryService.GetById(id);

        }
        [HttpPut("{id}")]
        public Category Update(int id, Category category)
        {
            return _categoryService.Update(id, category);
        }
        [HttpPost]
        public Category Insert(Category category)
        {
            return  _categoryService.Insert(category);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
             _categoryService.Delete(id);
        }

    }

}