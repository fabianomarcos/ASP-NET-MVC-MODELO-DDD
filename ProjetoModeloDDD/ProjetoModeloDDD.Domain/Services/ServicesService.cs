using ProjetoModeloDDD.Domain.Interfaces.Repositorios;
using ProjetoModeloDDD.Domain.Interfaces.Servicos;
using ProjetoModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Services
{
    public class ServicesService : ServiceBase<Servicos>, IServicoService
    {
        private readonly IServicoRepositorio _serviceRepository;

        public ServicesService(IServicoRepositorio serviceRepositorio)
            :base(serviceRepositorio)
        {
            _serviceRepository = serviceRepositorio;
        }

        public IEnumerable<Servicos> BuscarPorNome(string nome)
        {
            return _serviceRepository.BuscarPorNome(nome);
        }
    }
}
