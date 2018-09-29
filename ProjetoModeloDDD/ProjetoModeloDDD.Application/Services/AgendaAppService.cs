using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Servicos;
using ProjetoModeloDDD.Domain.Services;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application.Services
{
    public class AgendaAppService : AppServiceBase<Agenda>, IAgendaAppService
    {
        private readonly IAgendaServices _agendaService;

        public AgendaAppService(AgendaService agendaService) : 
            base(agendaService)
        {
            _agendaService = agendaService;
        }
        public IEnumerable<Agenda> BuscarPorNome(string nome)
        {
            return _agendaService.BuscarPorNome(nome);
        }
    }
}
