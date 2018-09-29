using System.Collections.Generic;

namespace ProjetoModeloDDD.Application.Interface
{
    public interface IServicoAppService : IAppServiceBase<Domain.Entities.Services>
    {
        IEnumerable<Domain.Entities.Services> BuscarPorNome(string nome);
    }
}
