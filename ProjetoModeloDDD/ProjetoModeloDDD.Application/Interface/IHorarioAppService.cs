﻿using ProjetoModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application.Interface
{
    public interface IHorarioAppService : IAppServiceBase<Horarios>
    {
        IEnumerable<Horarios> BuscarPorNome(string profissional);
    }
}