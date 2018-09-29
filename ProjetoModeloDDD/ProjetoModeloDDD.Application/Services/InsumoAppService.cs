using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Servicos;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application.Services
{
    public class InsumoAppService : AppServiceBase<Insumos>, IInsumoAppService
    {
        private readonly IInsumosServices _insumoService;

        public InsumoAppService(IInsumosServices insumoService) : 
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
