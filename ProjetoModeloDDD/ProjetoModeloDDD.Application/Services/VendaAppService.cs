using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Servicos;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application.Services
{
    public class VendaAppService : AppServiceBase<Vendas>, IVendasAppService
    {
        private readonly IVendasServices _vendaService;

        public VendaAppService(IVendasServices vendaService) : 
            base(vendaService)
        {
            _vendaService = vendaService;
        }
        public IEnumerable<Vendas> BuscarPorNome(int nome)
        {
            return _vendaService.BuscarPorNome(nome);
        }
    }
}
