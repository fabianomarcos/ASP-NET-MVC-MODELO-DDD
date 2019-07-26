using System.Collections.Generic;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Domain.Interfaces.Repositorios
{
    public interface IFornecedorRepositorio : IRepositorioBase<Fornecedores>
    {
        IEnumerable<Fornecedores> BuscarPorNome(string nome);
    }
}
