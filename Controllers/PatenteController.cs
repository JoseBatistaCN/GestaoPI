using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestaoPI.Data;
using GestaoPI.Models;
using GestaoPI.Models.Enums;
using GestaoPI.Interfaces;
using GestaoPI.Services;
public class PatenteController : Controller
    {
        private readonly IPatenteRepository _patenteRepository;
        private readonly GestaopiContext _context;

        public PatenteController(IPatenteRepository patenteRepository, GestaopiContext context)
        {
            _patenteRepository = patenteRepository;
            _context = context;
        }

        // GET: patente
        public async Task<IActionResult> Index()
        {
            var todasPatentes = await _patenteRepository.GetPatentes();
            return View(todasPatentes);
        }

        public async Task<IActionResult> Servicos(string id)
        {
            var servicosPatente = await (from sp in _context.ServicoPatentes where sp.CodigoPatente == id select sp).ToListAsync() ;
            return View("Views/Patente/Servico/Index.cshtml", servicosPatente);
        }

        // GET: patente/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patente = await _patenteRepository.GetPatenteById(id);
                
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
        public async Task<IActionResult> Create([Bind("Codigo,Titulo,Resumo,Situacao,Status,Deposito,Concessao,Exame,Publicacao,Anotacao")] Patente patente)
        {
            if (ModelState.IsValid)
            {
                await _patenteRepository.InsertPatente(patente);
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

            var patente = await _patenteRepository.GetPatenteById(id);
            if (patente == null)
            {
                return NotFound();
            }
            ViewBag.Situacoes = Enum.GetValues(typeof(PatenteSituacao));
            return View(patente);
        }

        // POST: patente/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Codigo,Titulo,Resumo,Situacao,Status,Deposito,Concessao,Exame,Publicacao, Anotacao")] Patente patente)
        {
            if (id != patente.Codigo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _patenteRepository.UpdatePatente(patente);
                                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_patenteRepository.PatenteExists(patente.Codigo))
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

            var patente =  await _patenteRepository.GetPatenteById(id);
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
            await _patenteRepository.DeletePatente(id);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Despacho(){

            return View("Views/Patente/Despacho/Index.cshtml");
        }

        
    }
