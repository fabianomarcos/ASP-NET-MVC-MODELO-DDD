using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Servicos;
using ProjetoModeloDDD.Domain.Services;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application.Services
{
    public class HorarioAppService : AppServiceBase<Horarios>, IHorarioAppService
    {
        private readonly IHorarioService _horarioService;

        public HorarioAppService(HorarioService horarioService) :
            base(horarioService)
        {
            _horarioService = horarioService;
        }
    }
}
