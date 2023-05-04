using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoPI.Interfaces;
using GestaoPI.Models;
using GestaoPI.Data;
using Microsoft.EntityFrameworkCore;

namespace GestaoPI.Services
{
    public class ServicoPatenteRepository : IServicoRepository<Servicopatente>
    {
        private readonly GestaopiContext _context;

        public ServicoPatenteRepository(GestaopiContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Servicopatente>> ObterTodos(string processoId)
        {
            var servicosPatente = await _context.Servicopatentes
            .Where(sp => sp.PatenteCodigo == processoId).ToListAsync();

            return servicosPatente;
            
        }

        Task IServicoRepository<Servicopatente>.Atualizar(Servicopatente servico)
        {
            throw new NotImplementedException();
        }

        Task IServicoRepository<Servicopatente>.Excluir(string id)
        {
            throw new NotImplementedException();
        }

        bool IServicoRepository<Servicopatente>.Existe(string id)
        {
            throw new NotImplementedException();
        }

        Task IServicoRepository<Servicopatente>.Inserir(Servicopatente servico)
        {
            throw new NotImplementedException();
        }

        async Task<Servicopatente?> IServicoRepository<Servicopatente>.ObterPorId(string id)
        {
            throw new NotImplementedException();
        }

    }
}