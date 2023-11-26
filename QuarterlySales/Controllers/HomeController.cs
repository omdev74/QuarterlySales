using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuarterlySales.Models;

namespace QuarterlySales.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index(int page = 1, int pageSize = 10, string sortBy = "Quarter", string sortOrder = "asc",
            int? filterEmployee = null, int? filterYear = null, int? filterQuarter = null)
        {
            var query = _context.SalesData.AsQueryable();

            // Apply filters
            if (filterEmployee.HasValue)
                query = query.Where(s => s.EmployeeId == filterEmployee);
            if (filterYear.HasValue)
                query = query.Where(s => s.Year == filterYear);
            if (filterQuarter.HasValue)
                query = query.Where(s => s.Quarter == filterQuarter);

            // Apply sorting
            query = ApplySorting(query, sortBy, sortOrder);

            // Paginate the results
            var totalRecords = query.Count();
            var totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
            var recordsToSkip = (page - 1) * pageSize;

            var salesData = query.Skip(recordsToSkip).Take(pageSize).ToList();

            // Populate ViewBag with necessary data for filters and pagination
            ViewBag.Employees = _context.Employees.ToList();
            ViewBag.TotalPages = totalPages;
            ViewBag.CurrentPage = page;
            ViewBag.PageSize = pageSize;
            ViewBag.SortBy = sortBy;
            ViewBag.SortOrder = sortOrder;
            ViewBag.FilterEmployee = filterEmployee;
            ViewBag.FilterYear = filterYear;
            ViewBag.FilterQuarter = filterQuarter;

            return View(salesData);
        }

        private IQueryable<SalesData> ApplySorting(IQueryable<SalesData> query, string sortBy, string sortOrder)
        {
            switch (sortBy)
            {
                case "Quarter":
                    query = sortOrder.ToLower() == "asc" ? query.OrderBy(s => s.Quarter) : query.OrderByDescending(s => s.Quarter);
                    break;
                case "Year":
                    query = sortOrder.ToLower() == "asc" ? query.OrderBy(s => s.Year) : query.OrderByDescending(s => s.Year);
                    break;
                case "Amount":
                    query = sortOrder.ToLower() == "asc" ? query.OrderBy(s => s.Amount) : query.OrderByDescending(s => s.Amount);
                    break;
                    // Add more cases for additional sorting options
            }

            return query;
        }

        [HttpGet]
        public IActionResult GetSalesData(int employeeId)
        {
            // Retrieve sales data for the selected employee
            var salesData = _context.SalesData
                .Where(s => s.EmployeeId == employeeId);

            
            salesData = salesData.OrderBy(s => s.Quarter).ThenBy(s => s.Year);

            var result = salesData.Select(s => new { s.Quarter, s.Year, s.Amount }).ToList();

            return Json(result);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = System.Diagnostics.Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
