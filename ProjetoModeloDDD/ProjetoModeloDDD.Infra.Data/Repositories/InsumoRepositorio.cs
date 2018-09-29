using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositorios;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class InsumoRepositorio : RepositorioBase<Insumos>, IInsumosRepositorio
    {
        public IEnumerable<Insumos> BuscarPorNome(string nome)
        {
            return Db.Insumos.Where(p => p.Nome == nome);
        }
    }
}
