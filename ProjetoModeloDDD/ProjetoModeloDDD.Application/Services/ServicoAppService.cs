using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Servicos;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application.Services
{
    public class ServicoAppService : AppServiceBase<Domain.Entities.Servicos>, IServicoAppService
    {
        private readonly IServicoService _servicoService;

        public ServicoAppService(IServicoService servicoService) : 
            base(servicoService)
        {
            _servicoService = servicoService;
        }

        public IEnumerable<Servicos> BuscarPorNome(string nome)
        {
            return _servicoService.BuscarPorNome(nome);
        }
    }
}
