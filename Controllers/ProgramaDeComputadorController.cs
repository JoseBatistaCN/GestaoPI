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
    public class ProgramaDeComputadorController : Controller
    {
        private readonly GestaopiContext _context;

        public ProgramaDeComputadorController(GestaopiContext context)
        {
            _context = context;
        }

        // GET: ProgramaDeComputador
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProgramaDeComputadores.ToListAsync());
        }

        // GET: ProgramaDeComputador/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programaDeComputador = await _context.ProgramaDeComputadores
                .FirstOrDefaultAsync(m => m.Codigo == id);
            if (programaDeComputador == null)
            {
                return NotFound();
            }

            return View(programaDeComputador);
        }

        // GET: ProgramaDeComputador/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProgramaDeComputador/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Codigo,Titulo,Deposito,Concessao")] ProgramaDeComputador programaDeComputador)
        {
            if (ModelState.IsValid)
            {
                _context.Add(programaDeComputador);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(programaDeComputador);
        }

        // GET: ProgramaDeComputador/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programaDeComputador = await _context.ProgramaDeComputadores.FindAsync(id);
            if (programaDeComputador == null)
            {
                return NotFound();
            }
            return View(programaDeComputador);
        }

        // POST: ProgramaDeComputador/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Codigo,Titulo,Deposito,Concessao")] ProgramaDeComputador programaDeComputador)
        {
            if (id != programaDeComputador.Codigo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(programaDeComputador);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProgramaDeComputadorExists(programaDeComputador.Codigo))
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
            return View(programaDeComputador);
        }

        // GET: ProgramaDeComputador/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programaDeComputador = await _context.ProgramaDeComputadores
                .FirstOrDefaultAsync(m => m.Codigo == id);
            if (programaDeComputador == null)
            {
                return NotFound();
            }

            return View(programaDeComputador);
        }

        // POST: ProgramaDeComputador/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var programaDeComputador = await _context.ProgramaDeComputadores.FindAsync(id);
            _context.ProgramaDeComputadores.Remove(programaDeComputador);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProgramaDeComputadorExists(string id)
        {
            return _context.ProgramaDeComputadores.Any(e => e.Codigo == id);
        }
    }
}
