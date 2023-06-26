using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoPI.Models;
using GestaoPI.Data;
 

namespace GestaoPI.Services
{
    public class MarcaRepository 
    {
        private readonly GestaopiContext _context;

        public MarcaRepository(GestaopiContext context)
        {
            _context = context;
        }


    }
}