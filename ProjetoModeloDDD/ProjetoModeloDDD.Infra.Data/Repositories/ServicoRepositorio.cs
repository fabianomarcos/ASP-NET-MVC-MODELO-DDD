using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositorios;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class ServicoRepositorio : RepositorioBase<Services>, IServicesRepositorio
    {
        public IEnumerable<Services> BuscarPorNome(string nome)
        {
            return Db.Servicos.Where(p => p.Nome == nome);
        }
    }
}
