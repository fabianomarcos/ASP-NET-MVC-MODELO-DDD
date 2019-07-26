using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Servicos;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application.Services
{
    public class InsumoAppService : AppServiceBase<Insumos>, IInsumoAppService
    {
        private readonly IInsumoService _insumoService;

        public InsumoAppService(IInsumoService insumoService) : 
            base(insumoService)
        {
            _insumoService = insumoService;
        }
        public IEnumerable<Insumos> BuscarPorNome(string nome)
        {
            return _insumoService.BuscarPorNome(nome);
        }
    }
}
