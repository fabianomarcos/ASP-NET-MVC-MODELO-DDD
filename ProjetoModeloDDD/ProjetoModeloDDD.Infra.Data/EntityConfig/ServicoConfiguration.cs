using ProjetoModeloDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoModeloDDD.Infra.Data.EntityConfig
{
    public class ServicoConfiguration : EntityTypeConfiguration<Servicos>
    {
        public ServicoConfiguration()
        {
            HasKey(p => p.ServicosId);

            Property(p => p.Nome)
                .IsRequired()
            .HasMaxLength(150);

            HasRequired(p => p.Insumo)
                .WithMany()
                .HasForeignKey(p => p.InsumoId);

          }

    }
}
