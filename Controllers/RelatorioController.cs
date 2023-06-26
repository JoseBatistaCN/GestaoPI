using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GestaoPI.Controllers
{
    [Route("[controller]")]
    public class RelatorioController : Controller
    {
        private readonly ILogger<RelatorioController> _logger;

        public RelatorioController(ILogger<RelatorioController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}