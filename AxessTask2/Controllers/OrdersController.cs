using AxessTask2.Models;
using AxessTask2.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AxessTask2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IService<Order, int> _orderService;

        public OrdersController(IService<Order, int> orderService)
        {
            _orderService = orderService;
        }
        [HttpGet]
        public IEnumerable<Order> GetAll()
        {
            var orders =  _orderService.GetAll();

            return orders;
        }
        [HttpGet("{id}")]
        public Order GetById(int id)
        {
            return  _orderService.GetById(id);

        }
        [HttpPost]
        public Order Insert(Order order)
        {
            return _orderService.Insert(order);
        }
        [HttpPut("{id}")]
        public Order Update(int id, Order order)
        {
            return _orderService.Update(id, order);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
         _orderService.Delete(id);
        }

    }
}
