using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositorios;
using ProjetoModeloDDD.Domain.Interfaces.Servicos;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Services
{
    public class HorarioService : ServiceBase<Horarios>, IHorariosServices
    {
        private readonly IHorarioRepositorio _horarioRepository;

        public HorarioService(IHorarioRepositorio horarioRepositorio)
            :base(horarioRepositorio)
        {
            _horarioRepository = horarioRepositorio;
        }
        public IEnumerable<Horarios> BuscarPorNome(string profissional)
        {
            return _horarioRepository.BuscarPorNome(profissional);
        }
    }
}
