using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class Produtos
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public decimal Valor { get; set; }
        public bool Ativo { get; set; }
        public decimal Estoque { get; set; }
        public int FornecedorId { get; set; }
        public virtual Fornecedores Fornecedor { get; set; }

        public IEnumerable<Itens> Itens { get; set; }

        public ICollection<Vendas> Vendas { get; set; }
    }
} 
