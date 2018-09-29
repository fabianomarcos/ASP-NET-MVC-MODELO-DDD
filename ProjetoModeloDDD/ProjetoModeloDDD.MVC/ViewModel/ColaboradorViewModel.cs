using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModeloDDD.MVC.ViewModel
{
    public class ColaboradorViewModel
    {
            [Key]
            public int ColaboradorId { get; set; }


            [Required(ErrorMessage = "Preencha o campo!")]
            [MaxLength(150, ErrorMessage = "Máximo {0} caracteres!")]
            [MinLength(5, ErrorMessage = "Minimo {0} caracteres!")]
            public string Nome { get; set; }

            [Required(ErrorMessage = "Preencha o campo!")]
            [MaxLength(150, ErrorMessage = "Máximo {0} caracteres!")]
            [MinLength(5, ErrorMessage = "Minimo {0} caracteres!")]
            public string Especialidade { get; set; }

            public bool Ativo { get; set; }

            [Required(ErrorMessage = "Preencha o campo!")]
            [MinLength(11, ErrorMessage = "Minimo {0} caracteres!")]
            public string Telefone { get; set; }

            [Required(ErrorMessage = "Preencha o campo!")]
            [MaxLength(150, ErrorMessage = "Máximo {0} caracteres!")]
            [MinLength(5, ErrorMessage = "Minimo {0} caracteres!")]
            public string Cargo { get; set; }

           [Required(ErrorMessage = "Preencha o campo!")]
           public int Comissao { get; set; }

          public IEnumerable<AgendaViewModel> Agenda { get; set; }
    }
}
