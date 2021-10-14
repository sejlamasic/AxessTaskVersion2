using AxessTask2.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AxessTask2.Services
{
    public class ProductService:IService<Product,int>
    {
        private readonly NORTHWNDContext _context;

        public ProductService(NORTHWNDContext context)
        {
            _context = context;
        }
        public IEnumerable<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public Product GetById(int id)
        {
            return _context.Products.FirstOrDefault(x => x.ProductId == id);
        }

        public Product Insert(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }
        public Product Update(int id, Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
            return product;
        }
        public void Delete(int id)
        {
            var product = _context.Products.FirstOrDefault(x => x.ProductId == id);

            if (product != null)
            {
                _context.Remove(product);
                _context.SaveChanges();
            }
        }

    }
}
