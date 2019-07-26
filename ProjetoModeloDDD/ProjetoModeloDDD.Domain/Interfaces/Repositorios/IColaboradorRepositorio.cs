using System.Collections.Generic;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Domain.Interfaces.Repositorios
{
    public interface IColaboradorRepositorio : IRepositorioBase<Colaboradores>
    {
        IEnumerable<Colaboradores> BuscarPorNome(string nome);
    }
}
