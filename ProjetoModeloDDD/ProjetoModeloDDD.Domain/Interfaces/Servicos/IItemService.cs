using System.Collections.Generic;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Domain.Interfaces.Servicos
{
    public interface IItemService : IServiceBase<Itens>
    {
        IEnumerable<Itens> BuscarPorId(int ItemId);
    }
}
