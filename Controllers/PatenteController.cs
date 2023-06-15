using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestaoPI.Models;
using GestaoPI.Models.Enums;
using GestaoPI.Interfaces;
using GestaoPI.Data;
    public class PatenteController : Controller
    {
        private readonly IProcessoRepository<Patente> _patenteRepository;
        private readonly GestaopiContext _context;

        public PatenteController(IProcessoRepository<Patente> patenteRepository, GestaopiContext context)
        {
            _patenteRepository = patenteRepository;
            _context = context;
        }

        // GET: patente
        public async Task<IActionResult> Index()
        {
            var todasPatentes = await _patenteRepository.ObterTodos();
            return View(todasPatentes);
        }

        public async Task<IActionResult> Servicos(string id)
        {
            var servicosPatente = await (from sp in _context.ServicoPatentes where sp.PatenteCodigo == id select sp).ToListAsync() ;
            return View("Views/Patente/Servico/Index.cshtml", servicosPatente);
        }

        // GET: patente/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patente = await _patenteRepository.ObterPorId(id);
                
            if (patente == null)
            {
                return NotFound();
            }

            return View(patente);
        }

        // GET: patente/Create
        public IActionResult Create()
        {
            ViewBag.Situacoes = Enum.GetValues(typeof(PatenteSituacao));
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
                await _patenteRepository.Inserir(patente);
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

            var patente = await _patenteRepository.ObterPorId(id);
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
                    await _patenteRepository.Atualizar(patente);
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

            var patente =  await _patenteRepository.ObterPorId(id);
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
            await _patenteRepository.Excluir(id);
            return RedirectToAction(nameof(Index));
        }

        private bool patenteExists(string id)
        {
            return _patenteRepository.Existe(id);
        }
    }
