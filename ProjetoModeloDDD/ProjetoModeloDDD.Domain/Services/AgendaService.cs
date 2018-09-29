using System.Collections.Generic;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Servicos;
using ProjetoModeloDDD.Domain.Interfaces.Repositorios;

namespace ProjetoModeloDDD.Domain.Services
{
    public class AgendaService : ServiceBase<Agenda>, IAgendaServices
    {
        private readonly IAgendaRepositorio _agendaRepository;

        public AgendaService(IAgendaRepositorio agendaRepositorio)
            :base(agendaRepositorio)
        {
            _agendaRepository = agendaRepositorio;
        }

        public IEnumerable<Agenda> BuscarPorNome(string profissional)
        {
            return _agendaRepository.BuscarPorNome(profissional);
        }
    }
}
