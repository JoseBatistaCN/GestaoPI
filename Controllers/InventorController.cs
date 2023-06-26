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
    public class InventorController : Controller
    {
        private readonly ILogger<InventorController> _logger;

        public InventorController(ILogger<InventorController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        
    }
}