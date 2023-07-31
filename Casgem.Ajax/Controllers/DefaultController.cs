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
    }
}