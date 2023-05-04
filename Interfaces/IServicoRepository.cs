using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoPI.Interfaces
{
    public interface IServicoRepository<T> where T: class
    {
        public Task<T?> ObterPorId(string id);
        public Task<IEnumerable<T>> ObterTodos(string processoId);
        public Task Inserir(T servico);
        public Task Atualizar(T servico);
        public Task Excluir(string id);
        public Boolean Existe(string id);
    }
}