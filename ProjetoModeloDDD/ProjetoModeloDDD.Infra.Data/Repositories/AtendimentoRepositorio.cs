using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositorios;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class AtendimentoRepositorio : RepositorioBase<Atendimento>, IAtendimentoRepositorio
    {
        public IEnumerable<Atendimento> BuscarPorNome(string nome)
        {
            return Db.Atendimentos.Where(p => p.NomeCliente == nome);
        }
    }
}
