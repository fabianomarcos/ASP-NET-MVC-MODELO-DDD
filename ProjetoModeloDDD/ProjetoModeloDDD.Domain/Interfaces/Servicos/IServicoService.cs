using System.Collections.Generic;
namespace ProjetoModeloDDD.Domain.Interfaces.Servicos
{
    public interface IServicoService : IServiceBase<Entities.Servicos>
    {
        IEnumerable<Entities.Servicos> BuscarPorNome(string nome);
    }
}
