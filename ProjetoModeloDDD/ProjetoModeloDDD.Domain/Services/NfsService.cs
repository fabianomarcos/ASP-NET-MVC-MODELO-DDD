using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositorios;
using ProjetoModeloDDD.Domain.Interfaces.Servicos;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Services
{
    public class NfsService : ServiceBase<NFs>, INfsServices
    {
        private readonly INfsRepositorio _nfRepository;

        public NfsService(INfsRepositorio nfRepositorio)
            :base(nfRepositorio)
        {
            _nfRepository = nfRepositorio;
        }

        public IEnumerable<NFs> BuscarPorNome(int nome)
        {
            return _nfRepository.BuscarPorNome(nome);
        }
    }
}
