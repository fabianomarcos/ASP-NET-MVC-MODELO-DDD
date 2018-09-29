using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositorios;
using ProjetoModeloDDD.Domain.Interfaces.Servicos;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Services
{
    public class InsumosService : ServiceBase<Insumos>, IInsumosServices
    {
        private readonly IInsumosRepositorio _insumoRepository;

        public InsumosService(IInsumosRepositorio insumoRepositorio)
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
