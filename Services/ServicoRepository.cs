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
    public class ServicoPatenteRepository : IServicoRepository<ServicoPatente>
    {
        private readonly GestaopiContext _context;

        public ServicoPatenteRepository(GestaopiContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ServicoPatente>> ObterTodos(string processoId)
        {
            var servicosPatente = await _context.ServicoPatentes
            .Where(sp => sp.PatenteCodigo == processoId).ToListAsync();

            return servicosPatente;
            
        }

        Task IServicoRepository<ServicoPatente>.Atualizar(ServicoPatente servico)
        {
            throw new NotImplementedException();
        }

        Task IServicoRepository<ServicoPatente>.Excluir(string id)
        {
            throw new NotImplementedException();
        }

        bool IServicoRepository<ServicoPatente>.Existe(string id)
        {
            throw new NotImplementedException();
        }

        Task IServicoRepository<ServicoPatente>.Inserir(ServicoPatente servico)
        {
            throw new NotImplementedException();
        }

        async Task<ServicoPatente?> IServicoRepository<ServicoPatente>.ObterPorId(string id)
        {
            throw new NotImplementedException();
        }

    }
}