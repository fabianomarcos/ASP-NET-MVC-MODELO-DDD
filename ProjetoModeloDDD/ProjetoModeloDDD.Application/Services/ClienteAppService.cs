using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Servicos;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application
{
    public class ClienteAppService : AppServiceBase<Services> ,IClienteAppService
    {
        private readonly IClienteServices _clienteService;

        public ClienteAppService(IClienteServices clienteService) 
            : base(clienteService)
        {
            _clienteService = clienteService;
        }

        public IEnumerable<Services> ObterClientesEspeciais()
        {
            return _clienteService.ObterClientesEspeciais(_clienteService.GetAll());
        }
    }
}
