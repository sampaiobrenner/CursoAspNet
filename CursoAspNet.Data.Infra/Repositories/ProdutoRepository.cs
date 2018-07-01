using System.Collections.Generic;
using System.Linq;
using CursoAspNet.Domain.Entities;
using CursoAspNet.Domain.Interfaces;

namespace CursoAspNet.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return Db.Produtos.Where(p => p.Nome == nome);
        }
    }
}