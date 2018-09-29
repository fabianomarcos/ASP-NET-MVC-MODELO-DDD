using ProjetoModeloDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoModeloDDD.Infra.Data.EntityConfig
{
    public class VendaConfiguration : EntityTypeConfiguration<Vendas>
    {
        public VendaConfiguration()
        {
            HasKey(c => c.VendasId);

            HasRequired(p => p.Cliente)
                .WithMany()
                .HasForeignKey(p => p.ClienteId);

            HasRequired(p => p.Colaborador)
                .WithMany()
                .HasForeignKey(p => p.ColaboradorId);

            HasRequired(p => p.Produto)
                .WithMany()
                .HasForeignKey(p => p.ProdutoId);
        }
    }
}
