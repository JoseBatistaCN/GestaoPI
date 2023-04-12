using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestaoPI.Models;
using GestaoPI.Context;

    public class PatenteController : Controller
    {
        private readonly PatenteContext _context;

        public PatenteController(PatenteContext context)
        {
            _context = context;
        }

        // GET: patente
        public async Task<IActionResult> Index()
        {
            return View(await _context.Patentes.ToListAsync());
        }

        // GET: patente/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patente = await _context.Patentes
                .FirstOrDefaultAsync(m => m.Codigo == id);
            if (patente == null)
            {
                return NotFound();
            }

            return View(patente);
        }

        // GET: patente/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: patente/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Codigo,Titulo,Resumo,Situacao,Status,Deposito,Concessao,Exame,DominioPublico, Anotacao")] Patente patente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(patente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(patente);
        }

        // GET: patente/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patente = await _context.Patentes.FindAsync(id);
            if (patente == null)
            {
                return NotFound();
            }
            return View(patente);
        }

        // POST: patente/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Codigo,Titulo,Resumo,Situacao,Status,Deposito,Concessao,Exame,DominioPublico, Anotacao")] Patente patente)
        {
            if (id != patente.Codigo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(patente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!patenteExists(patente.Codigo))
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
            return View(patente);
        }

        // GET: patente/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patente = await _context.Patentes
                .FirstOrDefaultAsync(m => m.Codigo == id);
            if (patente == null)
            {
                return NotFound();
            }

            return View(patente);
        }

        // POST: patente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var patente = await _context.Patentes.FindAsync(id);
            _context.Patentes.Remove(patente!);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool patenteExists(string id)
        {
            return _context.Patentes.Any(e => e.Codigo == id);
        }
    }
