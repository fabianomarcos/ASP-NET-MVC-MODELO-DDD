using System.Collections.Generic;
using ProjetoModeloDDD.Domain.Entities;
namespace ProjetoModeloDDD.Domain.Interfaces.Servicos
{
    public interface IServicoService : IServiceBase<Entities.Servicos>
    {
        IEnumerable<Entities.Servicos> BuscarPorNome(string nome);
    }
}
