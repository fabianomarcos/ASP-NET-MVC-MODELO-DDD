namespace ProjetoModeloDDD.Domain.Entities
{
    public class Itens
    {
        public int ItensId { get; set; }

        public Vendas Venda { get; set; }

        public int Quantidade { get; set; }

        public decimal ValorUnitario { get; set; }

        public int ProdutoId { get; set; }
        public virtual Produtos Produto { get; set; }
            
    }
}
