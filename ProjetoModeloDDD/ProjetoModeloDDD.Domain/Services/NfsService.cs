using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositorios;
using ProjetoModeloDDD.Domain.Interfaces.Servicos;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Services
{
    public class NfsService : ServiceBase<NFs>, INfService
    {
        private readonly INFRepositorio _nfRepository;

        public NfsService(INFRepositorio nfRepositorio)
            :base(nfRepositorio)
        {
            _nfRepository = nfRepositorio;
        }
    }
}
