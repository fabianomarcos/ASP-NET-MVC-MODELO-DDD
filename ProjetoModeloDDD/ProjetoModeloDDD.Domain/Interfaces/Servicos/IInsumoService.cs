﻿using System.Collections.Generic;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Domain.Interfaces.Servicos
{
    public interface IInsumoService : IServiceBase<Insumos>
    {
        IEnumerable<Insumos> BuscarPorNome(string nome);
    }
}
