using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Servicos;
using ProjetoModeloDDD.Domain.Services;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application.Services
{
    public class ColaboradorAppService : AppServiceBase<Colaboradores>, IColaboradorAppService
    {
        private readonly IColaboradorService _colaboradorService;

        public ColaboradorAppService(IColaboradorService colaboradorService) : 
            base(colaboradorService)
        {
            _colaboradorService = colaboradorService;
        }

        public IEnumerable<Colaboradores> BuscarPorNome(string nome)
        {
            return _colaboradorService.BuscarPorNome(nome);
        }
    }
}
