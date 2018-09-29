using ProjetoModeloDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoModeloDDD.Infra.Data.EntityConfig
{
    class InsumoConfiguration : EntityTypeConfiguration<Insumos>
    {
        public InsumoConfiguration()
        {
            HasKey(p => p.InsumoId);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(250);

            Property(p => p.Estoque )
                .IsRequired();
            
            HasRequired(p => p.Fornecedor)
                .WithMany()
                .HasForeignKey(p => p.FornecedorId);
        }

    }
}
