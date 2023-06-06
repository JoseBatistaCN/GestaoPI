using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace GestaoPI.Views.Home
{
    public class Revista : PageModel
    {
        private readonly ILogger<Revista> _logger;

        public Revista(ILogger<Revista> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}