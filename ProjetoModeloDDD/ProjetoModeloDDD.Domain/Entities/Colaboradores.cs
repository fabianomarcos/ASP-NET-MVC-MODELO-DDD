using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class Colaboradores
    {
        public int  ColaboradorId { get; set; }

        public string Nome { get; set; }

        public string Especialidade { get; set; }

        public bool Ativo { get; set; }

        public string Telefone { get; set; }

        public string Cargo { get; set; }

        public int Comissao { get; set; }

        public IEnumerable<Agenda> Agenda { get; set; }
    }
}
