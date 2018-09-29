using ProjetoModeloDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoModeloDDD.Infra.Data.EntityConfig
{
    public class FornecedorConfiguration : EntityTypeConfiguration<Fornecedores>
    {
        public FornecedorConfiguration()
        {
            HasKey(c => c.FornecedorId);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Telefone)
                .IsRequired()
                .HasMaxLength(11);
        }
    }
}
