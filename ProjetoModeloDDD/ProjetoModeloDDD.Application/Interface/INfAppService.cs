using ProjetoModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application.Interface
{
    public interface INfAppService : IAppServiceBase<NFs>
    {
        IEnumerable<NFs> BuscarPorNome(int nome);
    }
}
