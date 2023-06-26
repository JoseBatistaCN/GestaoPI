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
    public class GraficoController : Controller
    {
        private readonly ILogger<GraficoController> _logger;

        public GraficoController(ILogger<GraficoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        
    }
}