using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositorios;
using ProjetoModeloDDD.Domain.Interfaces.Servicos;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Services
{
    public class AtendimentoService : ServiceBase<Atendimento>, IAtendimentoService
    {
        private readonly IAtendimentoRepositorio _atendimentoRepository;

        public AtendimentoService(IAtendimentoRepositorio atendimentoRepositorio)
            :base(atendimentoRepositorio)
        {
            _atendimentoRepository = atendimentoRepositorio;
        }

        public IEnumerable<Atendimento> BuscarPorNome(string nome)
        {
            return _atendimentoRepository.BuscarPorNome(nome);
        }
    }
}
