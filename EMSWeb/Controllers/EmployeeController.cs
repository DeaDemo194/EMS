using EMSWeb.Data;
using EMSWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace EMSWeb.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public EmployeeController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Employee> objEmployeeList = _db.Employees;
            return View(objEmployeeList);
        }
    }
}
