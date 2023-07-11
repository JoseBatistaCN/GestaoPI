using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestaoPI.DAL;
using GestaoPI.Models;
using GestaoPI.Models.Enums;
using GestaoPI.Interfaces;
using GestaoPI.Services;
using System.Data.Common;

namespace GestaoPI.Controllers;
public class PatenteController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public PatenteController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: patente
        public async Task<IActionResult> Index()
        {
            var patentes = await _unitOfWork.PatenteRepository.Get();
            return View(patentes);
        }

        public IActionResult Servicos()
        {
            var servicosPatente = new List<ServicoPatente>();
            return View("Views/Patente/Servico/Index.cshtml", servicosPatente);
        }

        // GET: patente/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patente = await _unitOfWork.PatenteRepository.GetByID(id);
                
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
            patente.Exame = patente.Deposito.AddMonths(36);
            
            if (ModelState.IsValid)
            {
                await _unitOfWork.PatenteRepository.Insert(patente);
                return RedirectToAction(nameof(Index));
            } else {
                Console.WriteLine("Model State is not valid");
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

            var patente = await _unitOfWork.PatenteRepository.GetByID(id);
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
                    _unitOfWork.PatenteRepository.Update(patente);
                    await _unitOfWork.Save();
                                }
                catch (DbException)
                {
                    ModelState.AddModelError("", "Não foi possível salvar as alterações. " +
                        "Tente novamente, se o problema persistir " +
                        "consulte o administrador do sistema.");
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

            var patente =  await _unitOfWork.PatenteRepository.GetByID(id);
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
            await _unitOfWork.PatenteRepository.Delete(id);
            return RedirectToAction(nameof(Index));
        }


        public IActionResult Despacho(){

            return View("Views/Patente/Despacho/Index.cshtml");
        }

        public IActionResult Anuidade(){

            return View("Views/Patente/Anuidade/Index.cshtml");
        }

        
    }
