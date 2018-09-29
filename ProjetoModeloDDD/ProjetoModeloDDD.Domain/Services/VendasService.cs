using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositorios;
using ProjetoModeloDDD.Domain.Interfaces.Servicos;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Services
{
    public class VendasService : ServiceBase<Vendas>, IVendasServices
    {
        private readonly IVendasRepositorio _vendasRepository;

        public VendasService(IVendasRepositorio vendasRepositorio)
            :base(vendasRepositorio)
        {
            _vendasRepository = vendasRepositorio;
        }

        public IEnumerable<Vendas> BuscarPorNome(int nome)
        {
            return _vendasRepository.BuscarPorNome(nome);
        }
    }
}
