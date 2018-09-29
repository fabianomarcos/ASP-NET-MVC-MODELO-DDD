using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Interfaces.Servicos;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application.Services
{
    public class ServicoAppService : AppServiceBase<Domain.Entities.Services>, IServicoAppService
    {
        private readonly IServicesServices _servicoService;

        public ServicoAppService(IServicesServices servicoService) : 
            base(servicoService)
        {
            _servicoService = servicoService;
        }
        public IEnumerable<Domain.Entities.Services> BuscarPorNome(string nome)
        {
            return _servicoService.BuscarPorNome(nome);
        }
    }
}
