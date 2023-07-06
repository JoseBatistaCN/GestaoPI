using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoPI.Models;

namespace GestaoPI.Interfaces
{
    public interface IPatenteRepository
    {
        Task<IEnumerable<Patente>> GetPatentes();
        Task<Patente> GetPatenteById(string id);
        Task InsertPatente(Patente patente);
        Task DeletePatente(string id);
        Task UpdatePatente(Patente patente);
        bool PatenteExists(string id);
        Task Save();


    }
}
