using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoPI.Models;

namespace GestaoPI.DAL
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly GestaopiContext _context;
        private GenericRepository<Patente>? _patenteRepository;
        private GenericRepository<Marca>? _marcaRepository;
        private GenericRepository<ProgramaDeComputador>? _programaDeComputadorRepository;
        private GenericRepository<DesenhoIndustrial>? _desenhoIndustrialRepository;
        private GenericRepository<Inventor>? _inventorRepository;

        public UnitOfWork(GestaopiContext context)
        {
            _context = context;
        }

        public GenericRepository<Patente> PatenteRepository
        {
            get
            {
                this._patenteRepository ??= new GenericRepository<Patente>(_context);
                return _patenteRepository;
            }
        }

        public GenericRepository<Marca> MarcaRepository
        {
            get
            {
                this._marcaRepository ??= new GenericRepository<Marca>(_context);
                return _marcaRepository;
            }
        }

        public GenericRepository<ProgramaDeComputador> ProgramaDeComputadorRepository
        {
            get
            {
                this._programaDeComputadorRepository ??= new GenericRepository<ProgramaDeComputador>(_context);
                return _programaDeComputadorRepository;
            }
        }

        public GenericRepository<DesenhoIndustrial> DesenhoIndustrialRepository
        {
            get
            {
                this._desenhoIndustrialRepository ??= new GenericRepository<DesenhoIndustrial>(_context);
                return _desenhoIndustrialRepository;
            }
        }

        public GenericRepository<Inventor> InventorRepository
        {
            get
            {
                this._inventorRepository ??= new GenericRepository<Inventor>(_context);
                return _inventorRepository;
            }
        }



        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }

            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}