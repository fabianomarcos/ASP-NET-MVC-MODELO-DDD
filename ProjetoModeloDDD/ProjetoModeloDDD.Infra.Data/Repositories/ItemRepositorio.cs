using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositorios;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class ItemRepositorio : RepositorioBase<Itens>, IItemRepositorio
    {
        public IEnumerable<Itens> BuscarPorId(int Id)
        {
            return Db.Itens.Where(p => p.Venda.VendasId == Id);
        }
    }
}
