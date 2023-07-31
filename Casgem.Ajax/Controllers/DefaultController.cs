using Casgem.Ajax.DAL;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Casgem.Ajax.Controllers
{
    public class DefaultController : Controller
    {
        private readonly Context _context = new Context();

        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }

        [HttpGet]
        public IActionResult CustomerList()
        {
            var jsonCustomer = JsonConvert.SerializeObject(_context.Customers.ToList());
            return Json(jsonCustomer);
        }

        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            var values = JsonConvert.SerializeObject(_context.Customers);
            return Json(values);
        }

        [HttpPost]
        public IActionResult DeleteCustomer(int id)
        {
            var value = _context.Customers.Find(id);
            _context.Customers.Remove(value);
            _context.SaveChanges();

            return NoContent();
        }
    }
}