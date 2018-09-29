using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.MVC.ViewModel;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModeloDDD.MVC
{
    public class ProdutoViewModel
    {
        [Key]
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "Preencha o campo!")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres!")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo!")]
        [MaxLength(15, ErrorMessage = "Máximo {0} caracteres!")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres!")]
        public string Codigo { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "999999999999")]
        [Required(ErrorMessage = "Preencha um valor")]
        public decimal Valor { get; set; }
       
        public bool Ativo { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "999999999999")]
        [Required(ErrorMessage = "Preencha um valor")]
        public decimal Estoque { get; set; }

        public int FornecedorId { get; set; }
        public virtual FornecedorViewModel Fornecedor { get; set; }

        public IEnumerable<ItensViewModel> Itens { get; set; }

        public ICollection<VendaViewModel> Vendas { get; set; }
    }
}