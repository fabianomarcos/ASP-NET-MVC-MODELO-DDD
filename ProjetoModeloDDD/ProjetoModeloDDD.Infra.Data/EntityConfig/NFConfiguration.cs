using ProjetoModeloDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoModeloDDD.Infra.Data.EntityConfig
{
    public class NFConfiguration : EntityTypeConfiguration<NFs>
    {
        public NFConfiguration()
        {
            HasKey(p => p.NotaFiscalId);

            Property(p => p.Numero)
                .IsRequired();

            Property(p => p.Quantidade)
                .IsRequired();

            Property(p => p.Custo)
                .IsRequired();

            Property(p => p.ValorTotal)
                .IsRequired();

            HasRequired(p => p.Fornecedor)
                .WithMany()
                .HasForeignKey(p => p.FornecedorId);

            HasRequired(p => p.Insumo)
                .WithMany()
                .HasForeignKey(p => p.InsumoId);

            HasRequired(p => p.Produto)
                .WithMany()
                .HasForeignKey(p => p.ProdutoId);


        }

    }
}
