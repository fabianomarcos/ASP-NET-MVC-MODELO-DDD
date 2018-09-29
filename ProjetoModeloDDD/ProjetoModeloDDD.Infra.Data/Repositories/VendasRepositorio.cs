using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class VendasRepositorio : RepositorioBase<Vendas>, IVendasRepositorio
    {
        public IEnumerable<Vendas> BuscarPorNome(int nome)
        {
            return Db.Vendas.Where(p => p.VendasId == nome);
        }
    }
}
