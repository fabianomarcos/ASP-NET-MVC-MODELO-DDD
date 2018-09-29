using ProjetoModeloDDD.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModeloDDD.MVC.ViewModel
{
    public class HorariosViewModel
    {
        [Key]
        public int HorarioId { get; set; }

        public string Horas { get; set; }

        [Display(Name = "Data")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime? Data { get; set; }

        
        public int ColaboradorId { get; set; }
        public virtual Colaboradores Colaborador { get; set; }
    }
}