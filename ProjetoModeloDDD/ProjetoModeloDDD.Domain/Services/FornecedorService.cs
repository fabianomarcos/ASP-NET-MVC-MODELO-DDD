using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositorios;
using ProjetoModeloDDD.Domain.Interfaces.Servicos;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Services
{
    public class FornecedorService : ServiceBase<Fornecedores>, IFornecedorService
    {
        private readonly IFornecedorRepositorio _fornecedorRepository;

        public FornecedorService(IFornecedorRepositorio fornecedorRepositorio)
            :base(fornecedorRepositorio)
        {
            _fornecedorRepository = fornecedorRepositorio;
        }

        public IEnumerable<Fornecedores> BuscarPorNome(string nome)
        {
            return _fornecedorRepository.BuscarPorNome(nome);
        }
    }
}
