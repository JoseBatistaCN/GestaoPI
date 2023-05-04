using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GestaoPI.Interfaces;
using GestaoPI.Models;

namespace GestaoPI.Controllers
{
    [Route("[controller]")]
    public class ServicoPatenteController : Controller
    {
        private readonly ILogger<ServicoPatenteController> _logger;
        private readonly IServicoRepository<Servicopatente> _servicoPatenteRepository;

        public ServicoPatenteController(ILogger<ServicoPatenteController> logger, 
        IServicoRepository<Servicopatente> servicoPatenteRepository)
        {
            _logger = logger;
            _servicoPatenteRepository = servicoPatenteRepository;
        }

        public IActionResult Index(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var servicos = _servicoPatenteRepository.ObterTodos(id);

            return View("Views/Patente/Servico/Index.cshtml", servicos);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}