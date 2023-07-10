using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestaoPI.DAL;
using GestaoPI.Models;

namespace GestaoPI.Controllers
{
    public class InventorController : Controller
    {
        private readonly GestaopiContext _context;

        public InventorController(GestaopiContext context)
        {
            _context = context;
        }

        // GET: Inventor
        public async Task<IActionResult> Index()
        {
            return View(await _context.Inventores.ToListAsync());
        }

        // GET: Inventor/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventor = await _context.Inventores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (inventor == null)
            {
                return NotFound();
            }

            return View(inventor);
        }

        // GET: Inventor/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Inventor/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome")] Inventor inventor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(inventor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(inventor);
        }

        // GET: Inventor/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventor = await _context.Inventores.FindAsync(id);
            if (inventor == null)
            {
                return NotFound();
            }
            return View(inventor);
        }

        // POST: Inventor/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome")] Inventor inventor)
        {
            if (id != inventor.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(inventor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InventorExists(inventor.Id))
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
            return View(inventor);
        }

        // GET: Inventor/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventor = await _context.Inventores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (inventor == null)
            {
                return NotFound();
            }

            return View(inventor);
        }

        // POST: Inventor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var inventor = await _context.Inventores.FindAsync(id);
            _context.Inventores.Remove(inventor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InventorExists(int id)
        {
            return _context.Inventores.Any(e => e.Id == id);
        }
    }
}
