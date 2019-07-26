using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces;
using ProjetoModeloDDD.Domain.Interfaces.Repositorios;
using ProjetoModeloDDD.Domain.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Services
{
    public class ProdutoService : ServiceBase<Produtos>, IProdutoService
    {
        private readonly IProdutoRepositorio _produtoRepository;

        public ProdutoService(IProdutoRepositorio produtoRepositorio)
            :base(produtoRepositorio)
        {
            _produtoRepository = produtoRepositorio;
        }

        public IEnumerable<Produtos> BuscarPorNome(string nome)
        {
            return _produtoRepository.BuscarPorNome(nome);
        }
    }
}
