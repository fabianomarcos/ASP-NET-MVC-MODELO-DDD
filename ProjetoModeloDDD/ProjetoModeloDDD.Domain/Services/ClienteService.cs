using System.Collections.Generic;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces;
using ProjetoModeloDDD.Domain.Interfaces.Servicos;
using System.Linq;
using ProjetoModeloDDD.Domain.Interfaces.Repositorios;

namespace ProjetoModeloDDD.Domain.Services
{
    public class ClienteService : ServiceBase<Services>, IClienteServices
    {
        private readonly IClienteRepositorio _clienteRepository;

        public ClienteService(IClienteRepositorio clienteRepositorio)
            :base(clienteRepositorio)
        {
            _clienteRepository = clienteRepositorio;
        }

        public IEnumerable<Services> ObterClientesEspeciais(IEnumerable<Services> clientes)
        {
            return clientes.Where(c => c.ClienteEspecial(c));
        }
     }
}
