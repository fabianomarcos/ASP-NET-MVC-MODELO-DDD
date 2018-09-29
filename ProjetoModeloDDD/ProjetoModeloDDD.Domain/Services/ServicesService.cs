using ProjetoModeloDDD.Domain.Interfaces.Repositorios;
using ProjetoModeloDDD.Domain.Interfaces.Servicos;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Services
{
    public class ServicesService : ServiceBase<Entities.Services>, IServicesServices
    {
        private readonly IServicesRepositorio _serviceRepository;

        public ServicesService(IServicesRepositorio serviceRepositorio)
            :base(serviceRepositorio)
        {
            _serviceRepository = serviceRepositorio;
        }

        public IEnumerable<Entities.Services> BuscarPorNome(string nome)
        {
            return _serviceRepository.BuscarPorNome(nome);
        }
    }
}
