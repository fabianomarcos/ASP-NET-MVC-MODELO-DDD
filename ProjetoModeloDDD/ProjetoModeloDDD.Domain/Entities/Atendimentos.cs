using System;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class Atendimento
    {
        public int AtendimentoId { get; set; }

        public string NomeCliente { get; set; }

        public int ServicoId { get; set; }
        public virtual Services Service { get; set; }

        public int ClienteId { get; set; }
        public virtual Services Cliente { get; set; }

        public int ColaboradorId { get; set; }
        public virtual Colaboradores Colaborador { get; set; }

        public int InsumoId { get; set; }
        public virtual Insumos Insumo { get; set; }

        public DateTime Data { get; set; }

        public decimal Valor { get; set; }

        public DateTime Horario { get; set; }
    }
}
