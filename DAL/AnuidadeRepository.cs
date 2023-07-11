using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GestaoPI.DAL
{
    public class AnuidadeRepository : GenericRepository<Anuidade>
    {
        internal GestaopiContext _context;


        public AnuidadeRepository(GestaopiContext context) : base(context)
        {
            this.dbSet = context.Set<Anuidade>();
            this._context = context;
        }

        public async Task<IEnumerable<Anuidade>> GetAnuidadesByPatente(string codigoPatente)
        {
            IQueryable<Anuidade> query = dbSet.Where(a => a.Patente.Codigo == codigoPatente);
            return await query.ToListAsync();
            
        }
    }
}