using ProjetoModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application.Interface
{
    public interface IProdutoAppService : IAppServiceBase<Produtos>
    {
        IEnumerable<Produtos> BuscarPorNome(string nome);
    }
}
