using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoPI.Services
{
    public class PatenteServico
    {
        private readonly PatenteRepository _repository;

        public PatenteServico(PatenteRepository repository) {
            _repository = repository;
        }

    }
}