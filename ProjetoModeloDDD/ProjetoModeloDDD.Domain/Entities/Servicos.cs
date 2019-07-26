using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class Servicos
    {
        public int ServicosId { get; set; }

        public string Nome { get; set; }

        public decimal Valor { get; set; }

        public int InsumoId { get; set; }
        public virtual Insumos Insumo { get; set; }

        public IEnumerable<Agenda> Agenda { get; set; }

        public IEnumerable<Itens> Itens { get; set; }
    }
}