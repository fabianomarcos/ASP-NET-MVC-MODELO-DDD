using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositorios;
using ProjetoModeloDDD.Domain.Interfaces.Servicos;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Services
{
    public class ColaboradorService : ServiceBase<Colaboradores>, IColaboradorService
    {
        private readonly IColaboradorRepositorio _colaboradorRepository;

        public ColaboradorService(IColaboradorRepositorio colaboradorRepositorio)
            :base(colaboradorRepositorio)
        {
            _colaboradorRepository = colaboradorRepositorio;
        }

        public IEnumerable<Colaboradores> BuscarPorNome(string nome)
        {
            return _colaboradorRepository.BuscarPorNome(nome);
        }
    }
}
