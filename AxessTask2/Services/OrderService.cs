using AxessTask2.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AxessTask2.Services
{
    public class OrderService : IService<Order, int>
    {
        private readonly NORTHWNDContext _context;

        public OrderService(NORTHWNDContext context)
        {
            _context = context;
        }

        public IEnumerable<Order> GetAll()
        {
            return _context.Orders.ToList();
        }

        public Order GetById(int id)
        {
            return _context.Orders.FirstOrDefault(x => x.OrderId == id);
        }

        public Order Insert(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
            return order;
        }
        public Order Update(int id, Order order)
        {
            _context.Orders.Update(order);
            _context.SaveChanges();
            return order;
        }

        public void Delete(int id)
        {
            var order = _context.Orders.FirstOrDefault(x => x.OrderId == id);

            if (order != null)
            {
                _context.Remove(order);
                _context.SaveChanges();
            }
        }

    }
}
