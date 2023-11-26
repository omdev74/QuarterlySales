using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuarterlySales.Models;
using System.Diagnostics;
using System.Linq;

namespace QuarterlySales.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context; // Add this line

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context) // Add ApplicationDbContext as a parameter
        {
            _logger = logger;
            _context = context; // Assign the context
        }

        public IActionResult Index()
        {
            // Populate ViewBag with employees for dropdown
            ViewBag.Employees = _context.Employees.ToList();
            return View();
        }

        [HttpGet]
        public IActionResult GetSalesData(int employeeId)
        {
            // Retrieve sales data for the selected employee
            var salesData = _context.SalesData
                .Where(s => s.EmployeeId == employeeId)
                .Select(s => new { s.Quarter, s.Year, s.Amount })
                .ToList();

            return Json(salesData);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
