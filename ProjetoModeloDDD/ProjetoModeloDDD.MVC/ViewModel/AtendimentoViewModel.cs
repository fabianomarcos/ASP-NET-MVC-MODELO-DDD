using ProjetoModeloDDD.MVC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoModeloDDD.MVC.ViewModel
{
    public class AtendimentoViewModel
    {
        public int AtendimentoId { get; set; }

        public string NomeCliente { get; set; }

        public string ServicoId { get; set; }
        public virtual ServiceViewModel Service { get; set; }

        public int ClienteId { get; set; }
        public virtual ClienteViewModel Cliente { get; set; }

        public string ColaboradorId { get; set; }
        public virtual ColaboradorViewModel Colaborador { get; set; }

        public int InsumoId { get; set; }
        public virtual InsumoViewModel Insumo { get; set; }

        public DateTime Data { get; set; }

        public decimal Valor { get; set; }

        public DateTime Horario { get; set; }
    }
}