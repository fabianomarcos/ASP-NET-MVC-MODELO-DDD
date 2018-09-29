using ProjetoModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application.Interface
{
    public interface IInsumoAppService : IAppServiceBase<Insumos>
    {
        IEnumerable<Insumos> BuscarPorNome(string nome);
    }
}
