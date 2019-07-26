using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Servicos;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application.Services
{
    public class VendaAppService : AppServiceBase<Vendas>, IVendasAppService
    {
        private readonly IVendasService _vendaService;

        public VendaAppService(IVendasService vendaService) : 
            base(vendaService)
        {
            _vendaService = vendaService;
        }
    }
}
