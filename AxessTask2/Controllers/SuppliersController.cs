using AxessTask2.Models;
using AxessTask2.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AxessTask2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliersController : ControllerBase
    {
        private readonly IService<Supplier, int> _supplierService;

        public SuppliersController(IService<Supplier, int> supplierService)
        {
            _supplierService = supplierService;
        }

        [HttpGet]
        public IEnumerable<Supplier> GetAll()
        {
            var suppliers = _supplierService.GetAll();

            return suppliers;
        }

        [HttpGet("{id}")]
        public Supplier GetById(int id)
        {
            return _supplierService.GetById(id);
        }

        [HttpPost]
        public Supplier Insert(Supplier supplier)
        {
            return _supplierService.Insert(supplier);
        }
        [HttpPut("{id}")]
        public Supplier Update(int id, Supplier supplier)
        {
            return _supplierService.Update(id, supplier);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _supplierService.Delete(id);
        }

    }
}
