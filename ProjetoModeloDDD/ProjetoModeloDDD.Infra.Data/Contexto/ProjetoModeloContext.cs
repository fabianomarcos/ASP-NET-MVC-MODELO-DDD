using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Infra.Data.EntityConfig;
using System;
using System.Linq;

namespace ProjetoModeloDDD.Infra.Data.Contexto
{
    public class ProjetoModeloContext : DbContext
    {
        public ProjetoModeloContext()
            : base("ProjetoModeloDDD")
        {

        }
        public DbSet<Agenda> Agenda { get; set; }

        public DbSet<Atendimento> Atendimentos { get; set; }

        public DbSet<Services> Clientes { get; set; }

        public DbSet<Colaboradores> Colaboradores { get; set; }

        public DbSet<Fornecedores> Fornecedores { get; set; }

        public DbSet<Horarios> Horarios { get; set; }

        public DbSet<Insumos> Insumos { get; set; }

        public DbSet<Itens> Itens { get; set; }

        public DbSet<NFs> NFs { get; set; }

        public DbSet<Produtos> Produtos { get; set; }

        public DbSet<Services> Servicos { get; set; }

        public DbSet<Vendas> Vendas { get; set; }    

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));
            modelBuilder.Configurations.Add(new AgendaConfiguration());
            modelBuilder.Configurations.Add(new AtendimentoConfiguration());
            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new ColaboradorConfiguration());
            modelBuilder.Configurations.Add(new FornecedorConfiguration());
            modelBuilder.Configurations.Add(new HorarioConfiguration());
            modelBuilder.Configurations.Add(new InsumoConfiguration());
            modelBuilder.Configurations.Add(new ItensConfiguration());
            modelBuilder.Configurations.Add(new NFConfiguration());
            modelBuilder.Configurations.Add(new ProdutoConfiguration());
            modelBuilder.Configurations.Add(new ServicoConfiguration());
            modelBuilder.Configurations.Add(new VendaConfiguration());
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
        
    }
}
