using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QuarterlySales.Models;

namespace QuarterlySales.Controllers
{
    public class SalesDataController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SalesDataController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SalesData
        public async Task<IActionResult> Index()
        {
              return _context.SalesData != null ? 
                          View(await _context.SalesData.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.SalesData'  is null.");
        }

        // GET: SalesData/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.SalesData == null)
            {
                return NotFound();
            }

            var salesData = await _context.SalesData
                .FirstOrDefaultAsync(m => m.SalesDataId == id);
            if (salesData == null)
            {
                return NotFound();
            }

            return View(salesData);
        }

        // GET: SalesData/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SalesData/Create
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SalesDataId,Quarter,Year,Amount,EmployeeId")] SalesData salesData)
        {
            if (ModelState.IsValid)
            {
                _context.Add(salesData);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(salesData);
        }

        // GET: SalesData/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.SalesData == null)
            {
                return NotFound();
            }

            var salesData = await _context.SalesData.FindAsync(id);
            if (salesData == null)
            {
                return NotFound();
            }
            return View(salesData);
        }

        // POST: SalesData/Edit/5
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SalesDataId,Quarter,Year,Amount,EmployeeId")] SalesData salesData)
        {
            if (id != salesData.SalesDataId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(salesData);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SalesDataExists(salesData.SalesDataId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(salesData);
        }

        // GET: SalesData/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.SalesData == null)
            {
                return NotFound();
            }

            var salesData = await _context.SalesData
                .FirstOrDefaultAsync(m => m.SalesDataId == id);
            if (salesData == null)
            {
                return NotFound();
            }

            return View(salesData);
        }

        // POST: SalesData/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.SalesData == null)
            {
                return Problem("Entity set 'ApplicationDbContext.SalesData'  is null.");
            }
            var salesData = await _context.SalesData.FindAsync(id);
            if (salesData != null)
            {
                _context.SalesData.Remove(salesData);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SalesDataExists(int id)
        {
          return (_context.SalesData?.Any(e => e.SalesDataId == id)).GetValueOrDefault();
        }
    }
}
