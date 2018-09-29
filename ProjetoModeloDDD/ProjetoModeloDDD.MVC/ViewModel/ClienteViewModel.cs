using ProjetoModeloDDD.MVC.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModeloDDD.MVC
{
    public class ClienteViewModel
    {
        [Key]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "Preencha o campo!")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres!")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo!")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres!")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres!")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Preencha o campo!")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres!")]
        [EmailAddress(ErrorMessage = "Preencha um email válido!")]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        [Required(ErrorMessage = "Preencha o campo!")]
        [MaxLength(12, ErrorMessage = "Máximo {0} caracteres!")]
        [MinLength(11, ErrorMessage = "Minimo {0} caracteres!")]
        public string Telefone { get; set; }

        public bool Ativo { get; set; }

        public IEnumerable<AgendaViewModel> Agenda { get; set; }
    }
}