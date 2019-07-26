using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositorios;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class ClienteRepositorio : RepositorioBase<Cliente>, IClienteRepositorio
    {
        public IEnumerable<Cliente> BuscarPorNome(string nome)
        {
            return Db.Clientes.Where(p => p.Nome == nome);
        }
    }
}
