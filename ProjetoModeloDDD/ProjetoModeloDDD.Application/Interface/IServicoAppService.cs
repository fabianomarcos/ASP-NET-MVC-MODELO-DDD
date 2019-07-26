using System.Collections.Generic;

namespace ProjetoModeloDDD.Application.Interface
{
    public interface IServicoAppService : IAppServiceBase<Servicos>
    {
        IEnumerable<Servicos> BuscarPorNome(string nome);
    }
}
