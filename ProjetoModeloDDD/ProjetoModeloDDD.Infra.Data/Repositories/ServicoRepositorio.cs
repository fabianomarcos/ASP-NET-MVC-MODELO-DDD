﻿using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositorios;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class ServicoRepositorio : RepositorioBase<Servicos>, IServicoRepositorio
    {
        public IEnumerable<Servicos> BuscarPorNome(string nome)
        {
            return Db.Servicos.Where(p => p.Nome == nome);
        }
    }
}
