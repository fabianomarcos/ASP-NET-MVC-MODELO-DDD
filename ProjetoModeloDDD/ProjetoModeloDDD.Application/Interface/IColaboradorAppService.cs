using ProjetoModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application.Interface
{
    public interface IColaboradorAppService : IAppServiceBase<Colaboradores>
    {
        IEnumerable<Colaboradores> BuscarPorNome(string nome);
    }
}
