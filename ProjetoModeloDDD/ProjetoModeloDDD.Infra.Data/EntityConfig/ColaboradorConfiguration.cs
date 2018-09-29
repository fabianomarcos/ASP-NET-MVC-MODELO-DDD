using ProjetoModeloDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoModeloDDD.Infra.Data.EntityConfig
{
    public class ColaboradorConfiguration : EntityTypeConfiguration<Colaboradores>
    {
        public ColaboradorConfiguration()
        {
            HasKey(c => c.ColaboradorId);

            Property(c => c.Especialidade)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Nome)
                 .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Telefone)
                .IsRequired()
                .HasMaxLength(11);

            Property(c => c.Cargo)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Comissao)
               .IsRequired();
        }
    }
}
