using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositorios;
using ProjetoModeloDDD.Domain.Interfaces.Servicos;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Services
{
    public class VendasService : ServiceBase<Vendas>, IVendasService
    {
        private readonly IVendasRepositorio _vendasRepository;

        public VendasService(IVendasRepositorio vendasRepositorio)
            :base(vendasRepositorio)
        {
            _vendasRepository = vendasRepositorio;
        }
    }
}
