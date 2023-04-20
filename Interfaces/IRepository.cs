using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoPI.Interfaces
{
    public interface IRepository<T> where T: class
    {
        public Task<T?> ObterPorId(string id);
        public Task<IEnumerable<T>> ObterTodos();
        public Task Inserir(T processo);
        public Task Atualizar(T processo);
        public Task Excluir(string id);
        public Boolean Existe(string id);

    }
}