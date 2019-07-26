using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Servicos;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application.Services
{
    public class NfAppService : AppServiceBase<NFs>, INfAppService
    {
        private readonly INfService _nfService;

        public NfAppService(INfService nfService) : 
            base(nfService)
        {
            _nfService = nfService;
        }
    }
}
