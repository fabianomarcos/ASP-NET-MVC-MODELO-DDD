using System;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class Vendas
    {
        public int VendasId { get; set; }

        public decimal ValorTotal { get; set; }

        public DateTime Data { get; set; }

        public int ColaboradorId { get; set; }
        public virtual Colaboradores Colaborador { get; set; }

        public int ClienteId { get; set; }
        public virtual Servicos Cliente { get; set; }

        public int ProdutoId { get; set; }
        public virtual ICollection<Produtos> Produto { get; set; }

        public int Quantidade { get; set; }

        public decimal ValorUnitario { get; set; }

        public Vendas()
        {
            this.Produto = new HashSet<Produtos>();
        }
    }
}
