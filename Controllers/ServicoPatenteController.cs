using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestaoPI.Data;
using GestaoPI.Models;

namespace GestaoPI.Controllers
{
    public class ServicoPatenteController : Controller
    {
        private readonly GestaopiContext _context;

        public ServicoPatenteController(GestaopiContext context)
        {
            _context = context;
        }

        // GET: ServicoPatente
        public async Task<IActionResult> Index()
        {
            var gestaopiContext = _context.ServicoPatentes.Include(s => s.CodigoServicoPatenteNavigation).Include(s => s.PatenteCodigoNavigation);
            return View(await gestaopiContext.ToListAsync());
        }

        // GET: ServicoPatente/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var servicopatente = await _context.ServicoPatentes
                .Include(s => s.CodigoServicoPatenteNavigation)
                .Include(s => s.PatenteCodigoNavigation)
                .FirstOrDefaultAsync(m => m.ServicoPatenteId == id);
            if (servicopatente == null)
            {
                return NotFound();
            }

            return View(servicopatente);
        }

        // GET: ServicoPatente/Create
        public IActionResult Create()
        {
            ViewData["ServicoCodigo"] = new SelectList(_context.CodigoServicoPatentes, "Servico", "Servico");
            ViewData["PatenteCodigo"] = new SelectList(_context.Patentes, "Codigo", "Codigo");
            return View();
        }

        // POST: ServicoPatente/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ServicoPatenteId,PatenteCodigo,ServicoCodigo,Valor")] ServicoPatente servicopatente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(servicopatente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ModelState.AddModelError("", "Ocorreu um erro durante o Bind do objeto Patente.");
            ViewData["ServicoCodigo"] = new SelectList(_context.CodigoServicoPatentes, "Servico", "Servico", servicopatente.ServicoCodigo);
            ViewData["PatenteCodigo"] = new SelectList(_context.Patentes, "Codigo", "Codigo", servicopatente.PatenteCodigo);
            return View(servicopatente);
        }

        // GET: ServicoPatente/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var servicopatente = await _context.ServicoPatentes.FindAsync(id);
            if (servicopatente == null)
            {
                return NotFound();
            }
            ViewData["ServicoCodigo"] = new SelectList(_context.CodigoServicoPatentes, "Servico", "Servico", servicopatente.ServicoCodigo);
            ViewData["PatenteCodigo"] = new SelectList(_context.Patentes, "Codigo", "Codigo", servicopatente.PatenteCodigo);
            return View(servicopatente);
        }

        // POST: ServicoPatente/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ServicoPatenteId,PatenteCodigo,ServicoCodigo,Valor, PatenteCodigoNavigation, CodigoServicoPatenteNavigation")] 
        ServicoPatente servicopatente)
        {
            Patente? patente = await _context.Patentes.FindAsync(servicopatente.PatenteCodigo);
            CodigoServicoPatente? codigoServico = await _context.CodigoServicoPatentes.FindAsync(servicopatente.ServicoCodigo);

            if (id != servicopatente.ServicoPatenteId || patente == null || codigoServico == null )
            
            {
                return NotFound();
            }

            servicopatente.CodigoServicoPatenteNavigation = codigoServico;
            servicopatente.PatenteCodigoNavigation = patente;


            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(servicopatente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ServicoPatenteExists(servicopatente.ServicoPatenteId))
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

            ViewData["ServicoCodigo"] = new SelectList(_context.CodigoServicoPatentes, "Servico", "Servico", 
            servicopatente.ServicoCodigo);
            ViewData["PatenteCodigo"] = new SelectList(_context.Patentes, "Codigo", "Codigo", servicopatente.PatenteCodigo);
            return View(servicopatente);
        }

        // GET: ServicoPatente/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var servicopatente = await _context.ServicoPatentes
                .Include(s => s.CodigoServicoPatenteNavigation)
                .Include(s => s.PatenteCodigoNavigation)
                .FirstOrDefaultAsync(m => m.ServicoPatenteId == id);
            if (servicopatente == null)
            {
                return NotFound();
            }

            return View(servicopatente);
        }

        // POST: ServicoPatente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var servicopatente = await _context.ServicoPatentes.FindAsync(id);
            _context.ServicoPatentes.Remove(servicopatente);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ServicoPatenteExists(int id)
        {
            return _context.ServicoPatentes.Any(e => e.ServicoPatenteId == id);
        }
    }
}
