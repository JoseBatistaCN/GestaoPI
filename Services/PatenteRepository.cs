using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GestaoPI.Data;
using GestaoPI.Models;

namespace GestaoPI.Services
{
    public class PatenteRepository
    {
        private readonly GestaoPIContext _context;

        public PatenteRepository(GestaoPIContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Patente>> PegarTodas()
        {
            return await _context.Patentes!.ToListAsync();
        }

        public async Task InserirPatente(Patente patente)
        {
            _context.Patentes!.Add(patente);
            await _context.SaveChangesAsync();
        }

        public async Task<Patente?> pegarPatente(string id)
        {
            return await _context.Patentes.FindAsync(id);
        }

        public async Task AtualizarPatente(Patente patente)
        {
            _context.Update(patente);
            await _context.SaveChangesAsync();
        }

        public async Task ExcluirPatente(string id){
            var patente = await _context.Patentes!.FindAsync(id);
            _context.Patentes.Remove(patente!);
            await _context.SaveChangesAsync();
        }

        public Boolean ExistePatente(string id){
            return _context.Patentes.Any(e => e.Codigo == id);
        }
    }
}