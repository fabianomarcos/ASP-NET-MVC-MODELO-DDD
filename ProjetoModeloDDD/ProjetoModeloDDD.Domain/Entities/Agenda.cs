using System;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class Agenda
    {
        public int AgendaId { get; set; }

        public string Horas { get; set; }

        public DateTime? Data { get; set; }

        public string Horario { get; set; }

        public int ServicosId { get; set; }
        public virtual Servicos Servico { get; set; }

        public int ClienteId { get; set; }

        public int ColaboradorId { get; set; }
        public virtual Colaboradores Colaborador { get; set; }

        public bool Disponivel { get; set; }

       // public IEnumerable<Services> Servicos { get; set; }
    }
}
