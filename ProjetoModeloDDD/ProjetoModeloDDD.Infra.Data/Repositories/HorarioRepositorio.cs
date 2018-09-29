using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositorios;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class HorarioRepositorio : RepositorioBase<Horarios>, IHorarioRepositorio
    {
        public IEnumerable<Horarios> BuscarPorNome(string profissional)
        {
            var p = Db.Horarios.AsQueryable();
            if(!string.IsNullOrEmpty(profissional))
            p = p.Where(d => d.Colaborador.Nome.Contains(profissional));
            p = p.OrderBy(d => d.Data);
            return p.ToList();
        }
    }
}
