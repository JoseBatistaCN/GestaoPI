using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GestaoPI.Services;

namespace GestaoPI.Controllers
{
    [Route("[controller]")]
    public class MarcaController : Controller
    {
        private readonly MarcaRepository _marcaRepository;
        private readonly ILogger<MarcaController> _logger;

        public MarcaController(ILogger<MarcaController> logger, MarcaRepository marcaRepository)
        {
            _marcaRepository = marcaRepository;
            _logger = logger;
        }

        public IActionResult Index()
        {

            return View();
        }
        
    }
}