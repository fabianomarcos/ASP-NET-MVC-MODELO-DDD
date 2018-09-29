using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModeloDDD.MVC.ViewModel
{
    public class AgendaViewModel
    {
        [Key]
        public int AgendaId { get; set; }

        public int ServicosId { get; set; }
        public virtual ServiceViewModel Servico { get; set; }
        
        public int ClienteId { get; set; }
        public virtual ClienteViewModel Cliente { get; set; }

        public int ColaboradorId { get; set; }
        public virtual ColaboradorViewModel Colaborador { get; set; }

        public string Horas { get; set; }

        [Display(Name = "Data")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime? Data { get; set; }

        public bool Disponivel { get; set; }
    }
}