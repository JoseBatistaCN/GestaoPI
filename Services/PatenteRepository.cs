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
    public class PatenteRepository : IPatenteRepository
    {
        private readonly GestaopiContext _context;

        public PatenteRepository(GestaopiContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Patente>> GetPatentes()
        {
            return await _context.Patentes!.ToListAsync();
        }

        public async Task InsertPatente(Patente processo)
        {
            processo.Titulo = processo.Titulo?.Trim();
            processo.Resumo = processo.Titulo?.Trim();
            _context.Patentes!.Add(processo);
            await _context.SaveChangesAsync();
        }

        public async Task<Patente> GetPatenteById(string id)
        {
            return  await _context.Patentes.FindAsync(id);
        }

        public async Task UpdatePatente(Patente processo)
        {
            processo.Titulo = processo.Titulo?.Trim();
            processo.Resumo = processo.Titulo?.Trim();
            _context.Update(processo);
            await _context.SaveChangesAsync();
        }

        public async Task DeletePatente(string id){
            var patente = await _context.Patentes!.FindAsync(id);
            _context.Patentes.Remove(patente!);
            await _context.SaveChangesAsync();
        }

        public Boolean PatenteExists(string id){
            return _context.Patentes.Any(e => e.Codigo == id);
        }

        public Task Save()
        {
            return _context.SaveChangesAsync();
        }
    }
}