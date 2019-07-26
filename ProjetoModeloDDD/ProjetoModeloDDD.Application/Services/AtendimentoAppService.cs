using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Servicos;
using ProjetoModeloDDD.Domain.Services;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application.Services
{
    public class AtendimentoAppService : AppServiceBase<Atendimento>, IAtendimentoAppService
    {
        private readonly IAtendimentoService _atendimentoService;

        public AtendimentoAppService(AtendimentoService atendimentoService) : 
            base(atendimentoService)
        {
            _atendimentoService = atendimentoService;
        }
    }
}
