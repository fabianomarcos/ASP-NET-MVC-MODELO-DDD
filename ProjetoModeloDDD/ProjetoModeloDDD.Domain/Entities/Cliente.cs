using System;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class Services
    {
        public int ClienteId { get; set; }

        public string Nome { get; set; }

        public string telefone { get; set; }

        public string Sobrenome { get; set; }

        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

        public bool ClienteEspecial(Services cliente)
        {
            return cliente.Ativo && DateTime.Now.Year - cliente.DataCadastro.Year >= 5;
        }
        public IEnumerable<Agenda> Agenda { get; set; }

    }
}
