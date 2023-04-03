using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestaoPI.Models;

namespace GestaoPI.Controllers
{
    public class ProcessoController : Controller
    {
        private readonly GestaopiContext _context;

        public ProcessoController(GestaopiContext context)
        {
            _context = context;
        }

        // GET: Processo
        public async Task<IActionResult> Index()
        {
            return View(await _context.Processos.ToListAsync());
        }

        // GET: Processo/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var processo = await _context.Processos
                .FirstOrDefaultAsync(m => m.Codigo == id);
            if (processo == null)
            {
                return NotFound();
            }

            return View(processo);
        }

        // GET: Processo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Processo/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Tipo,Codigo,Titulo,Resumo,Deposito,Exame,DominioPublico,Anotacao,CodigoNotificacao")] Processo processo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(processo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(processo);
        }

        // GET: Processo/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var processo = await _context.Processos.FindAsync(id);
            if (processo == null)
            {
                return NotFound();
            }
            return View(processo);
        }

        // POST: Processo/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Tipo,Codigo,Titulo,Resumo,Deposito,Exame,DominioPublico,Anotacao,CodigoNotificacao")] Processo processo)
        {
            if (id != processo.Codigo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(processo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProcessoExists(processo.Codigo))
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
            return View(processo);
        }

        // GET: Processo/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var processo = await _context.Processos
                .FirstOrDefaultAsync(m => m.Codigo == id);
            if (processo == null)
            {
                return NotFound();
            }

            return View(processo);
        }

        // POST: Processo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var processo = await _context.Processos.FindAsync(id);
            _context.Processos.Remove(processo!);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProcessoExists(string id)
        {
            return _context.Processos.Any(e => e.Codigo == id);
        }
    }
}
