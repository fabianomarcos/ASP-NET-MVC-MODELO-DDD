using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModeloDDD.MVC.ViewModel
{
    public class FornecedorViewModel
    {
        
        [Key]
        public int FornecedorId { get; set; }

        [Required(ErrorMessage = "Preencha o campo!")]
        [RegularExpression(@"^\d{3}.?\d{3}.?\d{3}/?\d{3}-?\d{2}$", ErrorMessage = "CNPJ em formato inválido.")]
        public string CNPJ { get; set; }

        [Required(ErrorMessage = "Preencha o campo!")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres!")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo!")]
        [MaxLength(12, ErrorMessage = "Máximo {0} caracteres!")]
        [MinLength(11, ErrorMessage = "Minimo {0} caracteres!")]
        public string Telefone { get; set; }

        public bool Ativo { get; set; }

        public IEnumerable<InsumoViewModel> Insumos { get; set; }

        public IEnumerable<ProdutoViewModel> Produtos { get; set; }
    }
}