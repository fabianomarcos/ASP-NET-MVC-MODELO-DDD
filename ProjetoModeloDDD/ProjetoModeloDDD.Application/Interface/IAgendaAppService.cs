﻿using ProjetoModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application.Interface
{
    public interface IAgendaAppService : IAppServiceBase<Agenda>
    {
        IEnumerable<Agenda> BuscarPorNome(string profissional);
    }
}