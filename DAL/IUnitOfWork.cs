using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoPI.Models;

namespace GestaoPI.DAL
{
    public interface IUnitOfWork
    {
        GenericRepository<Patente> PatenteRepository { get; }
        GenericRepository<Marca> MarcaRepository { get; }
        GenericRepository<ProgramaDeComputador> ProgramaDeComputadorRepository { get; }
        GenericRepository<DesenhoIndustrial> DesenhoIndustrialRepository { get; }
        GenericRepository<Inventor> InventorRepository { get; }

        Task Save();
    }
}