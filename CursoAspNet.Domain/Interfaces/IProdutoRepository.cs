using CursoAspNet.Domain.Entities;
using System.Collections.Generic;

namespace CursoAspNet.Domain.Interfaces
{
    public interface IProdutoRepository : IRepositoryBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}