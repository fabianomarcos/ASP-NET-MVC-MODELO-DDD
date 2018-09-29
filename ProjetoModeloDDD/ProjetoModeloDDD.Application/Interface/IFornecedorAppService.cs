using ProjetoModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application.Interface
{
    public interface IFornecedorAppService : IAppServiceBase<Fornecedores>
    {
        IEnumerable<Fornecedores> BuscarPorNome(string nome);
    }
}
