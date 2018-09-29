using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModeloDDD.MVC.ViewModel
{
    public class InsumoViewModel
    {
        [Key]
        public int InsumoId { get; set; }

        [Required(ErrorMessage = "Preencha o campo!")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres!")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo!")]
        public decimal Estoque { get; set; }

       // public decimal Valor { get; set; }

        public bool Ativo { get; set; }

        public int FornecedorId { get; set; }
        public virtual FornecedorViewModel Fornecedor { get; set; }

        public IEnumerable<ServiceViewModel> Servico { get; set; }

        
    }
}