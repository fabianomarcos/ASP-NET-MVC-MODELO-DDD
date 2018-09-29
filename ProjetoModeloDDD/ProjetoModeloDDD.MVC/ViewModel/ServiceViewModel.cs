using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModeloDDD.MVC.ViewModel
{
    public class ServiceViewModel
    {
        [Key]
        public int ServicosId { get; set; }

        [Required(ErrorMessage = "Preencha o campo!")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres!")]
        [MinLength(5, ErrorMessage = "Minimo {0} caracteres!")]
        public string Nome { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "999999999999")]
        [Required(ErrorMessage = "Preencha um valor")]
        public decimal Valor { get; set; }

        public int InsumoId { get; set; }
        public virtual InsumoViewModel Insumo { get; set; }

        public IEnumerable<AgendaViewModel> Agenda { get; set; }
    }
}
