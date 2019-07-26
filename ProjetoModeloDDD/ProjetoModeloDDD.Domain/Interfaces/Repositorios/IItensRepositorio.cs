using System.Collections.Generic;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Domain.Interfaces.Repositorios
{
    public interface IItensRepositorio : IRepositorioBase<Itens>
    {
        IEnumerable<Itens> BuscarPorId(int ItemId);
    }
}
