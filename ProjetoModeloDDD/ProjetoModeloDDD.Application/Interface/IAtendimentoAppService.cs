using ProjetoModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application.Interface
{
    public interface IAtendimentoAppService : IAppServiceBase<Atendimento>
    {
        IEnumerable<Atendimento> BuscarPorNome(string nome);
    }
}
