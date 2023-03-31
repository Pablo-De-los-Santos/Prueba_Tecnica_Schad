using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Prueba_Tecnica_Schad.Context;
using Prueba_Tecnica_Schad.Models;

namespace Prueba_Tecnica_Schad.Controllers
{
    public class CustomerTypesController : Controller
    {
        private readonly PtsDbContext _context;

        public CustomerTypesController(PtsDbContext context)
        {
            _context = context;
        }

        // GET: CustomerTypes
        public async Task<IActionResult> Index()
        {
              return _context.CustomerTypes != null ? 
                          View(await _context.CustomerTypes.ToListAsync()) :
                          Problem("Entity set 'PtsDbContext.CustomerTypes'  is null.");
        }

        // GET: CustomerTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.CustomerTypes == null)
            {
                return NotFound();
            }

            var customerTypes = await _context.CustomerTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customerTypes == null)
            {
                return NotFound();
            }

            return View(customerTypes);
        }

        // GET: CustomerTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CustomerTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Description")] CustomerTypes customerTypes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customerTypes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customerTypes);
        }

        // GET: CustomerTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.CustomerTypes == null)
            {
                return NotFound();
            }

            var customerTypes = await _context.CustomerTypes.FindAsync(id);
            if (customerTypes == null)
            {
                return NotFound();
            }
            return View(customerTypes);
        }

        // POST: CustomerTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Description")] CustomerTypes customerTypes)
        {
            if (id != customerTypes.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customerTypes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerTypesExists(customerTypes.Id))
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
            return View(customerTypes);
        }

        // GET: CustomerTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CustomerTypes == null)
            {
                return NotFound();
            }

            var customerTypes = await _context.CustomerTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customerTypes == null)
            {
                return NotFound();
            }

            return View(customerTypes);
        }

        // POST: CustomerTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CustomerTypes == null)
            {
                return Problem("Entity set 'PtsDbContext.CustomerTypes'  is null.");
            }
            var customerTypes = await _context.CustomerTypes.FindAsync(id);
            if (customerTypes != null)
            {
                _context.CustomerTypes.Remove(customerTypes);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerTypesExists(int id)
        {
          return (_context.CustomerTypes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
