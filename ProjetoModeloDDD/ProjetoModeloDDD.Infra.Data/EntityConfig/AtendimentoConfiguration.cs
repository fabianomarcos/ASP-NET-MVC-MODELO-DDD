using ProjetoModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Infra.Data.EntityConfig
{
    public class AtendimentoConfiguration : EntityTypeConfiguration<Atendimento>
    {
        public AtendimentoConfiguration()
        {
            HasKey(c => c.AtendimentoId);

            Property(c => c.Data)
                .IsRequired();

            Property(p => p.Valor)
                 .IsRequired();

            Property(c => c.Data)
                .IsRequired();

            HasRequired(p => p.Cliente)
                .WithMany()
                .HasForeignKey(p => p.ClienteId);

            HasRequired(p => p.Colaborador)
                .WithMany()
                .HasForeignKey(p => p.ColaboradorId);

            HasRequired(p => p.Insumo)
                .WithMany()
                .HasForeignKey(p => p.InsumoId);

            HasRequired(p => p.Servico)
                .WithMany()
                .HasForeignKey(p => p.ServicoId);

        }
    }
}
