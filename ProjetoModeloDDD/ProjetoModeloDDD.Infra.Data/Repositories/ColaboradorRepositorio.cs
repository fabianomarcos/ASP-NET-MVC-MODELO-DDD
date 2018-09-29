using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositorios;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class ColaboradorRepositorio : RepositorioBase<Colaboradores>, IColaboradorRepositorio
    {
        public IEnumerable<Colaboradores> BuscarPorNome(string nome)
        {
            return Db.Colaboradores.Where(p => p.Nome == nome);
        }
    }
}
