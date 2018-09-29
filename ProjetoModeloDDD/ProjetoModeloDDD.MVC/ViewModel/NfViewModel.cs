using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoModeloDDD.MVC.ViewModel
{
    public class NfViewModel
    {
        public int NotaFiscalId { get; set; }

        public int Numero { get; set; }

        public decimal Custo { get; set; }

        public decimal ValorTotal { get; set; }

        public decimal Quantidade { get; set; }

        public int FornecedorId { get; set; }
        public virtual FornecedorViewModel Fornecedor { get; set; }

        public int InsumoId { get; set; }
        public virtual InsumoViewModel Insumo { get; set; }

        public int ProdutoId { get; set; }
        public virtual ProdutoViewModel Produto { get; set; }
    }
}