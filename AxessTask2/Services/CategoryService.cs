using AxessTask2.Models;
using System.Collections.Generic;
using System.Linq;

namespace AxessTask2.Services
{
    public class CategoryService : IService<Category, int>
    {
        private readonly NORTHWNDContext _context;

        public CategoryService(NORTHWNDContext context)
        {
            _context = context;
        }


        public IEnumerable<Category> GetAll()
        {
            return _context.Categories.ToList();
        }

        public Category GetById(int id)
        {
            return _context.Categories.FirstOrDefault(x => x.CategoryId == id);
        }

        public Category Insert(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return category;
        }
        public Category  Update(int id, Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
            return category;
        }

        public void Delete(int id)
        {
            var category = _context.Categories.FirstOrDefault(x => x.CategoryId == id);

            if (category != null)
            {
                _context.Remove(category);
                _context.SaveChanges();
            }
        }

    }
}
