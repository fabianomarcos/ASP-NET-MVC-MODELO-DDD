using System.Collections.Generic;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Domain.Interfaces.Repositorios
{
    public interface IInsumoRepositorio : IRepositorioBase<Insumos>
    {
        IEnumerable<Insumos> BuscarPorNome(string nome);
    }
}
