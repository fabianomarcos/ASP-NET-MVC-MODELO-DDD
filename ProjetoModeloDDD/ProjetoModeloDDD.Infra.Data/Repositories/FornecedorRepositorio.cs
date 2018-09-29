using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositorios;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class FornecedorRepositorio : RepositorioBase<Fornecedores>, IFornecedorRepositorio
    {
        public IEnumerable<Fornecedores> BuscarPorNome(string nome)
        {
            return Db.Fornecedores.Where(p => p.Nome == nome);
        }
    }
}
