using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositorios;
using ProjetoModeloDDD.Domain.Interfaces.Servicos;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Services
{
    public class HorarioService : ServiceBase<Horarios>, IHorarioService
    {
        private readonly IHorarioRepositorio _horarioRepository;

        public HorarioService(IHorarioRepositorio horarioRepositorio)
            :base(horarioRepositorio)
        {
            _horarioRepository = horarioRepositorio;
        }
    }
}
