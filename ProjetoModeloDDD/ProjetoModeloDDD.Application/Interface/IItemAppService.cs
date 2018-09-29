using ProjetoModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application.Interface
{
    public interface IItemAppService : IAppServiceBase<Itens>
    {
            IEnumerable<Itens>BuscarPorId(int Id);
    }
}
