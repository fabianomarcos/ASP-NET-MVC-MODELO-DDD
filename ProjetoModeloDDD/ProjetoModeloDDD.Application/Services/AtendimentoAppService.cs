using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Servicos;
using ProjetoModeloDDD.Domain.Services;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application.Services
{
    public class AtendimentoAppService : AppServiceBase<Atendimento>, IAtendimentoAppService
    {
        private readonly IAtendimentoServices _atendimentoService;

        public AtendimentoAppService(AtendimentoService atendimentoService) : 
            base(atendimentoService)
        {
            _atendimentoService = atendimentoService;
        }
        public IEnumerable<Atendimento> BuscarPorNome(string nome)
        {
            return _atendimentoService.BuscarPorNome(nome);
        }
    }
}
