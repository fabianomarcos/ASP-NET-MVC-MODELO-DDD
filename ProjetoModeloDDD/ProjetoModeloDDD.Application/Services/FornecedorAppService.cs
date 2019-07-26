using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Servicos;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application.Services
{
    public class FornecedorAppService : AppServiceBase<Fornecedores>, IFornecedorAppService
    {
        private readonly IFornecedorService _fornecedorService;

        public FornecedorAppService(IFornecedorService fornecedorService) : 
            base(fornecedorService)
        {
            _fornecedorService = fornecedorService;
        }
    }
}
