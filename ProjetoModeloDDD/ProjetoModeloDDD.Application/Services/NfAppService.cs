using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Servicos;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application.Services
{
    public class NfAppService : AppServiceBase<NFs>, INfAppService
    {
        private readonly INfsServices _nfService;

        public NfAppService(INfsServices nfService) : 
            base(nfService)
        {
            _nfService = nfService;
        }
        public IEnumerable<NFs> BuscarPorNome(int nome)
        {
            return _nfService.BuscarPorNome(nome);
        }
    }
}
