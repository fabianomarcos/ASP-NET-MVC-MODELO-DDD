using ProjetoModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Interfaces.Servicos
{
    public interface IProdutoService : IServiceBase<Produtos>
    {
        IEnumerable<Produtos> BuscarPorNome(string nome);
    }
}