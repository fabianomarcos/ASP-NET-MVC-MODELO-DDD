namespace ProjetoModeloDDD.Domain.Entities
{
    public class NFs
    {
        public int NotaFiscalId { get; set; }

        public int Numero { get; set; }

        public decimal Custo { get; set; }

        public decimal ValorTotal { get; set; }

        public decimal Quantidade { get; set; }

        public int FornecedorId { get; set; }
        public virtual Fornecedores Fornecedor { get; set; }

        public int InsumoId { get; set; }
        public virtual Insumos Insumo { get; set; }

        public int ProdutoId { get; set; }
        public virtual Produtos Produto { get; set; }
    }
}
