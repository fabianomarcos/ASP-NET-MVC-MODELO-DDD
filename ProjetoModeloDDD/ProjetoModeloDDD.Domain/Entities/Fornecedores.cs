using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class Fornecedores
    {
        public int FornecedorId { get; set; }

        public string CNPJ { get; set; }

        public string Nome { get; set; }

        public string Telefone { get; set; }

        public bool Ativo { get; set; }

        public IEnumerable<Produtos> Produtos { get; set; }

        public IEnumerable<Insumos> Insumos { get; set; }
    }
}
