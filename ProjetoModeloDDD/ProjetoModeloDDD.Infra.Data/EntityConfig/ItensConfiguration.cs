using ProjetoModeloDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoModeloDDD.Infra.Data.EntityConfig
{
    public class ItensConfiguration : EntityTypeConfiguration<Itens>
    {
        public ItensConfiguration()
        {
            HasKey(p => p.ItensId);

            Property(p => p.Quantidade)
                .IsRequired();

            Property(p => p.ValorUnitario)
                .IsRequired();

            HasRequired(p => p.Produto)
                .WithMany()
                .HasForeignKey(p => p.ProdutoId);
        }
    }
}
