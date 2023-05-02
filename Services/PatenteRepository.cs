using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GestaoPI.Data;
using GestaoPI.Models;
using GestaoPI.Interfaces;

namespace GestaoPI.Services
{
    public class PatenteRepository : IRepository<Patente>
    {
        private readonly GestaopiContext _context;

        public PatenteRepository(GestaopiContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Patente>> ObterTodos()
        {
            return await _context.Patentes!.ToListAsync();
        }

        public async Task Inserir(Patente processo)
        {
            _context.Patentes!.Add(processo);
            await _context.SaveChangesAsync();
        }

        public async Task<Patente?> ObterPorId(string id)
        {
            return await _context.Patentes.FindAsync(id);
        }

        public async Task Atualizar(Patente processo)
        {
            _context.Update(processo);
            await _context.SaveChangesAsync();
        }

        public async Task Excluir(string id){
            var patente = await _context.Patentes!.FindAsync(id);
            _context.Patentes.Remove(patente!);
            await _context.SaveChangesAsync();
        }

        public Boolean Existe(string id){
            return _context.Patentes.Any(e => e.Codigo == id);
        }

    }
}