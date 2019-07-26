using System.Collections.Generic;
using ProjetoModeloDDD.Domain.Entities;


namespace ProjetoModeloDDD.Domain.Interfaces.Servicos
{
    public interface IColaboradorService : IServiceBase<Colaboradores>
    {
        IEnumerable<Colaboradores> BuscarPorNome(string nome);
        
    }
}
