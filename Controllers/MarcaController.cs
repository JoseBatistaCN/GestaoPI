using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestaoPI.DAL;
using GestaoPI.Models;
using System.Data;

namespace GestaoPI.Controllers
{
    public class MarcaController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public MarcaController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: Marca
        public async Task<IActionResult> Index()
        {
            var marcas = await _unitOfWork.MarcaRepository.Get();
            return View(marcas.ToList());
        }

        // GET: Marca/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var marca = await _unitOfWork.MarcaRepository.GetByID(id);
            if (marca == null)
            {
                return NotFound();
            }

            return View(marca);
        }

        // GET: Marca/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Marca/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Codigo,Titulo,Apresentacao,Situacao,Deposito,Concessao,Anotacao,Status")] Marca marca)
        {
            if (ModelState.IsValid)
            {
                await _unitOfWork.MarcaRepository.Insert(marca);
                await _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(marca);
        }

        // GET: Marca/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var marca = await _unitOfWork.MarcaRepository.GetByID(id);
            if (marca == null)
            {
                return NotFound();
            }
            return View(marca);
        }

        // POST: Marca/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Codigo,Titulo,Apresentacao,Situacao,Deposito,Concessao,Anotacao,Status")] Marca marca)
        {
            if (id != marca.Codigo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _unitOfWork.MarcaRepository.Update(marca);
                    await _unitOfWork.Save();
                }
                catch (DataException)
                {
                    ModelState.AddModelError("", "Não foi possível salvar as alterações. Tente novamente, se o problema persistir, contate o administrador do sistema.");
                }
                return RedirectToAction(nameof(Index));
            }
            return View(marca);
        }

        // GET: Marca/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var marca = await _unitOfWork.MarcaRepository.GetByID(id);
            if (marca == null)
            {
                return NotFound();
            }

            return View(marca);
        }

        // POST: Marca/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var marca = await _unitOfWork.MarcaRepository.GetByID(id);
            if (marca == null)
            {
                return NotFound();
            } else {
                _unitOfWork.MarcaRepository.Delete(marca);
                await _unitOfWork.Save();
            }
            
            return RedirectToAction(nameof(Index));
        }

    }
}
