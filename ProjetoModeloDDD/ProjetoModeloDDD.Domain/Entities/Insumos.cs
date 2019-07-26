namespace ProjetoModeloDDD.Domain.Entities
{
    public class Insumos
    {
        public int InsumoId { get; set; }
        public string Nome { get; set; }
        public decimal Estoque { get; set; }
        public bool Ativo { get; set; }
        public virtual Insumos Insumo { get; set; }

        public int FornecedorId { get; set; }
        public virtual Fornecedores Fornecedor { get; set; }
    }
}
