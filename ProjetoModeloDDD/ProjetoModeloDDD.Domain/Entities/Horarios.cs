using System;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class Horarios
    {
        public int HorarioId { get; set; }

        public string Horas { get; set; }

        public DateTime? Data { get; set; }

        public int ColaboradorId { get; set; }
        public virtual Colaboradores Colaborador { get; set; }
    }
}
