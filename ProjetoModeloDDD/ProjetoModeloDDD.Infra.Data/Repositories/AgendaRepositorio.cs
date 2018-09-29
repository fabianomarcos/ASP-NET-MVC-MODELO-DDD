using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositorios;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class AgendaRepositorio : RepositorioBase<Agenda>, IAgendaRepositorio
    {
        public IEnumerable<Agenda> BuscarPorNome(string profissional)
        {
            var p = Db.Agenda.AsQueryable();
            if (!string.IsNullOrEmpty(profissional))
                p = p.Where(d => d.Colaborador.Nome.Contains(profissional));
            p = p.OrderBy(d => d.Data);
            return p.ToList();
        }
    }
}
