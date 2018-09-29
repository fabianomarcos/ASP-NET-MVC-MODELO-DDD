using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Servicos;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application.Services
{
    public class FornecedorAppService : AppServiceBase<Fornecedores>, IFornecedorAppService
    {
        private readonly IFornecedoresServices _fornecedorService;

        public FornecedorAppService(IFornecedoresServices fornecedorService) : 
            base(fornecedorService)
        {
            _fornecedorService = fornecedorService;
        }
        public IEnumerable<Fornecedores> BuscarPorNome(string nome)
        {
            return _fornecedorService.BuscarPorNome(nome);
        }
    }
}
