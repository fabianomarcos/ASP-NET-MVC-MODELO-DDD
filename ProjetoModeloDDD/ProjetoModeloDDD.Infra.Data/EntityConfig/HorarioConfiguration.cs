using ProjetoModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Infra.Data.EntityConfig
{
    public class HorarioConfiguration : EntityTypeConfiguration<Horarios>
    {
        public HorarioConfiguration()
        {
            HasKey(c => c.HorarioId);

            Property(c => c.Horas)
                .IsRequired();

            HasRequired(p => p.Colaborador)
           .WithMany()
           .HasForeignKey(p => p.ColaboradorId);
        }       
    }
}
