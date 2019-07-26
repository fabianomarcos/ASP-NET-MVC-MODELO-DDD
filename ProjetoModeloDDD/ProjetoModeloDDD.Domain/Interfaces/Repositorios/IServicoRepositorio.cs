using ProjetoModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Interfaces.Repositorios
{
    public interface IServicoRepositorio : IRepositorioBase<Entities.Servicos>
    {
        IEnumerable<Entities.Servicos> BuscarPorNome(string nome);
    }
}