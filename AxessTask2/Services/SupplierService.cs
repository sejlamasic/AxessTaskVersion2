using AxessTask2.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AxessTask2.Services
{
    public class SupplierService:IService<Supplier,int>
    {
        private readonly NORTHWNDContext _context;

        public SupplierService(NORTHWNDContext context)
        {
            _context = context;
        }


        public IEnumerable<Supplier> GetAll()
        {
            return _context.Suppliers.ToList();
        }

        public Supplier GetById(int id)
        {
            return _context.Suppliers.FirstOrDefault(x => x.SupplierId == id);
        }

        public Supplier Insert(Supplier supplier)
        {
            _context.Suppliers.Add(supplier);
            _context.SaveChanges();
            return supplier;
        }
        public Supplier Update(int id, Supplier supplier)
        {
            _context.Suppliers.Update(supplier);
            _context.SaveChanges();
            return supplier;
        }

        public void Delete(int id)
        {
            var supplier = _context.Suppliers.FirstOrDefault(x => x.SupplierId == id);

            if (supplier != null)
            {
                _context.Remove(supplier);
                _context.SaveChanges();
            }
        }
    }
}
