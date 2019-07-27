using System.Collections.Generic;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Application.Interface
{
    public interface IServicoAppService : IAppServiceBase<Servicos>
    {
        IEnumerable<Servicos> BuscarPorNome(string nome);
    }
}
