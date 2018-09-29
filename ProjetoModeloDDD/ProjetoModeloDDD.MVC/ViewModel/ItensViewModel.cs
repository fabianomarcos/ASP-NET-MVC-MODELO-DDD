using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoModeloDDD.MVC.ViewModel
{
    public class ItensViewModel
    {
        public int ItensId { get; set; }

        public int Quantidade { get; set; }

        public decimal ValorUnitario { get; set; }

        public int ProdutoId { get; set; }
        public virtual ProdutoViewModel Produto { get; set; }

        public VendaViewModel Venda { get; set; }
    }
}