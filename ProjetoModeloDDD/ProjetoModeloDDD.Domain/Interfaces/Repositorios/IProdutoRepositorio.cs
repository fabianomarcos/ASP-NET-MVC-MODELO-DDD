using ProjetoModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Interfaces.Repositorios
{
    public interface IProdutoRepositorio : IRepositorioBase<Produtos>
    {
        IEnumerable<Produtos> BuscarPorNome(string nome);
    }
}
