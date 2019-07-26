using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositorios;
using ProjetoModeloDDD.Domain.Interfaces.Servicos;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Services
{
    public class InsumosService : ServiceBase<Insumos>, IInsumoService
    {
        private readonly IInsumoRepositorio _insumoRepository;

        public InsumosService(IInsumoRepositorio insumoRepositorio)
            :base(insumoRepositorio)
        {
            _insumoRepository = insumoRepositorio;
        }

        public IEnumerable<Insumos> BuscarPorNome(string nome)
        {
            return _insumoRepository.BuscarPorNome(nome);
        }
    }
}
